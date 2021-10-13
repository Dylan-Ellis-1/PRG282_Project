using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.DataLayer;

namespace PRG282_Project
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();
        BindingSource Source = new BindingSource();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searched = tbxSearch.Text;

            Source.DataSource = handler.searchCourse(searched);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;

            string message = handler.deleteCourse(courseId);
            MessageBox.Show(message);

            Source.DataSource = handler.getCourse();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;
            string courseName = tbxName.Text;
            string link = tbxLink.Text;
            string description = rtbDescription.Text;

            Course course = new Course(courseId, courseName, description, link);

            string message = handler.updateCourse(course);
            MessageBox.Show(message);

            Source.DataSource = handler.getCourse();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;
            string courseName = tbxName.Text;
            string link = tbxLink.Text;
            string description = rtbDescription.Text;

            Course course = new Course(courseId, courseName, description, link);

            string message = handler.addCourse(course);
            MessageBox.Show(message);

            Source.DataSource = handler.getCourse();

            cbxNewCourse.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            this.dgvCourses.DefaultCellStyle.ForeColor = Color.Black;
            Source.DataSource = handler.getCourse();
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Source.Position >= 0)
            {
                DataGridViewRow row = this.dgvCourses.Rows[Source.Position];

                tbxCourseID.Text = row.Cells["ModCode"].Value.ToString();
                tbxName.Text = row.Cells["ModName"].Value.ToString();
                tbxLink.Text = row.Cells["Link"].Value.ToString();
                rtbDescription.Text = row.Cells["ModDesc"].Value.ToString();
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(tbxLink.Text);
        }

        private void cbxNewCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNewCourse.Checked)
            {
                tbxCourseID.Clear();
                tbxLink.Clear();
                tbxName.Clear();
                rtbDescription.Clear();
                btnAddNewUser.Enabled = true;
                btnAddNewUser.Visible = true;
            }
            else
            {
                btnAddNewUser.Enabled = false;
                btnAddNewUser.Visible = false;
                if (Source.Position >= 0)
                {
                    DataGridViewRow row = this.dgvCourses.Rows[Source.Position];

                    tbxCourseID.Text = row.Cells["ModCode"].Value.ToString();
                    tbxName.Text = row.Cells["ModName"].Value.ToString();
                    tbxLink.Text = row.Cells["Link"].Value.ToString();
                    rtbDescription.Text = row.Cells["ModDesc"].Value.ToString();
                }

            }
        }
    }
}
