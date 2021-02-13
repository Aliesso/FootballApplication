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
    public partial class AdminForm : Form
    {
        private Users_ activeUser_;
        FootballAppDB db = new FootballAppDB();
        public AdminForm(Users_ user)
        {
            activeUser_ = user;
            InitializeComponent();
        }

        #region Form minimaized and maximaized
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Sign Out
        private void lblOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ds = new LogInForm();
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }
        #endregion

        #region Add Worker label
        private void lblAddWorker_Click(object sender, EventArgs e)
        {
            workerAddControl1.Visible = true;
            stadiumAddControl1.Visible = false;
            roomAddControl1.Visible = false;
            Boolpb.Visible = true;
            pbbool.Visible = false;
            pbbool2.Visible = false;
        }
        #endregion

        #region Stadium label
        private void lblStadium_Click(object sender, EventArgs e)
        {
            stadiumAddControl1.Visible = true;
            workerAddControl1.Visible = false;
            roomAddControl1.Visible = false;
            Boolpb.Visible = false;
            pbbool.Visible = true;
            pbbool2.Visible = false;
        }
        #endregion

        #region Room label
        private void lblRooms_Click(object sender, EventArgs e)
        {
            roomAddControl1.Visible = true;
            workerAddControl1.Visible = false;
            stadiumAddControl1.Visible = false;
            Boolpb.Visible = false;
            pbbool.Visible = false;
            pbbool2.Visible = true;
        }
        #endregion

        #region Welcome Message
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblWelcome.Text = "Welcome:   " + activeUser_.Firstname + "!";
        }
        #endregion
    }
}
