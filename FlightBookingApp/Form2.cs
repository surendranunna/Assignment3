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
            if(Form1.passport)
            {
                lblChangeDocNo.Text = "Passport No :";
                lblChangeDocExpiry.Text = "Passport Expiry Date :";

            }
            if(Form1.idCard)
            {
                lblChangeDocNo.Text = "Id Card No :";
                lblChangeDocExpiry.Text = "Id Card Expiry Date :";

            }
            lblFullName.Text = Form1.firstName + " " + Form1.lastName;
            lblDepatureCity.Text = Form1.from;
            lblDestinationCity.Text = Form1.to;
            lblTripDates.Text = Form1.startTripDate + "  to " + Form1.endTripDate;
            lblDocNo.Text = Form1.documentNo;
            lblDocExpiryDate.Text = Form1.expiryDate;
            lblBagWeight.Text = Form1.weightBaggage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
