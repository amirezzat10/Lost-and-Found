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

namespace WindowsFormsApp1
{
    public partial class found : Form
    {
        string file_name;
        public FileStream output;
        public StreamWriter fileWriter;
        public StreamReader fileReader;

        public found()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            file_name = @"Requests Of Found Items.txt";
            output = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // sets file to where data is written
            fileWriter = new StreamWriter(output);

            output.Seek(0, SeekOrigin.End);


            string line ="";

            line = textBox1.Text + "|" + comboBox1.Text + "|" + comboBox2.Text;

            fileWriter.WriteLine(line);
            fileWriter.Flush();
            MessageBox.Show("Request Saved");
            

        }

        private void bntExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
