using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4Diloge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
           
            DialogResult dr =MessageBox.Show("1: To Purchase , press = yes \n 2: For 30 days trial version, press = No \n 3: Cancel Order", "Purchase Software", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if(dr==DialogResult.Yes)
            {
                lblyesno.Text = "you have purchased software,congratulations";
                lblcancel.Text = "....";
            }
            if (dr == DialogResult.No)
            {
                lblyesno.Text = "30 days trail version starts,congratulations";
                lblcancel.Text = "....";
            }
            if (dr == DialogResult.Cancel)
            {
                lblcancel.Text = "you have cancelled the order";
                lblyesno.Text = ".....";
            }


        }
    }
}
