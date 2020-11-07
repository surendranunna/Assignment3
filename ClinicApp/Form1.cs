using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dtDoctors = new DataTable();
        DataTable dtSpecificClinicDoctors = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FilClinicTable();
            FillDoctorsTable();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CName";
        }
        private void FilClinicTable()
        {
            dt.Columns.Add("CID",typeof(int));
            dt.Columns.Add("CName");
            dt.Columns.Add("CAddress");
            dt.Columns.Add("CContact");
            dt.Columns.Add("CRating");

            dt.Rows.Add(1, "Dentist Pro Clinic", "Kukatpally","9989012345 ", "9/10");
            dt.Rows.Add(2, "Rainbow Hosiptal", "Madinaguda","996305678","8/10");
            dt.Rows.Add(3, "Apurava Health Care", "Ameerpeta","9985231456", "7/10");
            dt.Rows.Add(4, "Yasodho Hosiptals", "Miyapur","8179143143" ,"10/10");


        }
        private void FillDoctorsTable()
        {
            dtDoctors.Columns.Add("CID", typeof(int));
            dtDoctors.Columns.Add("DName");
            dtDoctors.Columns.Add("DSpecialty");
            dtDoctors.Columns.Add("DContact");


            dtDoctors.Rows.Add(1, "Dr Krishna Manohar", "Heart specilist", "9100923456 ");
            dtDoctors.Rows.Add(1, "Dr Radha Krishna", "Dentist", "996356789");
            dtDoctors.Rows.Add(2, "Dr Muhammad Ali", "Cardilogist", "9985234567");
            dtDoctors.Rows.Add(2, "Dr Vinod Kumar", "Dentist", "8179143143");
            dtDoctors.Rows.Add(3, "Dr Peter", "psychartist", "7382053402");
            dtDoctors.Rows.Add(4, "Dr Sudheer Kumar", "Dentist", "9949445091");
            dtDoctors.Rows.Add(4, "Dr Koteswara Rao", "Cardilogist", "9849707963");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblClinicName.Text = dt.Rows[comboBox1.SelectedIndex]["CName"].ToString();
            lblClinicAddrs.Text= dt.Rows[comboBox1.SelectedIndex]["CAddress"].ToString();
            lblContact.Text = dt.Rows[comboBox1.SelectedIndex]["CContact"].ToString();
            lblRating.Text= dt.Rows[comboBox1.SelectedIndex]["CRating"].ToString();

            dtSpecificClinicDoctors = dtDoctors.Select("CID= " + dt.Rows[comboBox1.SelectedIndex]["CID"]).CopyToDataTable();
            comboBox2.DataSource = dtSpecificClinicDoctors;
            comboBox2.DisplayMember = "DName";

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblDoctorName.Text = dtSpecificClinicDoctors.Rows[comboBox2.SelectedIndex]["DName"].ToString();
            lblDoctorSpeciality.Text = dtSpecificClinicDoctors.Rows[comboBox2.SelectedIndex]["DSpecialty"].ToString();
            lblDoctorContact.Text = dtSpecificClinicDoctors.Rows[comboBox2.SelectedIndex]["DContact"].ToString();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
