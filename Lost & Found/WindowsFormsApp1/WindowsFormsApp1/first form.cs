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
    public partial class first_form : Form
    {

        string file_name;
        public FileStream output;
        public StreamWriter fileWriter;
        public StreamReader fileReader;

        public first_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void first_form_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        private void bntExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e) //Search
        {

            //file_name = @"text.txt";
            //output = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Read);
            //// sets file to where data is written
            //fileReader = new StreamReader(output);
            ////MessageBox.Show("File Opend");

            //output.Seek(0, SeekOrigin.Begin);
            //string line;
            //string[] field;
            //int count = 0;
            
            //line = fileReader.ReadLine();


            //while ((line = fileReader.ReadLine()) != null)
            //{
            //    field = line.Split('|');
            //    if (line[0] == '*')
            //        return;


            //    if (FNameBox.Text == field[0])
            //    {
            //        output.Seek(count, SeekOrigin.Begin);
            //        FNameBox.Text = field[0];
            //        LNameBox.Text = field[1];
            //        EmailBox.Text = field[2];
            //        PasswordBox.Text = field[3];
            //        PhoneBox.Text = field[5];
            //        AddressBox.Text = field[6];
            //        LostBox.Text = field[7];
            //        FeesBox.Text = field[8];
            //        DataBox.Text = "After one week";

            //        return;
                   
            //    }
            //    count = line.Length + 1;
            //}
            //MessageBox.Show("not found");



            //output.Flush();
            //output.Close();
            //fileReader.Close();
            //fileWriter.Close();
           
        }

        private void button1_Click(object sender, EventArgs e) // delete
        {

            //file_name = @"text.txt";
            //output = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //// sets file to where data is written
            //fileReader = new StreamReader(output);
            //MessageBox.Show("File Opend");
            //fileWriter = new StreamWriter(output);
            //string line;
            //fileReader.ReadToEnd();
            //output.Seek(0, SeekOrigin.Begin);
            ////////////////////////////////////////////
            //string[] field;
            //int count = 0;
            //while ((line = fileReader.ReadLine()) != null)
            //{
            //    field = line.Split('|');
            //    if (field[0] == FNameBox.Text)
            //    {
            //        output.Seek(count, SeekOrigin.Begin);
            //        output.Flush();
            //        // long pos = output.Position;
            //        fileWriter.Write("*");
            //        fileWriter.Flush();
            //        // pos = output.Position;
            //        MessageBox.Show("Done");
            //        return;
            //    }
            //    count = line.Length + 1;
            //}
            //MessageBox.Show("Not found ");


            //output.Flush();
            //output.Close();
            //fileReader.Close();
            //fileWriter.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"text.txt");
            string line;


            List<string> data = File.ReadAllLines("text.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { '|' },
                       StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(items));
            }
            while (  (line = file.ReadLine()) !=null )
            {

                listView1.Items.Add(line);
                c++;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"Requests Of Found Items.txt");
            string line;


            List<string> data = File.ReadAllLines("Requests Of Found Items.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { '|' },
                       StringSplitOptions.RemoveEmptyEntries);
                listView2.Items.Add(new ListViewItem(items));
            }
            while ((line = file.ReadLine()) != null)
            {

                listView2.Items.Add(line);
                c++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
