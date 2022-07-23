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

            Person p1 = new Person()
            {
                name = NameBox.Text,
                contactNo = ContactBox.Text,
                Email = EmailBox.Text,
                Personal_Info =PI.Text,
                Birthday = BDay.Text,
                PlaceOfBirth = PlaceBirth.Text,
                CivilStatus = CivilStatus.Text,
                Religion = Religion.Text,
                Citizenship = Citizenship.Text,
                MthName = MName.Text,
                MOccupation = MOccupation.Text,
                FthName = FName.Text,
                FOccupation = FOccupation.Text,

                educBackground = EB.Text,
                Tertiary = EducTertiary.Text,
                Secondary = EducSecondary.Text,
                Primary = EducPrimary.Text,
            };
            string json = JsonConvert.SerializeObject(p1, Formatting.Indented);

            listPersons.Add(p1);
            //File.WriteAllText(@"C:\Users\JOSHUA\Desktop\New folder.json", json);
            string location = @"C:\Users\JOSHUA\Desktop\Contact Tracing\QR CODE";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = location;
            dialog.Filter = "JSON| *.json";
          
        }
        class Person
        {
            public string name;
            public string contactNo;

            public string Email; 
            public string Personal_Info;
            public string Birthday;
            public string PlaceOfBirth;
            public string CivilStatus;
            public string Religion;
            public string Citizenship;
            public string MthName;
            public string MOccupation;
            public string FthName;
            public string FOccupation;
            public string educBackground;
            public string Tertiary; 
            public string Secondary; 
            public string Primary;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
    }

