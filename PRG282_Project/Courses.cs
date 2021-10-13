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
using PRG282_Project.BussinessLogicLayer;

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
        BLL logic = new BLL();

        // Method to fill the input fields with the data from the DataGridView
        public void fillComponents()
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

        // Method to clear the componets used to get user input
        public void clearComponents()
        {
            tbxCourseID.Clear();
            tbxLink.Clear();
            tbxName.Clear();
            rtbDescription.Clear();
            btnAddNewUser.Enabled = true;
            btnAddNewUser.Visible = true;
        }

        // Method used to populate the DataGridView
        public void populateDgv()
        {
            Source.DataSource = handler.getCourse();
            dgvCourses.DataSource = Source;
        }

        // Searching for a Course
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searched = tbxSearch.Text;

            if (logic.searchValidation(searched) == true)
            {
                Source.DataSource = handler.searchCourse(searched);
                dgvCourses.DataSource = Source;
                fillComponents();
            }
            else
            {
                MessageBox.Show("Make sure you enter a value in the search field.");
            }
        }

        // Deleting a Course
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;

            string message = handler.deleteCourse(courseId);
            MessageBox.Show(message);

            dgvCourses.CurrentCell = this.dgvCourses.FirstDisplayedCell;

            populateDgv();


        }

        // Updating a Course
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;
            string courseName = tbxName.Text;
            string link = tbxLink.Text;
            string description = rtbDescription.Text;

            if (logic.courseDataValidation(courseId, courseName, link, description) == true)
            {
                Course course = new Course(courseId, courseName, description, link);

                string message = handler.updateCourse(course);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Make sure you enter values in all the fields.");
            }

            dgvCourses.CurrentCell = this.dgvCourses.FirstDisplayedCell;

            populateDgv();
        }

        // Adding a new Course
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            string courseId = tbxCourseID.Text;
            string courseName = tbxName.Text;
            string link = tbxLink.Text;
            string description = rtbDescription.Text;

            if (logic.courseDataValidation(courseId, courseName, link, description)== true)
            {
                Course course = new Course(courseId, courseName, description, link);

                string message = handler.addCourse(course);
                MessageBox.Show(message);

                dgvCourses.CurrentCell = this.dgvCourses.FirstDisplayedCell;
                populateDgv();
                fillComponents();

                cbxNewCourse.Checked = false;
            }
            else
            {
                MessageBox.Show("Make sure you enter values in all the fields.");
            }   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            this.dgvCourses.DefaultCellStyle.ForeColor = Color.Black;
            populateDgv();

            fillComponents();
        }

        //Displaying the websit for the link provided
        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(tbxLink.Text);
        }

        private void cbxNewCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNewCourse.Checked)
            {
                clearComponents();
            }
            else
            {
                fillComponents();
            }
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            fillComponents();
        }
    }
}
