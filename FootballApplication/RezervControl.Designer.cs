
namespace FootballApplication
{
    partial class RezervControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervControl));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomPhone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSurname = new System.Windows.Forms.ComboBox();
            this.Rezervbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtRezervDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStadium = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.RezervRoombtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCapacity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1268, 494);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(217, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Customer Phone";
            // 
            // cmbCustomPhone
            // 
            this.cmbCustomPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomPhone.FormattingEnabled = true;
            this.cmbCustomPhone.Location = new System.Drawing.Point(431, 135);
            this.cmbCustomPhone.Name = "cmbCustomPhone";
            this.cmbCustomPhone.Size = new System.Drawing.Size(190, 26);
            this.cmbCustomPhone.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(217, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "Customer Surname";
            // 
            // cmbSurname
            // 
            this.cmbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSurname.FormattingEnabled = true;
            this.cmbSurname.Location = new System.Drawing.Point(431, 86);
            this.cmbSurname.Name = "cmbSurname";
            this.cmbSurname.Size = new System.Drawing.Size(190, 26);
            this.cmbSurname.TabIndex = 65;
            // 
            // Rezervbtn
            // 
            this.Rezervbtn.BackColor = System.Drawing.Color.Green;
            this.Rezervbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rezervbtn.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezervbtn.ForeColor = System.Drawing.Color.Transparent;
            this.Rezervbtn.Location = new System.Drawing.Point(725, 173);
            this.Rezervbtn.Name = "Rezervbtn";
            this.Rezervbtn.Size = new System.Drawing.Size(140, 49);
            this.Rezervbtn.TabIndex = 64;
            this.Rezervbtn.Text = "Rezerv";
            this.Rezervbtn.UseVisualStyleBackColor = false;
            this.Rezervbtn.Click += new System.EventHandler(this.Rezervbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(721, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 63;
            this.label5.Text = "Price";
            // 
            // nmPrice
            // 
            this.nmPrice.DecimalPlaces = 2;
            this.nmPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPrice.Location = new System.Drawing.Point(935, 139);
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(190, 22);
            this.nmPrice.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(721, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 61;
            this.label4.Text = "Rezerv Date";
            // 
            // dtRezervDate
            // 
            this.dtRezervDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRezervDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRezervDate.Location = new System.Drawing.Point(935, 90);
            this.dtRezervDate.Name = "dtRezervDate";
            this.dtRezervDate.Size = new System.Drawing.Size(190, 22);
            this.dtRezervDate.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(721, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Stadium";
            // 
            // cmbStadium
            // 
            this.cmbStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStadium.FormattingEnabled = true;
            this.cmbStadium.Location = new System.Drawing.Point(935, 31);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(190, 26);
            this.cmbStadium.TabIndex = 58;
            this.cmbStadium.SelectedIndexChanged += new System.EventHandler(this.cmbStadium_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(217, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "User Name";
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(431, 185);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(190, 26);
            this.cmbUser.TabIndex = 56;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(217, 33);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(140, 22);
            this.lbl2.TabIndex = 55;
            this.lbl2.Text = "Customer Name";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(431, 32);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(190, 26);
            this.cmbCustomer.TabIndex = 54;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Crimson;
            this.lblError.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(931, 184);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(94, 24);
            this.lblError.TabIndex = 69;
            this.lblError.Text = "Confirm";
            this.lblError.Visible = false;
            // 
            // RoomPanel
            // 
            this.RoomPanel.Controls.Add(this.label9);
            this.RoomPanel.Controls.Add(this.RezervRoombtn);
            this.RoomPanel.Controls.Add(this.label8);
            this.RoomPanel.Controls.Add(this.cmbCapacity);
            this.RoomPanel.Controls.Add(this.label7);
            this.RoomPanel.Controls.Add(this.cmbRoomNumber);
            this.RoomPanel.Controls.Add(this.pictureBox1);
            this.RoomPanel.Location = new System.Drawing.Point(221, 253);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(904, 146);
            this.RoomPanel.TabIndex = 70;
            this.RoomPanel.Visible = false;
           
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Crimson;
            this.label9.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(72, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 70;
            this.label9.Text = "Confirm";
            this.label9.Visible = false;
            // 
            // RezervRoombtn
            // 
            this.RezervRoombtn.BackColor = System.Drawing.Color.DarkGreen;
            this.RezervRoombtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezervRoombtn.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RezervRoombtn.ForeColor = System.Drawing.Color.Transparent;
            this.RezervRoombtn.Location = new System.Drawing.Point(420, 94);
            this.RezervRoombtn.Name = "RezervRoombtn";
            this.RezervRoombtn.Size = new System.Drawing.Size(160, 49);
            this.RezervRoombtn.TabIndex = 65;
            this.RezervRoombtn.Text = "Rezerv Room";
            this.RezervRoombtn.UseVisualStyleBackColor = false;
            this.RezervRoombtn.Click += new System.EventHandler(this.RezervRoombtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 63;
            this.label8.Text = "Room Capacity";
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Location = new System.Drawing.Point(210, 79);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(190, 26);
            this.cmbCapacity.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 61;
            this.label7.Text = "Room Number";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(210, 36);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(190, 26);
            this.cmbRoomNumber.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RezervControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCustomPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSurname);
            this.Controls.Add(this.Rezervbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtRezervDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStadium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.pictureBox3);
            this.Name = "RezervControl";
            this.Size = new System.Drawing.Size(1268, 491);
            this.Load += new System.EventHandler(this.RezervControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSurname;
        private System.Windows.Forms.Button Rezervbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtRezervDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStadium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RezervRoombtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
