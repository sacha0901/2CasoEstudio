namespace Presentation.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSensores = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnInterruptor = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnIluminacion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPacients = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnConect = new System.Windows.Forms.Button();
            this.CboPorts = new System.Windows.Forms.ComboBox();
            this.BtnSearchPorts = new System.Windows.Forms.Button();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpPorts = new System.IO.Ports.SerialPort(this.components);
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panelSideMenu.Controls.Add(this.btnSensores);
            this.panelSideMenu.Controls.Add(this.lblName);
            this.panelSideMenu.Controls.Add(this.lblPosition);
            this.panelSideMenu.Controls.Add(this.btnInterruptor);
            this.panelSideMenu.Controls.Add(this.pictureBoxPhoto);
            this.panelSideMenu.Controls.Add(this.btnIluminacion);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnPacients);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(164, 600);
            this.panelSideMenu.TabIndex = 2;
            // 
            // btnSensores
            // 
            this.btnSensores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSensores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSensores.FlatAppearance.BorderSize = 0;
            this.btnSensores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensores.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSensores.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSensores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensores.Location = new System.Drawing.Point(20, 349);
            this.btnSensores.Margin = new System.Windows.Forms.Padding(2);
            this.btnSensores.Name = "btnSensores";
            this.btnSensores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSensores.Size = new System.Drawing.Size(107, 28);
            this.btnSensores.TabIndex = 28;
            this.btnSensores.Text = "Sensores";
            this.btnSensores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSensores.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(93, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPosition.Location = new System.Drawing.Point(93, 78);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 15;
            this.lblPosition.Text = "Position";
            // 
            // btnInterruptor
            // 
            this.btnInterruptor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterruptor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInterruptor.FlatAppearance.BorderSize = 0;
            this.btnInterruptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterruptor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterruptor.ForeColor = System.Drawing.Color.DarkGray;
            this.btnInterruptor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterruptor.Location = new System.Drawing.Point(20, 306);
            this.btnInterruptor.Margin = new System.Windows.Forms.Padding(2);
            this.btnInterruptor.Name = "btnInterruptor";
            this.btnInterruptor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInterruptor.Size = new System.Drawing.Size(107, 28);
            this.btnInterruptor.TabIndex = 27;
            this.btnInterruptor.Text = "Interruptores";
            this.btnInterruptor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterruptor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInterruptor.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(10, 26);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(65, 68);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 13;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // btnIluminacion
            // 
            this.btnIluminacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIluminacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIluminacion.FlatAppearance.BorderSize = 0;
            this.btnIluminacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIluminacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIluminacion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnIluminacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIluminacion.Location = new System.Drawing.Point(20, 259);
            this.btnIluminacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIluminacion.Name = "btnIluminacion";
            this.btnIluminacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIluminacion.Size = new System.Drawing.Size(107, 28);
            this.btnIluminacion.TabIndex = 26;
            this.btnIluminacion.Text = "Iluminacion";
            this.btnIluminacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIluminacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIluminacion.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 407);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 45);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "  Cerrar sesión";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPacients
            // 
            this.btnPacients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacients.FlatAppearance.BorderSize = 0;
            this.btnPacients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacients.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacients.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPacients.Image = ((System.Drawing.Image)(resources.GetObject("btnPacients.Image")));
            this.btnPacients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacients.Location = new System.Drawing.Point(0, 190);
            this.btnPacients.Margin = new System.Windows.Forms.Padding(2);
            this.btnPacients.Name = "btnPacients";
            this.btnPacients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPacients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPacients.Size = new System.Drawing.Size(230, 45);
            this.btnPacients.TabIndex = 21;
            this.btnPacients.Text = "  Pacientes";
            this.btnPacients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacients.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 142);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(230, 45);
            this.btnUsers.TabIndex = 20;
            this.btnUsers.Text = "  Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnConect);
            this.panel3.Controls.Add(this.CboPorts);
            this.panel3.Controls.Add(this.BtnSearchPorts);
            this.panel3.Controls.Add(this.CboBaudRate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(179, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 94);
            this.panel3.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(316, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // BtnConect
            // 
            this.BtnConect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnConect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConect.Location = new System.Drawing.Point(308, 24);
            this.BtnConect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConect.Name = "BtnConect";
            this.BtnConect.Size = new System.Drawing.Size(92, 34);
            this.BtnConect.TabIndex = 33;
            this.BtnConect.Text = "Conect";
            this.BtnConect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConect.UseVisualStyleBackColor = false;
            this.BtnConect.Click += new System.EventHandler(this.BtnConect_Click_1);
            // 
            // CboPorts
            // 
            this.CboPorts.FormattingEnabled = true;
            this.CboPorts.Location = new System.Drawing.Point(143, 9);
            this.CboPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboPorts.Name = "CboPorts";
            this.CboPorts.Size = new System.Drawing.Size(119, 21);
            this.CboPorts.TabIndex = 25;
            // 
            // BtnSearchPorts
            // 
            this.BtnSearchPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnSearchPorts.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSearchPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchPorts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchPorts.Location = new System.Drawing.Point(9, 9);
            this.BtnSearchPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchPorts.Name = "BtnSearchPorts";
            this.BtnSearchPorts.Size = new System.Drawing.Size(107, 32);
            this.BtnSearchPorts.TabIndex = 26;
            this.BtnSearchPorts.Text = "search ports";
            this.BtnSearchPorts.UseVisualStyleBackColor = false;
            this.BtnSearchPorts.Click += new System.EventHandler(this.BtnSearchPorts_Click_1);
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(143, 50);
            this.CboBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(119, 21);
            this.CboBaudRate.TabIndex = 27;
            this.CboBaudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Velocidad ";
            // 
            // SpPorts
            // 
            this.SpPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SpPorts_DataReceived_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Button btnPacients;
        internal System.Windows.Forms.Button btnUsers;
        internal System.Windows.Forms.Button btnSensores;
        internal System.Windows.Forms.Button btnInterruptor;
        internal System.Windows.Forms.Button btnIluminacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnConect;
        private System.Windows.Forms.ComboBox CboPorts;
        private System.Windows.Forms.Button BtnSearchPorts;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.IO.Ports.SerialPort SpPorts;
    }
}