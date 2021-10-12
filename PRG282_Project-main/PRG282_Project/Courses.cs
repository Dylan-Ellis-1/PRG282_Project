using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searched = tbxSearch.Text;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;
            string courseName = tbxName.Text;
            string link = tbxLink.Text;
            string description = rtbDescription.Text;

          

            if (cbxNewCourse.Checked ==true)
            {
                string cmdString = "INSERT INTO books (CourseID,CourseName,Link,CourseDescription) VALUES (@val1, @va2, @val3,@val4)";
                string connString = "your connection string";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandString = cmdString;
                        comm.Parameters.AddWithValue("@val1", tbxCourseID.Text);
                        comm.Parameters.AddWithValue("@val2", tbxName.Text);
                        comm.Parameters.AddWithValue("@val3", tbxLink.Text);
                        comm.Parameters.AddWithValue("@val4", rtbDescription.Text);

                        conn.Open();
                        comm.ExecuteNonQuery();

                    }
                }
            }
            else
            {
                MessageBox.Show("if you wish to add a new course please tick the checkbox");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cmdString = "DELETE FROM (tablename) WHERE CourseID = '"+ tbxCourseID.Text +"'";
            string connString = "your connection string";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandString = cmdString;
                    

                    conn.Open();
                    comm.ExecuteNonQuery();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //insert code to append DB
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        
    }
}
