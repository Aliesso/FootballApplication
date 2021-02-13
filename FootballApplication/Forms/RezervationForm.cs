
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
    public partial class Rezervation_Form : Form
    {
        private Users_ activeUser_;
        FootballAppDB db = new FootballAppDB();
        public Rezervation_Form(Users_ user)
        {
            activeUser_ = user;
            InitializeComponent();
        }



        #region Form close and minimazed
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region welcome User
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblWelcome.Text = "Welcome:   " + activeUser_.Firstname + "!";
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

        #region Customer Rezerv
        private void label1_Click(object sender, EventArgs e)
        {

            rezervControl1.Visible = true;
            dtgRezervation.Visible = false;
            Boolpb.Visible = false;
            pbbool.Visible = true;
        }
        #endregion

        #region Home
        private void lblHome_Click(object sender, EventArgs e)
        {
            rezervControl1.Visible = false;
            dtgRezervation.Visible = true;
            Boolpb.Visible = true;
            pbbool.Visible = false;
        }

        #endregion

        #region FielRezervationDataGrid
        public void FiellRezervationDataGrid()
        {
            dtgRezervation.DataSource = db.Rezervations.Select(rez => new
            {
                Customer_Name=rez.Customers.Firstname,
                Customer_Surname=rez.Customers.Surname,
                Cusotem_Phone=rez.Customers.Phone,
                User_Name=rez.Users_.Firstname,
                Stadium_Name=rez.Stadiums.Name,
                rez.RezervDate,
                rez.Price
                
            }).ToList();
            for (int i = 0; i < dtgRezervation.RowCount; i++)
            {
                if (dtgRezervation.Rows[i].Index %2==0)
                {
                    dtgRezervation.Rows[i].DefaultCellStyle.BackColor = Color.ForestGreen;
                    dtgRezervation.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        #endregion

        #region Rezervation Load
        private void Rezervation_Form_Load(object sender, EventArgs e)
        {
            rezervControl1.FiellCustomerCombo();
            rezervControl1.FiellUserCombo();
            rezervControl1.FiellStadiumCombo();
            rezervControl1.FiellRoomNumberCombo();
            rezervControl1.FiellCapacityCombo();
            FiellRezervationDataGrid();
        }
        #endregion


    }
}
