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
    public partial class RoomAddControl : UserControl
    {
        FootballAppDB db = new FootballAppDB();
        public RoomAddControl()
        {
            InitializeComponent();
        }
        #region Room Button
        private void Roombtn_Click(object sender, EventArgs e)
        {
            string rmnumber = txtRoomNumber.Text;
            string rmcapacity = txtRoomCapacity.Text;
            string[] myArr = new string[] { rmnumber, rmcapacity };
            if (Utilities.isEmpty(myArr))
            {
                ChangingRooms selectedRooms = db.ChangingRooms.FirstOrDefault(c => c.Number == rmnumber);
                if (selectedRooms == null)
                {
                    ChangingRooms rooms = new ChangingRooms();
                    rooms.Number = rmnumber;
                    rooms.Capacity = rmcapacity;
                    db.ChangingRooms.Add(rooms);
                    db.SaveChanges();
                    MessageBox.Show("Room created successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblError.Text = "Room number already exist!";
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

        #region Room Keypress
        private void txtRoomCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 || txtRoomCapacity.Text.Length > 1) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
