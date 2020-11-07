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

        private void set_Click(object sender, EventArgs e)
        {
            lblHelo.Text = "Hello World again";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblHelo.Text = "Hello World";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            lblHelo.Text = "text has been cancelled";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHelo.Text = "Hello World";

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform f = new loginform();
             f.Show();


        }
    }
}
