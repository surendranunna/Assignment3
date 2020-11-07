using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Form1.Passport)
            {
                lblChangeDocNo.Text = "Passport No :";
                lblChangeDocExpiry.Text = "Passport Expiry Date :";

            }
            if (Form1.IdCard)
            {
                lblChangeDocNo.Text = "Id Card No :";
                lblChangeDocExpiry.Text = "Id Card Expiry Date :";

            }
            lblFullName.Text = Form1.FirstName + " " + Form1.LastName;
            lblDepatureCity.Text = Form1.From;
            lblDestinationCity.Text = Form1.To;
            lblTripDates.Text = Form1.StartTripDate + "  to " + Form1.EndTripDate;
            lblDocNo.Text = Form1.DocumentNo;
            lblDocExpiryDate.Text = Form1.ExpiryDate;
            lblBagWeight.Text = Form1.WeightBaggage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
