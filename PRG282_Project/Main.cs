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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DataLayer.DataHandler handler = new DataLayer.DataHandler();
        bool NewStudent = false;
        int NRows;
        int NRowsC;

        public void FillForm()
        {
            DataTable dt = handler.getStudent();
            dgvStudent.DataSource = dt;
            //select first row
            NRows = 0;
            dgvStudent.Rows[NRows].Selected = true;

            //fill relevant textboxes and other objects
            FillSelectedForm();
        }
        public void ClearAll()
        {

            tbxSNumber.Clear();
            tbxName.Clear();
            tbxPhone.Clear();
            tbxImgPath.Clear();
            tbxAddress.Clear();

            for (int k = 0; k < clbCourses.Items.Count - 1; k++)
            {
                clbCourses.SetItemChecked(k, false);
            }
            dtpDOB.Value = DateTime.Parse("01/01/2000");
            cmbGender.SelectedIndex = -1;
        }
        public void FillSelectedForm()
        {
            //fill textboxes and, dtpDOB, combobox and picturebox
            tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
            tbxName.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
            cmbGender.SelectedItem = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
            string dateF = dgvStudent.SelectedRows[0].Cells[3].Value.ToString().Replace("-", "/");
            DateTime date = DateTime.Parse(dateF);
            dtpDOB.Value = date;
            tbxPhone.Text = dgvStudent.SelectedRows[0].Cells[5].Value.ToString();
            tbxAddress.Text = dgvStudent.SelectedRows[0].Cells[6].Value.ToString();
            tbxImgPath.Text = dgvStudent.SelectedRows[0].Cells[7].Value.ToString();
            pbxStudent.Image = Image.FromFile(tbxImgPath.Text);

            //fill Courses table by Student
            DataTable dtC = handler.populateCourse(tbxName.Text);
            dgvCourses.DataSource = dtC;

            //fill Checklistbox
            for (int k = 0; k < dgvCourses.Rows.Count - 1; k++)
            {
                for (int j = 0; k < clbCourses.Items.Count - 1; k++)
                {
                    if (clbCourses.Items[j].ToString() == dgvCourses.Rows[k].Cells[0].Value.ToString())
                    {
                        clbCourses.SetItemChecked(k, true);
                    }
                    else
                    {
                        clbCourses.SetItemChecked(k, false);
                    }
                }
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Courses frm = new Courses();

            frm.Show();
        }
        private void cbxNewStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNewStudent.Checked == true)
            {
                tbxSNumber.Clear();
                tbxName.Clear();
                tbxPhone.Clear();
                tbxImgPath.Clear();
                
                for (int k = 0; k< clbCourses.Items.Count-1; k++)
                {
                    clbCourses.SetItemChecked(k, false);
                }
                btnSave.Text = "Add Student";
            }
            else
            {
                FillSelectedForm();
                btnSave.Text = "Save Changes";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows[NRows].Selected = false;
            NRows = dgvStudent.Rows.Count - 1;
            dgvStudent.Rows[NRows].Selected = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows[NRows].Selected = false;
            NRows++;
            dgvStudent.Rows[NRows].Selected = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows[NRows].Selected = false;
            NRows = NRows -1;
            dgvStudent.Rows[NRows].Selected = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows[NRows].Selected = false;
            NRows = 0;
            dgvStudent.Rows[NRows].Selected = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            dgvCourses.Rows[NRowsC].Selected = false;
            NRowsC = dgvCourses.Rows.Count-1;
            dgvCourses.Rows[NRowsC].Selected = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            dgvCourses.Rows[NRowsC].Selected = false;
            NRowsC++;
            dgvCourses.Rows[NRowsC].Selected = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            dgvCourses.Rows[NRowsC].Selected = false;
            NRowsC= NRowsC-1;
            dgvCourses.Rows[NRowsC].Selected = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            dgvCourses.Rows[NRowsC].Selected = false;
            NRowsC= 0;
            dgvCourses.Rows[NRowsC].Selected = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = handler.searchStudent(tbxSearch.Text);
        }
        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            handler.deleteStudent(tbxSNumber.Text);
            MessageBox.Show("Student {0} has been deleted", tbxSNumber.Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> LCourses = new List<string>();
            string date = dtpDOB.Value.Day.ToString() + "-" + dtpDOB.Value.Month.ToString() + "-" + dtpDOB.Value.Year.ToString();

            for (int k = 0; k < clbCourses.Items.Count; k++)
            {
                if (clbCourses.GetItemChecked(k) == true)
                {
                    LCourses.Add(clbCourses.Items[k].ToString());
                }
            }
            if (NewStudent == false)
            {
                handler.updateStudent(new Student(tbxSNumber.Text, tbxName.Text, cmbGender.SelectedItem.ToString(), tbxPhone.Text, tbxAddress.Text, tbxImgPath.Text, date), LCourses);
            }
            else
            if (NewStudent == true)
            {
                handler.addStudent(new Student(tbxSNumber.Text, tbxName.Text, cmbGender.SelectedItem.ToString(), tbxPhone.Text, tbxAddress.Text, tbxImgPath.Text, date),LCourses);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dtpDOB.CustomFormat = "dd mm yyyy";
            List<string> CourseL = new List<string>();
            CourseL = handler.GetModCodes();
            for (int k = 0; k < CourseL.Count; k++)
            {
                clbCourses.Items.Add(CourseL[k].ToString());
            }
            FillForm();

        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            NRows = dgvCourses.SelectedRows[0].Index;
            FillSelectedForm();
        }
    }
}
