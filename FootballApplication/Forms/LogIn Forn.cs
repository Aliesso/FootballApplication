
using FootballApplication.Forms;
using FootballApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApplication
{
    public partial class LogInForm : Form
    {
        FootballAppDB db = new FootballAppDB();
        public LogInForm()
        {
            InitializeComponent();
        }

        #region close and minimazed Form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Register Form show
       

        #endregion

        #region Login Button
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string fname = txtFirstname.Text;
            string suname = txtSurname.Text;
            string pass = txtPassword.Text;
            if (Utilities.isEmpty(new string[] {fname,suname,pass}))
            {
                Users_ selectedUser = db.Users_.FirstOrDefault(c => c.Firstname == fname);          
                if (selectedUser != null)
                {
                    if (selectedUser.Password==pass.HashMe())
                    {
                        if (ckRemember.Checked)
                        {
                            Properties.Settings.Default.firstname = fname;
                            Properties.Settings.Default.surname = suname;
                            Properties.Settings.Default.password = pass;
                            Properties.Settings.Default.isChecked = true;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.firstname = "";
                            Properties.Settings.Default.surname = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.isChecked = false;
                            Properties.Settings.Default.Save();
                        }
                        if (selectedUser.RoleID==1)
                        {
                            this.Hide();
                            var ds = new  Rezervation_Form(selectedUser);
                            ds.FormClosed += (s, args) => this.Close();
                            ds.ShowDialog();
                        }
                        if (selectedUser.RoleID==2)
                        {
                            this.Hide();
                            var ds = new AdminForm(selectedUser);
                            ds.FormClosed += (s, args) => this.Close();
                            ds.ShowDialog();
                        }
                    }
                    else
                    {
                        lblError.Text = "password doesn't correct!";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "username doesn't correct";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please,all the fiel";
                lblError.Visible = true;
            }
        }
        #endregion

        #region checked Load
        private void LogInForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isChecked)
            {
                txtFirstname.Text = Properties.Settings.Default.firstname;
                txtSurname.Text = Properties.Settings.Default.surname;
                txtPassword.Text = Properties.Settings.Default.password;
            }
        }
        #endregion
    }
}
