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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void bntExitLoginForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            found f = new found();
            f.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_up signup = new sign_up();
            signup.Show();

          
        }
    }
}
