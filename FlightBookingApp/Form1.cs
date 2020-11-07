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
        public static Boolean passport, idCard;
        public static string to, from, startTripDate, endTripDate, firstName, lastName, documentNo, isuueDate, expiryDate, weightBaggage;
        public Form1()
        {
           InitializeComponent();
        }

        private void Rdb_CheckedChanged(object sender, EventArgs e)
        {
            if(Rdb.Checked)
            {
                lblDocNo.Text = "Passport No :";
                lblDocExpiryDate.Text = "Passport Expiry Date :";
                lblDocIssueDate.Text = "Passport Issue Date :";
                passport = true;
            }
            else
            {
                passport = false;
            }

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTimePicker1.Value;
            DateTimePicker2.MinDate = dt;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MonthCalendar1.MaxSelectionCount = 100;
            MonthCalendar1.ShowToday = true;
            NumericUpDown1.Increment = 5;
            NumericUpDown1.ReadOnly = true;
        }

        private void BtnBookNow_Click(object sender, EventArgs e)
        {
            to = TxtTo.Text;
            from = TxtFrom.Text;
            startTripDate = MonthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            endTripDate = MonthCalendar1.SelectionEnd.ToString("dd MMM yyyy");
            firstName = TxtFirstName.Text;
            lastName = TxtLastName.Text;
            documentNo = TxtDocNo.Text;
            isuueDate = DateTimePicker1.Value.ToString("dd MMM yyyy");
            expiryDate = DateTimePicker2.Value.ToString("dd MMM yyyy");
            weightBaggage = NumericUpDown1.Value.ToString();

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void RdbIdCard_CheckedChanged(object sender, EventArgs e)
        {
            if(RdbIdCard.Checked)
            {
                lblDocNo.Text = "Id Card No :";
                lblDocExpiryDate.Text = "Id Card Expiry Date :";
                lblDocIssueDate.Text = "Id Card Issue Date :";
                idCard = true;
            }
            else
            {
                idCard = false;
            }

        }
    }
}
