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

        BindingSource source = new BindingSource();
        BindingSource sourceC = new BindingSource();
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
    }
}
