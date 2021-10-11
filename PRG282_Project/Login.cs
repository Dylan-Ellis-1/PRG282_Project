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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool NewUser = false;
        FileHandler handler = new FileHandler();

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxNUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNUser.Checked == true)
            {
                tbxConPassword.Enabled = true;
                tbxConPassword.Visible = true;
                lblConPass.Visible = true;

                btnLogIn.Text = "Create User and Log In";
                NewUser = true;
            }
            else
            if (cbxNUser.Checked == false)
            {
                tbxConPassword.Enabled = false;
                tbxConPassword.Visible = false;
                lblConPass.Visible = false;

                btnLogIn.Text = "Log In";
                NewUser = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();

            frmMain.Show();

            string NameEn = tbxUsername.Text;
            string PassEn = tbxPassword.Text;
            string PassConEn = tbxConPassword.Text;

            if (NewUser == true)
            {
                int Num = handler.AddUser(NameEn, PassEn, PassConEn);
                switch(Num)
                {
                    case 1:
                        {
                            lblOutput.Text = "Forbidden Characters were used, choose another username without space or a comma.";
                            tbxUsername.Focus();
                            break;
                        };
                    case 2:
                        {
                            lblOutput.Text = "Forbidden Characters were used, choose another password without space or a comma.";
                            tbxPassword.Focus();
                            break;
                        };
                    case 3:
                        {
                            lblOutput.Text = "Passwords do not match";
                            tbxConPassword.Focus();
                            break;
                        }
                    case 4:
                        {
                            lblOutput.Text = "User Already Excists, Pick a new Username.";
                            tbxUsername.Focus();
                            break;
                        }
                    case 0:
                        {
                            tbxUsername.Text = NameEn;
                            tbxPassword.Text = PassEn;
                            NewUser = false;
                            cbxNUser.Checked = false;
                            break;
                        }

                }

            }
            else
            if (NewUser == false)
            {
                int Num = handler.LoginF(NameEn, PassEn);
                switch(Num)
                {
                    case 1:
                        {
                            lblOutput.Text = "User not found, consider making a new account";
                            cbxNUser.Focus();
                            break;
                        }
                    case 2:
                        {
                            lblOutput.Text = "Wrong password was given for the username.";
                            tbxPassword.Focus();
                            break;
                        }
                    case 0:
                        {
                            Main form = new Main();
                            form.Show();
                            break;
                        }

                }
            }
        }
    }
}
