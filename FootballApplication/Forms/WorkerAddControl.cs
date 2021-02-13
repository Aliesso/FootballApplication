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

namespace FootballApplication.Forms
{
    public partial class WorkerAddControl : UserControl
    {
        FootballAppDB db = new FootballAppDB();
        public WorkerAddControl()
        {
            InitializeComponent();
        }

        #region Add Worker Button
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string fname = txtFirstname.Text;
            string suname = txtSurname.Text;
            string phone = txtPhone.Text;
            string pass = txtPassword.Text;
            string confirmPass = txtConPass.Text;
            string[] myArr = new string[] { fname, suname, phone, pass, confirmPass };
            if (Utilities.isEmpty(myArr))
            {
                if (pass == confirmPass)
                {
                    Users_ selectedUser = db.Users_.FirstOrDefault(u => u.Firstname == fname);
                    if (selectedUser == null)
                    {
                        int roleid = db.Roles.FirstOrDefault(x => x.Name == "User").ID;
                        Users_ user = new Users_();
                        user.Firstname = fname;
                        user.Surname = suname;
                        user.Phone = phone;
                        user.Password = pass.HashMe();
                        user.RoleID = roleid;
                        db.Users_.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("User created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lblError.Text = "Firstname already exist!";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "password and confirm is not the same";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please,all the fiel!";
                lblError.Visible = true;
            }
        }
        #endregion

        #region Add Worker KeyPress      
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 || txtPhone.Text.Length >20) && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFirstname.TextLength > 15 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSurname.TextLength > 15 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.TextLength > 11 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
    #endregion
    }

