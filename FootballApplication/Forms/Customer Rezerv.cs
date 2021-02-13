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
    public partial class Customer_Rezerv : Form
    {
        FootballAppDB db = new FootballAppDB();
        public Customer_Rezerv()
        {
            InitializeComponent();
        }

        #region Form close and minimaized
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region FiellCustomer Method
        public void FiellCustomerCombo()
        {
            cmbCustomer.Items.AddRange(db.Customers.Select(c => c.Firstname).ToArray());
        }
        #endregion

        #region FiellUser Method
        public void FiellUserCombo()
        {
            cmbUser.Items.AddRange(db.Users_.Select(u => u.Firstname).ToArray());
        }
        #endregion

        #region FiellStadium Method
        public void FiellStadiumCombo()
        {
            cmbStadium.Items.AddRange(db.Stadiums.Select(s => s.Name).ToArray());
        }
        #endregion

        #region Load
        private void Customer_Rezerv_Load(object sender, EventArgs e)
        {
            FiellCustomerCombo();
            FiellUserCombo();
            FiellStadiumCombo();
            dtRezervDate.Format = DateTimePickerFormat.Custom;
            dtRezervDate.CustomFormat = "MM/dd/yyyy HH:mm";
        }
        #endregion


    }
}
