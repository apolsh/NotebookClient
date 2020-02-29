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
    public partial class NewContact : Form
    {
        private string baseUrl;
        private ContactType[] types;
        int? personId;
        public NewContact(string baseUrl, ContactType[] types, int? personId)
        {
            InitializeComponent();
            this.baseUrl = baseUrl;
            this.types = types;
            this.personId = personId;

            foreach (var type in this.types)
            {
                typeCBox.DisplayMember = "Title";
                typeCBox.DataSource = types;
            }
        }

        


        private void okBtn_Click(object sender, EventArgs e)
        {
            if(valueTBox.Text.Length == 0)
            {
                MessageBox.Show("Значение не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int typeId = ((ContactType)typeCBox.SelectedItem).Id;
            string typeValue = valueTBox.Text;

            Contact newContact = new Contact() { Value = typeValue, PersonId = personId, ContactTypeId = typeId };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/Contacts", newContact).Result;
                DialogResult = DialogResult.OK;
                Close();
            }



        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
