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
        BindingSource source = new BindingSource();
        BindingSource sourceC = new BindingSource();
        bool NewStudent = false;
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
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[4].Value.ToString();
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            source.MovePrevious();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            sourceC.MoveLast();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            sourceC.MoveNext();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            sourceC.MovePrevious();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            sourceC.MoveLast();
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
                handler.addStudent(new Student(tbxSNumber.Text, tbxName.Text, cmbGender.SelectedItem.ToString(), tbxPhone.Text, tbxAddress.Text, tbxImgPath.Text, date), LCourses);
            }
        }
    }
}
