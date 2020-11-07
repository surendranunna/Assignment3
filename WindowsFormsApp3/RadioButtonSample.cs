using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class RadioButtonSample : Form
    {
        public RadioButtonSample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input;
            if(radioButton1.Checked==true)
                {

                input = radioButton1.Text;
                MessageBox.Show(input);
                    
                    }
            if (radioButton2.Checked == true)
            {

                input = radioButton2.Text;
                MessageBox.Show(input);

            }
            if (radioButton3.Checked == true)
            {

                input = radioButton3.Text;
                MessageBox.Show(input);

            }




        }
    }
}
