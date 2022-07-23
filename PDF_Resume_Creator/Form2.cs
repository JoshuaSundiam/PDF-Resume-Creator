using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Resume_Creator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog() { Filter = "JSON| *.json", ValidateNames = true, Multiselect = false })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = @"C:\Users\JOSHUA\Desktop\New folder\Sample.json";
                    StreamReader read = new StreamReader(path);
                    string fileData = read.ReadToEnd();
                    richTextBox1.Text = fileData;
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF| *.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                   richTextBox1.Text.Document
                }
            }
        }
    }
}
