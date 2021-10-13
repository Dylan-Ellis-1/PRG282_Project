using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PRG282_Project.BussinessLogicLayer;
using PRG282_Project.DataLayer;


namespace PRG282_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        FileHandler fileHandler = new FileHandler();
        DataHandler handler = new DataLayer.DataHandler();
        BLL logic = new BLL();

        BindingSource sSource = new BindingSource();
        BindingSource cSource = new BindingSource();

        string deleteCourse;

        // Method to clear the componets used to get user input
        public void clearComponents()
        {
            tbxSNumber.Clear();
            tbxPhone.Clear();
            tbxName.Clear();
            tbxImgPath.Clear();
            tbxAddress.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Parse("01/01/2000");
            foreach (int i in clbCourses.CheckedIndices)
            {
                clbCourses.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // Method to fill the input fields with the data from the DataGridView
        public void fillComponents()
        {
            if (sSource.Position >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[sSource.Position];

                tbxSNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                tbxName.Text = row.Cells["NameSurname"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                string date = row.Cells["StudentDOB"].Value.ToString();
                string[] splits = date.Split('-');
                dtpDOB.Value = DateTime.Parse(splits[1] + "/" + splits[0] + "/" + splits[2]);
                tbxPhone.Text = row.Cells["Phone"].Value.ToString();
                tbxAddress.Text = row.Cells["Address_"].Value.ToString();
                tbxImgPath.Text = row.Cells["ImgPath"].Value.ToString();

                pbxStudent.Image = Image.FromFile(@"Images\" + tbxImgPath.Text);
            }

            fillCheckedListBox();
        }

        // Method to fill the CheckedListBox with the data from the DataGridView
        public void fillCheckedListBox()
        {
            cSource.DataSource = handler.populateCourse(tbxSNumber.Text);
            dgvCourses.DataSource = cSource;

            List<string> lCourses = new List<string>();

            foreach (int i in clbCourses.CheckedIndices)
            {
                clbCourses.SetItemCheckState(i, CheckState.Unchecked);
            }

            if (dgvCourses.Rows.Count > 0)
            {
                for (int i = 0; i < dgvCourses.Rows.Count - 1; i++)
                {
                    lCourses.Add(dgvCourses.Rows[i].Cells[0].Value.ToString());
                }
            }

            for (int count = 0; count < clbCourses.Items.Count; count++)
            {
                if (lCourses.Contains(clbCourses.Items[count].ToString()))
                {
                    clbCourses.SetItemChecked(count, true);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Courses frm = new Courses();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Searching for a Student
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (logic.searchValidation(tbxSearch.Text) == true)
            {
                sSource.DataSource = handler.searchStudent(tbxSearch.Text);
                dgvStudent.DataSource = sSource;
            }
            else
            {
                MessageBox.Show("Make sure you enter a value in the search field.");
            }
            
        }

        // Deleteing a Student 
        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            string message = handler.deleteStudent(tbxSNumber.Text);
            MessageBox.Show(message);

            sSource.DataSource = handler.getStudent();
            dgvStudent.DataSource = sSource;
        }

        // Adding/Updating a new Student
        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = dtpDOB.Value.ToShortDateString();
            string[] dateS = date.Split('/');
            date = dateS[1]+"-" + dateS[0]+"-" + dateS[2];

            string filePath;

            if (File.Exists(tbxImgPath.Text) == false)
            {
                MessageBox.Show(@"Image was not found. Make sure the File path provided is correct");
                filePath = "default.png";
            }
            else
            {
                filePath = fileHandler.AddPicture(tbxImgPath.Text);
            }

            List<string> courses = new List<string>();

            foreach (var course in clbCourses.CheckedItems)
            {
                courses.Add(course.ToString());
            }

            if (logic.studentDataValidation(tbxSNumber.Text, tbxName.Text, filePath, date, cmbGender.Text, tbxPhone.Text, tbxAddress.Text, courses))
            {
                Student student = new Student(tbxSNumber.Text, tbxName.Text, cmbGender.Text, tbxPhone.Text, tbxAddress.Text, filePath, date);

                string message = "";

                if (cbxNewStudent.Checked == true)
                {
                    message = handler.addStudent(student, courses);
                    cbxNewStudent.Checked = false;
                }
                else
                {
                    message = handler.updateStudent(student, courses);
                }

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Make sure you enter values in all the field.");
            }

            sSource.DataSource = handler.getStudent();
            dgvStudent.DataSource = sSource;
            cSource.DataSource = handler.populateCourse(tbxSNumber.Text);
            dgvCourses.DataSource = cSource;
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

            fillCheckedListBox();

            this.dgvStudent.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvCourses.DefaultCellStyle.ForeColor = Color.Black;
        }

        // Deleting a Course for a Student
        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            List<string> lCourses = new List<string>();

            string message = handler.deleteCourseForStudent(deleteCourse, tbxSNumber.Text);
            MessageBox.Show(message);

            fillCheckedListBox();
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

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCourses.Rows[e.RowIndex];

                deleteCourse = row.Cells["ModCode"].Value.ToString();
            }
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            fillComponents();
        }

        private void cbxNewStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNewStudent.Checked == true)
            {
                clearComponents();
            }

            if (cbxNewStudent.Checked == false)
            {
                fillComponents();
            }
        }
    }
}
