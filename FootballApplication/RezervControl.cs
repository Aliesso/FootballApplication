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
    public partial class RezervControl : UserControl
    {
       
       
        FootballAppDB db = new FootballAppDB();
        public RezervControl()
        {
            InitializeComponent();
        }
       

        #region FiellCustomer Method
        public void FiellCustomerCombo()
        {
            cmbCustomer.Items.AddRange(db.Customers.Select(c => c.Firstname).ToArray());
            cmbSurname.Items.AddRange(db.Customers.Select(c => c.Surname).ToArray());
            cmbCustomPhone.Items.AddRange(db.Customers.Select(c => c.Phone).ToArray());
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

        #region FiellRoomNumber Method
        public void FiellRoomNumberCombo()
        {
            cmbRoomNumber.Items.AddRange(db.ChangingRooms.Select(r => r.Number).ToArray());
        }
        #endregion

        #region FiellRoomCapacity Method
        public void FiellCapacityCombo()
        {
            cmbCapacity.Items.AddRange(db.ChangingRooms.Select(r => r.Capacity).ToArray());
        }
        #endregion

        #region Rezervation Load
        private void RezervControl_Load(object sender, EventArgs e)
        {    
            dtRezervDate.Format = DateTimePickerFormat.Custom;
            dtRezervDate.CustomFormat = " HH:mm";
        }



        #endregion

        #region ClearData
        private void ClearFormData()
        {
            foreach (var item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.Text = "";
                }
                else if(item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
                else if(item is NumericUpDown)
                {
                    NumericUpDown nm = (NumericUpDown)item;
                    nm.Value = 1;
                }
            }
        }
        #endregion

        #region FindCustomer
        public int FindCustomer(string customername,string customersurname,string phone)
        {
            Customers selectedCustomername = db.Customers.FirstOrDefault(cus => cus.Firstname == customername);
            Customers selectedCustomersurname = db.Customers.FirstOrDefault(cus => cus.Surname == customersurname);
            Customers selectedCustomerphone = db.Customers.FirstOrDefault(cus => cus.Phone == phone);
            if (selectedCustomername==null)
            {
                Customers Customer = db.Customers.Add(new Customers
                {
                    Firstname = customername,
                    Surname=customersurname,
                    Phone=phone
                });
                db.SaveChanges();
                return Customer.C_ID;
            }
            return selectedCustomername.C_ID;
            return selectedCustomersurname.C_ID;
            return selectedCustomerphone.C_ID;
        }
        #endregion

        #region Rezervation Button

        private void Rezervbtn_Click(object sender, EventArgs e)
        {
            cmbCustomer.Items.AddRange(db.Customers.Select(c => c.Firstname).ToArray());
            string cusname = cmbCustomer.Text;
            string cussurname = cmbSurname.Text;
            string cusphone = cmbCustomPhone.Text;
            string usname = cmbUser.Text;
            string stadium = cmbStadium.Text;
            DateTime rDate = dtRezervDate.Value;
            decimal price = nmPrice.Value;
            string[] ar = { cusname, cussurname, cusphone, usname, stadium };
            if (Utilities.isEmpty(ar))
            {
                lblError.Visible = false;
                int customID = FindCustomer(cusname,cussurname,cusphone);
                Rezervations rez = db.Rezervations.Add(new Rezervations
                {
                  CostumerID=customID,
                  UserID=selectedUser.U_ID,
                  StadiumID=selectedStadium.S_ID,
                  RezervDate=rDate,
                  Price=price
                });
                db.SaveChanges();
                MessageBox.Show("Recerved successfully!");
                ClearFormData();
               
                RoomPanel.Visible = true;
            }
            else
            {
                lblError.Text = "Please,all the fiel!";
                lblError.Visible=true;
            }
         
        }
        #endregion

        #region Index Changed
        Stadiums selectedStadium;
        Users_ selectedUser;
        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stname = cmbStadium.Text;
            selectedStadium = db.Stadiums.FirstOrDefault(s => s.Name==stname);
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usname = cmbUser.Text;
            selectedUser = db.Users_.FirstOrDefault(u => u.Firstname == usname);
        }
        #endregion

        #region Rezerv Room Button
        private void RezervRoombtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        
    }
}
