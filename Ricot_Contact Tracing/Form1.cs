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

namespace Ricot_Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_click(object sender, EventArgs e)
        {
            StreamWriter OutputFile;
            OutputFile = File.AppendText("Output.txt");

            OutputFile.WriteLine("Your Information:");
            OutputFile.WriteLine("================================");
            OutputFile.WriteLine("Name: " + name_input.Text);
            OutputFile.WriteLine("Gender: " + gender_input.Text);
            OutputFile.WriteLine("Age: " + age_input.Text);
            OutputFile.WriteLine("Address: " + address_input.Text);
            OutputFile.WriteLine("Contact/s: " + contact_input.Text);
            OutputFile.WriteLine("Have you been in contact with other person? " + InContact_input.Text);
            OutputFile.WriteLine("================================");
            OutputFile.WriteLine("Symptoms: ");

            foreach (Control symptom in panel3.Controls)
            {
                if ((symptom is CheckBox) && ((CheckBox)symptom).Checked)
                {
                    OutputFile.WriteLine(symptom.Text);
                }
            }

            OutputFile.Close();
            MessageBox.Show("Information Coded Successfully!");
        }

        private void new_click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:\JOSHUA\Documents\College Portfolio\2nd Sem\OOP\Ricot_Contact Tracing\Ricot_Contact Tracing\bin\Debug";
                openFileDialog.DefaultExt = "txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ;
                }
            }
        }

        private void reset_click(object sender, EventArgs e)
        {

        }
    }
}
