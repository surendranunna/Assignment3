using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {

            lblDateTime.Text = dtPicker.Value.ToString();
            lblDate.Text = dtPicker.Value.ToString("MMMM,dddd,yyyy");
            lblDateDay.Text = dtPicker.Value.ToLongDateString();
            lblTime.Text = dtPicker.Value.ToShortTimeString();
            lblTimesSec.Text = dtPicker.Value.ToLongTimeString();

              
        }

       
    }
}
