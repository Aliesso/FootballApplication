
namespace FootballApplication
{
    partial class RoomAddControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAddControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.Roombtn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtRoomCapacity = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 738);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Crimson;
            this.lblError.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Transparent;
            this.lblError.Location = new System.Drawing.Point(509, 458);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(94, 24);
            this.lblError.TabIndex = 41;
            this.lblError.Text = "Confirm";
            this.lblError.Visible = false;
            // 
            // Roombtn
            // 
            this.Roombtn.BackColor = System.Drawing.Color.Green;
            this.Roombtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Roombtn.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roombtn.ForeColor = System.Drawing.Color.Transparent;
            this.Roombtn.Location = new System.Drawing.Point(483, 389);
            this.Roombtn.Name = "Roombtn";
            this.Roombtn.Size = new System.Drawing.Size(140, 49);
            this.Roombtn.TabIndex = 40;
            this.Roombtn.Text = "Add Room";
            this.Roombtn.UseVisualStyleBackColor = false;
            this.Roombtn.Click += new System.EventHandler(this.Roombtn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Green;
            this.lbl1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(624, 225);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(166, 24);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "Room Capacity";
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRoomCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCapacity.Location = new System.Drawing.Point(628, 263);
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(218, 24);
            this.txtRoomCapacity.TabIndex = 38;
            this.txtRoomCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomCapacity_KeyPress);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Green;
            this.lbl2.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(249, 225);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(142, 24);
            this.lbl2.TabIndex = 37;
            this.lbl2.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(253, 263);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(218, 24);
            this.txtRoomNumber.TabIndex = 36;
            // 
            // RoomAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Roombtn);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtRoomCapacity);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RoomAddControl";
            this.Size = new System.Drawing.Size(1101, 722);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button Roombtn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtRoomNumber;
    }
}
