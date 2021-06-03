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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void enter_click(object sender, EventArgs e)
        {
            StreamWriter OutputFile;
            OutputFile = File.AppendText("Output.txt");

            OutputFile.WriteLine("Your Information:");
            OutputFile.WriteLine("================================");
            OutputFile.WriteLine("Name: " + name_input.Text);
            OutputFile.WriteLine("Age: " + age_input.Text);
            OutputFile.WriteLine("Address: " + address_input.Text);
            OutputFile.WriteLine("Contact/s: " + contact_input.Text);
            OutputFile.Close();
        }
    }
}
