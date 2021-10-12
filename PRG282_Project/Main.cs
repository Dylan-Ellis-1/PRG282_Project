﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DataLayer.DataHandler handler = new DataLayer.DataHandler();

        BindingSource sSource = new BindingSource();
        BindingSource cSource = new BindingSource();    

        private void button9_Click(object sender, EventArgs e)
        {
            Courses frm = new Courses();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            sSource.DataSource = handler.searchStudent(tbxSearch.Text);
            dgvStudent.DataSource = sSource;
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            string message = handler.deleteStudent(tbxSNumber.Text);
            MessageBox.Show(message);

            sSource.DataSource = handler.getStudent();
            dgvStudent.DataSource = sSource;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student(tbxSNumber.Text, tbxName.Text, cmbGender.Text, tbxPhone.Text, tbxAddress.Text, tbxImgPath.Text, tbxDOB.Text);
            List<string> courses = new List<string>();
            string message = "";

            if (cbxNewStudent.Checked == true)
            {
                message = handler.addStudent(student, courses);
            }
            else
            {
                message = handler.updateStudent(student, courses);
            }
            
            MessageBox.Show(message);

            sSource.DataSource = handler.getStudent();
            dgvStudent.DataSource = sSource;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sSource.DataSource = handler.getStudent();

            dgvStudent.DataSource = sSource;

            List<string> coursesList = new List<string>();

            coursesList = handler.getModCodes();

            foreach (string item in coursesList)
            {
                clbCourses.Items.Add(item);
            }

            this.dgvStudent.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvCourses.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            string course = "";
            string message = handler.deleteCourseForStudent(course ,tbxSNumber.Text);
            MessageBox.Show(message);

            cSource.DataSource = handler.populateCourse(tbxSNumber.Text);
            dgvCourses.DataSource = cSource;
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> lCourses = new List<string>();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];

                tbxSNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                tbxName.Text = row.Cells["NameSurname"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                tbxDOB.Text = row.Cells["StudentDOB"].Value.ToString();
                tbxPhone.Text = row.Cells["Phone"].Value.ToString();
                tbxAddress.Text = row.Cells["Address_"].Value.ToString();
                tbxImgPath.Text = row.Cells["ImgPath"].Value.ToString();
            }

            cSource.DataSource = handler.populateCourse(tbxSNumber.Text);
            dgvCourses.DataSource = cSource;

            //pbxStudent.Image = Image.FromFile(tbxImgPath.Text);
        }

        private void btnFirstS_Click(object sender, EventArgs e)
        {
            sSource.MoveFirst();
        }

        private void btnLastC_Click(object sender, EventArgs e)
        {
            cSource.MoveLast();
        }

        private void btnNextS_Click(object sender, EventArgs e)
        {
            sSource.MoveNext();
        }

        private void btnLastS_Click(object sender, EventArgs e)
        {
            sSource.MoveLast();
        }

        private void btnFirstC_Click(object sender, EventArgs e)
        {
            cSource.MoveFirst();
        }

        private void btnPrevC_Click(object sender, EventArgs e)
        {
            cSource.MovePrevious();
        }

        private void btnNextC_Click(object sender, EventArgs e)
        {
            cSource.MoveNext();
        }

        private void btnPrevS_Click(object sender, EventArgs e)
        {
            sSource.MovePrevious();
        }
    }
}
