using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class Form1 : Form
    {
        private DataTable dtCourses = new DataTable();
        private DataTable dtSelectedCourses = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCoursesTable();
            SelectedCoursesTable();

            listBox1.DataSource = dtCourses;
            listBox1.DisplayMember = "CourseName";
             
            listBox2.DataSource = dtSelectedCourses;
            listBox2.DisplayMember = "CourseName";


        }
        private void FillCoursesTable()
        {
            dtCourses.Columns.Add("CourseId", typeof(int));
            dtCourses.Columns.Add("CourseName");
            dtCourses.Columns.Add("CourseDuration");

            dtCourses.Rows.Add(1, "Oops", "4 Months");
            dtCourses.Rows.Add(2, "C++", "5 Months");
            dtCourses.Rows.Add(3, "Sql", "3 Months");
            dtCourses.Rows.Add(4, "Angular", "2 Months");
            dtCourses.Rows.Add(1, "Andriod", "4 Months");


        }
        private void SelectedCoursesTable()
        {
            dtSelectedCourses.Columns.Add("CourseId", typeof(int));
            dtSelectedCourses.Columns.Add("CourseName");
            dtSelectedCourses.Columns.Add("CourseDuration");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                dtCourses.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int count = dtCourses.Rows.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                    dtCourses.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

            if (listBox2.Items.Count > 0)
            {
                int count = dtSelectedCourses.Rows.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                    dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }

        private void btnFinilize_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to finilize the courses", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if(dr==DialogResult.Yes)
            {
                dataGridView1.DataSource = dtSelectedCourses;
                dataGridView1.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.Columns[1].Width = 350;
                dataGridView1.Columns[2].Width = 500;


            }
              else
            {
                MessageBox.Show("Please select atleast one course", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
