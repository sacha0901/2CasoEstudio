namespace Presentation
{
    partial class FrmAutentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutentication));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnConectLogin = new System.Windows.Forms.Button();
            this.CboPortsLogin = new System.Windows.Forms.ComboBox();
            this.BtnSearchPortsLogin = new System.Windows.Forms.Button();
            this.CboBaudRateLogin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpPortsLogin = new System.IO.Ports.SerialPort(this.components);
            this.txbDato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(317, 53);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(130, 136);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 28;
            this.pctLogo.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(110, 141);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(102, 48);
            this.btnIngresar.TabIndex = 27;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(218, 141);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 48);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(133, 103);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(175, 20);
            this.txtClave.TabIndex = 25;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblClave.Location = new System.Drawing.Point(36, 106);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 24;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(133, 68);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtUsuario.TabIndex = 23;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(36, 71);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(525, 43);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Iniciar Sesión";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // erpClave
            // 
            this.erpClave.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnConectLogin);
            this.panel3.Controls.Add(this.CboPortsLogin);
            this.panel3.Controls.Add(this.BtnSearchPortsLogin);
            this.panel3.Controls.Add(this.CboBaudRateLogin);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(39, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 94);
            this.panel3.TabIndex = 45;
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
            // BtnConectLogin
            // 
            this.BtnConectLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConectLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnConectLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConectLogin.Location = new System.Drawing.Point(308, 24);
            this.BtnConectLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConectLogin.Name = "BtnConectLogin";
            this.BtnConectLogin.Size = new System.Drawing.Size(92, 34);
            this.BtnConectLogin.TabIndex = 33;
            this.BtnConectLogin.Text = "Conect";
            this.BtnConectLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConectLogin.UseVisualStyleBackColor = false;
            this.BtnConectLogin.Click += new System.EventHandler(this.BtnConectLogin_Click);
            // 
            // CboPortsLogin
            // 
            this.CboPortsLogin.FormattingEnabled = true;
            this.CboPortsLogin.Location = new System.Drawing.Point(143, 9);
            this.CboPortsLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboPortsLogin.Name = "CboPortsLogin";
            this.CboPortsLogin.Size = new System.Drawing.Size(119, 21);
            this.CboPortsLogin.TabIndex = 25;
            // 
            // BtnSearchPortsLogin
            // 
            this.BtnSearchPortsLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnSearchPortsLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSearchPortsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchPortsLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchPortsLogin.Location = new System.Drawing.Point(9, 9);
            this.BtnSearchPortsLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchPortsLogin.Name = "BtnSearchPortsLogin";
            this.BtnSearchPortsLogin.Size = new System.Drawing.Size(107, 32);
            this.BtnSearchPortsLogin.TabIndex = 26;
            this.BtnSearchPortsLogin.Text = "search ports";
            this.BtnSearchPortsLogin.UseVisualStyleBackColor = false;
            this.BtnSearchPortsLogin.Click += new System.EventHandler(this.BtnSearchPortsLogin_Click);
            // 
            // CboBaudRateLogin
            // 
            this.CboBaudRateLogin.FormattingEnabled = true;
            this.CboBaudRateLogin.Items.AddRange(new object[] {
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
            this.CboBaudRateLogin.Location = new System.Drawing.Point(143, 50);
            this.CboBaudRateLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboBaudRateLogin.Name = "CboBaudRateLogin";
            this.CboBaudRateLogin.Size = new System.Drawing.Size(119, 21);
            this.CboBaudRateLogin.TabIndex = 27;
            this.CboBaudRateLogin.Text = "9600";
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
            // SpPortsLogin
            // 
            this.SpPortsLogin.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SpPortsLogin_DataReceived);
            // 
            // txbDato
            // 
            this.txbDato.Location = new System.Drawing.Point(429, 332);
            this.txbDato.Name = "txbDato";
            this.txbDato.Size = new System.Drawing.Size(100, 20);
            this.txbDato.TabIndex = 46;
            // 
            // FrmAutentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 364);
            this.Controls.Add(this.txbDato);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAutentication";
            this.Text = "FrmAutentication";
            this.Load += new System.EventHandler(this.FrmAutentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider erpUsuario;
        private System.Windows.Forms.ErrorProvider erpClave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnConectLogin;
        private System.Windows.Forms.ComboBox CboPortsLogin;
        private System.Windows.Forms.Button BtnSearchPortsLogin;
        private System.Windows.Forms.ComboBox CboBaudRateLogin;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort SpPortsLogin;
        private System.Windows.Forms.TextBox txbDato;
    }
}