using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chktranreports_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblfirstname.Text = SignUp.fName;
            lbllastname.Text = SignUp.lName;
            lblemail.Text = SignUp.emailId;
            if (SignUp.sms)
            {
                lblsms.Text = "✔ ";

            }

            if (SignUp.reports)
            {
                lblreports.Text = "✔";
            }
            if (SignUp.transaction)
            {
                lbltransaction.Text= "✔";
            } 




        }
    }
}
