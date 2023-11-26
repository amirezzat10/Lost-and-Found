using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //sign_up signup = new sign_up();
            //signup.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            username.ToLower();

            string password = textBox2.Text;
            password.ToLower();

            if (/*radioButton1.Checked == true &&*/ username == "admin" && password == "admin")
            {
                this.Hide();
                first_form fform = new first_form();
                fform.Show();
            }

            //else if (username == "Aasem" && password == "12345")
            //{
            //    this.Hide();
            //    customer cust = new customer();
            //    cust.Show();
            //}
            else
            {
                MessageBox.Show("Wrong Username or Password");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
