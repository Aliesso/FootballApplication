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
    public partial class StadiumAddControl : UserControl
    {
        FootballAppDB db = new FootballAppDB();
        public StadiumAddControl()
        {
            InitializeComponent();
        }

        #region Stadium Button
        private void Stadiumbtn_Click(object sender, EventArgs e)
        {
            string stname = txtStName.Text;
            string stnumber = txtStNumber.Text;
            string[] myArr = new string[] { stname, stnumber };
            if (Utilities.isEmpty(myArr))
            {
                Stadiums selectedStadium = db.Stadiums.FirstOrDefault(c => c.Name == stname);
                if (selectedStadium == null)
                {
                    Stadiums stadium = new Stadiums();
                    stadium.Name = stname;
                    stadium.Number = stnumber;
                    db.Stadiums.Add(stadium);
                    db.SaveChanges();
                    MessageBox.Show("Stadium created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblError.Text = "Stadium name already exist!";
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

        #region Stadium Keypress
        private void txtStNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 || txtStNumber.Text.Length > 11) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
