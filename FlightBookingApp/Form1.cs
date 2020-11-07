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
    public partial class Form1 : Form
    {
        public static Boolean Passport, IdCard;
        public static string To, From, StartTripDate, EndTripDate, FirstName, LastName, DocumentNo, IsuueDate, ExpiryDate, WeightBaggage;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           


        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb.Checked)
            {
                lblDocNo.Text = "Passport No :";
                lblDocExpiryDate.Text = "Passport Expiry Date :";
                lblDocIssueDate.Text = "Passport Issue Date :";
                Passport = true;
            }
            else
            {
                Passport = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            To = txtTo.Text;
            From = txtFrom.Text;
            StartTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MMM yyyy");
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            DocumentNo = txtDocNo.Text;
            IsuueDate = dateTimePicker1.Value.ToString("dd MMM yyyy");
            ExpiryDate = dateTimePicker2.Value.ToString("dd MMM yyyy");
            WeightBaggage = numericUpDown1.Value.ToString();

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void rdbIdCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIdCard.Checked)
            {
                lblDocNo.Text = "Id Card No :";
                lblDocExpiryDate.Text = "Id Card Expiry Date :";
                lblDocIssueDate.Text = "Id Card Issue Date :";
                IdCard = true;
            }
            else
            {
                IdCard = false;
            }

        }
    }
}
