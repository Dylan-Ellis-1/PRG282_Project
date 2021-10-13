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

        string deleteCourse;

        public void fillComponents()
        {
            List<string> lCourses = new List<string>();

            if (sSource.Position >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[sSource.Position];

                tbxSNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                tbxName.Text = row.Cells["NameSurname"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                string date = row.Cells["StudentDOB"].Value.ToString();
                string[] splits = date.Split('-');
                //MessageBox.Show(splits[1] + "/" + splits[0] + "/" + splits[2]);
                dtpDOB.Value = DateTime.Parse(splits[1] + "/" + splits[0] + "/" + splits[2]);
                tbxPhone.Text = row.Cells["Phone"].Value.ToString();
                tbxAddress.Text = row.Cells["Address_"].Value.ToString();
                tbxImgPath.Text = row.Cells["ImgPath"].Value.ToString();

                pbxStudent.Image = Image.FromFile(@"Images\" + tbxImgPath.Text);
            }

            cSource.DataSource = handler.populateCourse(tbxSNumber.Text);
            dgvCourses.DataSource = cSource;

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
            string date = dtpDOB.Value.ToShortDateString();
            string[] dateS = date.Split('/');
            date = dateS[1]+"-" + dateS[0]+"-" + dateS[2];

            string filePath = tbxImgPath.Text;

            if (File.Exists(@"Images\" + filePath) == false)
            {
                MessageBox.Show(@"Image was not found. Make sure the student image is plased in the bin folder of the project in Debug\Images");
                filePath = "default.png";
            }

            Student student = new Student(tbxSNumber.Text, tbxName.Text, cmbGender.Text, tbxPhone.Text, tbxAddress.Text, filePath, date);
            List<string> courses = new List<string>();

            foreach (var course in clbCourses.CheckedItems)
            {
                courses.Add(course.ToString());
            }

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

            this.dgvStudent.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvCourses.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            List<string> lCourses = new List<string>();

            string message = handler.deleteCourseForStudent(deleteCourse, tbxSNumber.Text);
            MessageBox.Show(message);

            cSource.DataSource = handler.populateCourse(tbxSNumber.Text);
            dgvCourses.DataSource = cSource;

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
                tbxSNumber.Clear();
                tbxPhone.Clear();
                tbxName.Clear();
                tbxImgPath.Clear();
                tbxAddress.Clear();
                cmbGender.SelectedIndex = -1;
                dtpDOB.Value = DateTime.Parse("01/01/2000");
            }
            if (cbxNewStudent.Checked == false)
            {
                if (sSource.Position>=0)
                {
                    DataGridViewRow row = this.dgvStudent.Rows[sSource.Position];

                    tbxSNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                    tbxName.Text = row.Cells["NameSurname"].Value.ToString();
                    cmbGender.Text = row.Cells["Gender"].Value.ToString();
                    string date = row.Cells["DOB"].Value.ToString();
                    string[] splits = date.Split('-');

                    dtpDOB.Value = DateTime.Parse(splits[1] + "/" + splits[0] + "/" + splits[2]);
                    tbxPhone.Text = row.Cells["Phone"].Value.ToString();
                    tbxAddress.Text = row.Cells["Address_"].Value.ToString();
                    tbxImgPath.Text = row.Cells["ImgPath"].Value.ToString(); 
                } 
            }
        }
    }
}
