
namespace FootballApplication.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblAddWorker = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roomAddControl1 = new FootballApplication.RoomAddControl();
            this.stadiumAddControl1 = new FootballApplication.StadiumAddControl();
            this.workerAddControl1 = new FootballApplication.Forms.WorkerAddControl();
            this.Boolpb = new System.Windows.Forms.PictureBox();
            this.pbbool2 = new System.Windows.Forms.PictureBox();
            this.pbbool = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boolpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbool2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbool)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pbbool);
            this.panel1.Controls.Add(this.pbbool2);
            this.panel1.Controls.Add(this.Boolpb);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblOut);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.lblAddWorker);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblRooms);
            this.panel1.Controls.Add(this.lblStadium);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 1002);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(11, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(60, 24);
            this.lblWelcome.TabIndex = 23;
            this.lblWelcome.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-135, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.ForeColor = System.Drawing.Color.Transparent;
            this.lblOut.Location = new System.Drawing.Point(42, 444);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(91, 24);
            this.lblOut.TabIndex = 21;
            this.lblOut.Text = "Sign Out";
            this.lblOut.Click += new System.EventHandler(this.lblOut_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(11, 433);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(11, 287);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // lblAddWorker
            // 
            this.lblAddWorker.AutoSize = true;
            this.lblAddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWorker.ForeColor = System.Drawing.Color.Transparent;
            this.lblAddWorker.Location = new System.Drawing.Point(42, 287);
            this.lblAddWorker.Name = "lblAddWorker";
            this.lblAddWorker.Size = new System.Drawing.Size(121, 24);
            this.lblAddWorker.TabIndex = 18;
            this.lblAddWorker.Text = "Add Worker";
            this.lblAddWorker.Click += new System.EventHandler(this.lblAddWorker_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 386);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 340);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.ForeColor = System.Drawing.Color.Transparent;
            this.lblRooms.Location = new System.Drawing.Point(43, 386);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(119, 24);
            this.lblRooms.TabIndex = 15;
            this.lblRooms.Text = "Add Rooms";
            this.lblRooms.Click += new System.EventHandler(this.lblRooms_Click);
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadium.ForeColor = System.Drawing.Color.Transparent;
            this.lblStadium.Location = new System.Drawing.Point(42, 340);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(129, 24);
            this.lblStadium.TabIndex = 14;
            this.lblStadium.Text = "Add Stadium";
            this.lblStadium.Click += new System.EventHandler(this.lblStadium_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1394, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1446, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // roomAddControl1
            // 
            this.roomAddControl1.Location = new System.Drawing.Point(336, 85);
            this.roomAddControl1.Name = "roomAddControl1";
            this.roomAddControl1.Size = new System.Drawing.Size(1104, 711);
            this.roomAddControl1.TabIndex = 8;
            this.roomAddControl1.Visible = false;
            // 
            // stadiumAddControl1
            // 
            this.stadiumAddControl1.Location = new System.Drawing.Point(261, 102);
            this.stadiumAddControl1.Name = "stadiumAddControl1";
            this.stadiumAddControl1.Size = new System.Drawing.Size(1296, 750);
            this.stadiumAddControl1.TabIndex = 7;
            this.stadiumAddControl1.Visible = false;
            // 
            // workerAddControl1
            // 
            this.workerAddControl1.Location = new System.Drawing.Point(261, 53);
            this.workerAddControl1.Name = "workerAddControl1";
            this.workerAddControl1.Size = new System.Drawing.Size(1251, 799);
            this.workerAddControl1.TabIndex = 6;
            this.workerAddControl1.Visible = false;
            // 
            // Boolpb
            // 
            this.Boolpb.Image = ((System.Drawing.Image)(resources.GetObject("Boolpb.Image")));
            this.Boolpb.Location = new System.Drawing.Point(169, 287);
            this.Boolpb.Name = "Boolpb";
            this.Boolpb.Size = new System.Drawing.Size(41, 24);
            this.Boolpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boolpb.TabIndex = 24;
            this.Boolpb.TabStop = false;
            this.Boolpb.Visible = false;
            // 
            // pbbool2
            // 
            this.pbbool2.Image = ((System.Drawing.Image)(resources.GetObject("pbbool2.Image")));
            this.pbbool2.Location = new System.Drawing.Point(169, 386);
            this.pbbool2.Name = "pbbool2";
            this.pbbool2.Size = new System.Drawing.Size(41, 24);
            this.pbbool2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbbool2.TabIndex = 26;
            this.pbbool2.TabStop = false;
            this.pbbool2.Visible = false;
            // 
            // pbbool
            // 
            this.pbbool.Image = ((System.Drawing.Image)(resources.GetObject("pbbool.Image")));
            this.pbbool.Location = new System.Drawing.Point(169, 340);
            this.pbbool.Name = "pbbool";
            this.pbbool.Size = new System.Drawing.Size(41, 24);
            this.pbbool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbbool.TabIndex = 27;
            this.pbbool.TabStop = false;
            this.pbbool.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.roomAddControl1);
            this.Controls.Add(this.stadiumAddControl1);
            this.Controls.Add(this.workerAddControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boolpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbool2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblAddWorker;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private WorkerAddControl workerAddControl1;
        private StadiumAddControl stadiumAddControl1;
        private RoomAddControl roomAddControl1;
        private System.Windows.Forms.PictureBox Boolpb;
        private System.Windows.Forms.PictureBox pbbool2;
        private System.Windows.Forms.PictureBox pbbool;
    }
}