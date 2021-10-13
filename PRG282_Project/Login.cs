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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        FileHandler file = new FileHandler();
        BLL logicLayer = new BLL();
        

        private void cbxNUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNUser.Checked == true)
            {
                tbxConPassword.Enabled = true;
                tbxConPassword.Visible = true;
                lblConPass.Visible = true;

                btnLogIn.Text = "Create User and Log In";
            }
            else
            if (cbxNUser.Checked == false)
            {
                tbxConPassword.Enabled = false;
                tbxConPassword.Visible = false;
                lblConPass.Visible = false;

                btnLogIn.Text = "Log In";
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (cbxNUser.Checked == true)
            {
                int number;

                if (logicLayer.newUserValidation(tbxUsername.Text, tbxPassword.Text, tbxConPassword.Text) == true)
                {
                     number = file.AddUser(tbxUsername.Text, tbxPassword.Text, tbxConPassword.Text);
                }
                else
                {
                    number = 10;
                }
                
                switch(number)
                {
                    case 1:
                        MessageBox.Show("Please ensure the Username does not contain a space or comma.");
                        tbxUsername.Focus();
                        break;
                        
                    case 2:
                        MessageBox.Show("Please ensure the Password does not contain a space or comma.");
                        tbxPassword.Focus();
                        break;
                        
                    case 3:
                        MessageBox.Show("Passwords do not match");
                        tbxConPassword.Focus();
                        break;
                        
                    case 4:
                        MessageBox.Show("User Already Excists, Pick a new Username.");
                        tbxUsername.Focus();
                        break;
                        
                    case 0:
                        MessageBox.Show("User added.");

                        if (file.CheckUser(tbxUsername.Text, tbxPassword.Text) == true)
                        {
                            Main frmMain = new Main();

                            frmMain.Show();
                        }
                        else
                        {
                            MessageBox.Show("User not found.\nMake sure Username and Password is correct or create a new User.");
                        }
                        break;

                    case 10:
                        MessageBox.Show("Make sure you enter values in all the fields.");
                        break;
                }
            }
            else
            {
                if (logicLayer.LogInValidation(tbxUsername.Text, tbxPassword.Text) == true)
                {
                    if (file.CheckUser(tbxUsername.Text, tbxPassword.Text) == true)
                    {
                        Main frmMain = new Main();

                        frmMain.Show();  
                    }
                    else
                    {
                        MessageBox.Show("User not found.\nMake sure Username and Password is correct or create a new User.");
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you enter values in all the fields.");
                }
            }
        }
    }
}
