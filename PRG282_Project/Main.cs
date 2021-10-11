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
                
            }
            else
            {
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[4].Value.ToString();
                tbxSNumber.Text = dgvStudent.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void cbxNewStudent_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
