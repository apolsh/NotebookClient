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
    public partial class Form1 : Form
    {
        const string _baseAddress = "http://localhost:55903/";

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            using (var client = new HttpClient())
            {
                listView.Items.Clear();
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/People").Result;
                if (response.IsSuccessStatusCode)
                {
                    Person[] reports = response.Content.ReadAsAsync<Person[]>().Result;
                    foreach (var p in reports)
                    {
                        var item = new ListViewItem(new[] { p.Firstname, p.Secondname, p.BirthDay.ToShortDateString() });
                        item.Tag = p.Id;
                        listView.Items.Add(item);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int id = (int)listView.SelectedItems[0].Tag;
                Delete(id);
                Update();
            }

        }

        private void Delete(int delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync("api/People/" + delete).Result;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonDialog newContactWindow = new PersonDialog(_baseAddress);
            //newContactWindow.MdiParent = this;
            newContactWindow.ShowDialog();
            if (newContactWindow.DialogResult == DialogResult.OK)
            {
                Update();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                PersonDialog newContactWindow = new PersonDialog(_baseAddress, (int)item.Tag, item.SubItems[0].Text, item.SubItems[1].Text, DateTime.Parse(item.SubItems[2].Text));
                newContactWindow.ShowDialog();
                if (newContactWindow.DialogResult == DialogResult.OK)
                {
                    Update();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                Contacts newContactWindow = new Contacts(_baseAddress, (int)item.Tag);
                newContactWindow.ShowDialog();
            }
        }
    }
}
