using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveJsonFilebtn_Click(object sender, EventArgs e)
        {
        List<Person> listPersons = new List<Person>();
 //           try
 //           {
 //Person p1 = new Person()
 //           {
 //               name = NameBox.Text,
 //               contactNo = Convert.ToInt16(ContactBox.Text),
 //               Email = EmailBox.Text,  
 //               Personal_Info = PersonalInfoBox.Text,
 //               educBackground = EducBgBox.Text,
 //           };
 //           string json = JsonConvert.SerializeObject(p1, Formatting.Indented);
          
 //           listPersons.Add(p1);
 //           File.WriteAllText(@"C:\Users\JOSHUA\Desktop\C# PDF Resume.json",json);
 //           }
 //           catch (Exception)
 //           {

 //               MessageBox.Show("error");
 //           }
            Person p1 = new Person()
            {
                name = NameBox.Text,
                contactNo = ContactBox.Text,
                Email = EmailBox.Text,
                Personal_Info = PersonalInfoBox.Text,
                educBackground = EducBgBox.Text,
            };
            string json = JsonConvert.SerializeObject(p1, Formatting.Indented);

            listPersons.Add(p1);
            File.WriteAllText(@"C:\C# PDF Resume", json);
        }
        class Person
        {
            public string name;
            public string contactNo;

            public string Email; 
            public string Personal_Info;
            public string educBackground;
        }
    }
}
