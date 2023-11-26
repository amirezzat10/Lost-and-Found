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
    public partial class sign_up : Form
    {
        string file_name;
        public FileStream output;
        public StreamWriter fileWriter;
        public StreamReader fileReader;
        public sign_up()
        {
            InitializeComponent();
        }

        private void bntExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            file_name = @"text.txt";
            output = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // sets file to where data is written
            fileWriter = new StreamWriter(output);
            fileReader = new StreamReader(output);
            //MessageBox.Show("File Opend");


            output.Seek(0, SeekOrigin.End);

            string checkboxtet3 = checkBox3.Text;
            string checkboxtet4 = checkBox4.Text;
            string checkboxtet5 = checkBox5.Text;
            string checkboxtet6 = checkBox6.Text;
            string checkboxtet7 = checkBox7.Text;
            string checkboxtet8 = checkBox8.Text;
            string checkboxtet9 = checkBox9.Text;



            string s="";


            if (checkBox3.Checked == true) 
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet3 + "|" + "15" + "|" +lblSelected.Text + "|" + "After 10 Days";

            }
            if (checkBox4.Checked==true)
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet4 + "|" + "10" + "|" + lblSelected.Text + "|" + "After 10 Days";

            }
            if (checkBox5.Checked == true)
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|"  + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet5 + "|" + "10" + "|" + lblSelected.Text + "|" + "After 10 Days";

            }
            if (checkBox6.Checked == true)
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|"  + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet6 + "|" + "10" + "|" + lblSelected.Text + "|" + "After 10 Days";

            }
            if (checkBox7.Checked == true)
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet7 + "|" + "5" + "|" + lblSelected.Text + "|" + "After 10 Days";

            }
            if (checkBox8.Checked == true)
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|" + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet8 + "|" + "5" + "|" + lblSelected.Text + "|" + "After 10 Days";

            }
            if (checkBox9.Checked == true)
            {
                s = textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|"  + textBox6.Text + "|" + textBox7.Text + "|"
                        + checkboxtet9 + "|" + "10" + "|" + lblSelected.Text + "|" + "After 10 Days";

            }





            fileWriter.WriteLine(s); 

            fileWriter.Flush();
            fileWriter.Close();
            output.Close();
            fileReader.Close();


            MessageBox.Show("Your Request Has Been Submitted");

            Output_form cus1 = new Output_form();
            cus1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            lblSelected.Text = ComPlaces.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }
    }
}
