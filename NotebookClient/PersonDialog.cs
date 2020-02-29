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
    public partial class PersonDialog : Form
    {
        private String firstname { get; set; }
        private String secondname { get; set; }
        private DateTime birthday { get; set; }
        private int id;
        private string _baseAddress;
        private Boolean isNewItem = true;

        public PersonDialog(String url)
        {
            InitializeComponent();
            _baseAddress = url;
        }

        public PersonDialog(string url, int id, string firstname, string secondname, DateTime birthday)
        {
            InitializeComponent();
            _baseAddress = url;
            firstnameTxtBox.Text = firstname;
            secondnameTxtBox.Text = secondname;
            birthdayPicker.Value = birthday;
            this.id = id;
            this.isNewItem = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            firstname = firstnameTxtBox.Text;
            secondname = secondnameTxtBox.Text;
            birthday = birthdayPicker.Value;
            if (isNewItem)
            {
                Add();
            }
            else
            {
                Modify();
            }
            
        }

        private void Modify()
        {
            Person newReport = new Person(firstname, secondname, birthday);
            newReport.Id = this.id;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("api/People/" + this.id, newReport).Result;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Add()
        {
            Person newReport = new Person(firstname,secondname,birthday) ;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("api/People", newReport).Result;
                DialogResult = DialogResult.OK;
                Close();
            }

            
        }
    }
}
