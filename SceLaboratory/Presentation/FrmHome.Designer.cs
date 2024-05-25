namespace Presentation
{
    partial class FrmHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.BtnSearchPorts = new System.Windows.Forms.Button();
            this.CboPorts = new System.Windows.Forms.ComboBox();
            this.BtnConect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpPorts = new System.IO.Ports.SerialPort(this.components);
            this.graficaTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficaHumedad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.actualizarDgv = new System.Windows.Forms.Timer(this.components);
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaHumedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Baut Rate";
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
            this.CboBaudRate.Location = new System.Drawing.Point(107, 87);
            this.CboBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(90, 21);
            this.CboBaudRate.TabIndex = 24;
            this.CboBaudRate.Text = "9600";
            // 
            // BtnSearchPorts
            // 
            this.BtnSearchPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnSearchPorts.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSearchPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchPorts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchPorts.Location = new System.Drawing.Point(16, 50);
            this.BtnSearchPorts.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearchPorts.Name = "BtnSearchPorts";
            this.BtnSearchPorts.Size = new System.Drawing.Size(80, 23);
            this.BtnSearchPorts.TabIndex = 23;
            this.BtnSearchPorts.Text = "search ports";
            this.BtnSearchPorts.UseVisualStyleBackColor = false;
            this.BtnSearchPorts.Click += new System.EventHandler(this.BtnSearchPorts_Click);
            // 
            // CboPorts
            // 
            this.CboPorts.FormattingEnabled = true;
            this.CboPorts.Location = new System.Drawing.Point(107, 50);
            this.CboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.CboPorts.Name = "CboPorts";
            this.CboPorts.Size = new System.Drawing.Size(90, 21);
            this.CboPorts.TabIndex = 22;
            // 
            // BtnConect
            // 
            this.BtnConect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConect.Enabled = false;
            this.BtnConect.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.BtnConect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConect.ForeColor = System.Drawing.Color.FloralWhite;
            this.BtnConect.Location = new System.Drawing.Point(107, 7);
            this.BtnConect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConect.Name = "BtnConect";
            this.BtnConect.Size = new System.Drawing.Size(90, 28);
            this.BtnConect.TabIndex = 21;
            this.BtnConect.Text = "Conect";
            this.BtnConect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConect.UseVisualStyleBackColor = false;
            this.BtnConect.Click += new System.EventHandler(this.BtnConect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CboBaudRate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnConect);
            this.panel1.Controls.Add(this.CboPorts);
            this.panel1.Controls.Add(this.BtnSearchPorts);
            this.panel1.Location = new System.Drawing.Point(11, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 122);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 15);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // SpPorts
            // 
            this.SpPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SpPorts_DataReceived);
            // 
            // graficaTemp
            // 
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            this.graficaTemp.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficaTemp.Legends.Add(legend3);
            this.graficaTemp.Location = new System.Drawing.Point(250, 12);
            this.graficaTemp.Name = "graficaTemp";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperatura";
            this.graficaTemp.Series.Add(series3);
            this.graficaTemp.Size = new System.Drawing.Size(314, 151);
            this.graficaTemp.TabIndex = 28;
            this.graficaTemp.Text = "chart1";
            // 
            // graficaHumedad
            // 
            chartArea4.Name = "ChartArea1";
            this.graficaHumedad.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.graficaHumedad.Legends.Add(legend4);
            this.graficaHumedad.Location = new System.Drawing.Point(250, 186);
            this.graficaHumedad.Name = "graficaHumedad";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Humedad";
            this.graficaHumedad.Series.Add(series4);
            this.graficaHumedad.Size = new System.Drawing.Size(300, 151);
            this.graficaHumedad.TabIndex = 29;
            this.graficaHumedad.Text = "chart2";
            // 
            // actualizarDgv
            // 
            this.actualizarDgv.Interval = 2000;
            this.actualizarDgv.Tick += new System.EventHandler(this.actualizarDgv_Tick);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(590, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(485, 316);
            this.dgvDatos.TabIndex = 30;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 416);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.graficaHumedad);
            this.Controls.Add(this.graficaTemp);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaHumedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.Button BtnSearchPorts;
        private System.Windows.Forms.ComboBox CboPorts;
        private System.Windows.Forms.Button BtnConect;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort SpPorts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaHumedad;
        private System.Windows.Forms.Timer actualizarDgv;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}