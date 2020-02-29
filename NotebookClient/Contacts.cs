using NotebookApi1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookClient
{
    public partial class Contacts : Form
    {
        private string baseUrl;
        private int personId;
        ContactType[] types;
        Contact[] contacts;

        public Contacts(string url, int personId)
        {
            InitializeComponent();
            baseUrl = url;
            this.personId = personId;
            updateData();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void updateData()
        {
            getTypes();
            getContacts();
            fillListView();
        }

        private void getTypes()
        {
            using (var client = new HttpClient())
            {
                listViewContacts.Items.Clear();
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;
                response = client.GetAsync("api/ContactTypes/").Result;
                types = response.Content.ReadAsAsync<ContactType[]>().Result;
            }
        }

        private void getContacts()
        {
            using (var client = new HttpClient())
            {
                listViewContacts.Items.Clear();
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;
                response = client.GetAsync("api/Contacts/" + personId).Result;
                contacts = response.Content.ReadAsAsync<Contact[]>().Result;
            }
        }

        private void fillListView()
        {
            foreach (var c in contacts)
            {
                var item = new ListViewItem(new[] { types[c.ContactTypeId.GetValueOrDefault()-1].Title, c.Value});
                item.Tag = c.Id;
                listViewContacts.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewContact newContactWindow = new NewContact(baseUrl, types, personId);
            newContactWindow.ShowDialog();
            if (newContactWindow.DialogResult == DialogResult.OK)
            {
                updateData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewContacts.SelectedItems.Count != 0)
            {
                int id = (int)listViewContacts.SelectedItems[0].Tag;
                Delete(id);
                updateData();
            }
        }

        private void Delete(int delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync("api/Contacts/" + delete).Result;

            }
        }
    }
}
