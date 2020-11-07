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
    public partial class SignUp : Form
    {
        public static string fName;
        public static string lName;
        public static string emailId;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transaction;
        Confirmation c = new Confirmation();
      public SignUp()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            fName = H.Text;
            lName = txtlastname.Text;
            emailId = txtemail.Text;
           
            this.Hide();
            c.Show();
        }

        private void chksms_CheckedChanged(object sender, EventArgs e)
        {
            if( chksms.Checked)
            {
                sms =true;

                lblsms.Text = "services charges may apply for sms";

            }
            else
            {
                sms = false;

                lblsms.Text = "....";
            }



        }

        private void chkreports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreports.Checked)
            {
                reports = true;

            }
            else
            {
                reports = false;
            }




        }

        private void chktranreports_CheckedChanged(object sender, EventArgs e)
        {



            if (chktranreports.Checked)
            {
                transaction = true;

                lbltranscationmessage.Text = "services charges may apply for transaction";


            }
            else
            {
                transaction = false;

                lbltranscationmessage.Text = "....";
            }
        }
    }
}
