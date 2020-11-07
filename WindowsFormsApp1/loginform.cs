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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            login();
             
        }
        private void login()
        {
            string id = txtUserId.Text;
            string pass = txtPass.Text;
            if (id == "123" && pass == "12345")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("password or username is incorrect");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txtUserId.Text = "";
            txtPass.Text = "";
        }

      

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                reset();

            }
        }

      
    }
}
