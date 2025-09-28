namespace Shift_74HC595
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblLED = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ComboBaudrate = new System.Windows.Forms.ComboBox();
            this.progressConn = new System.Windows.Forms.ProgressBar();
            this.btnDéconnexion = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ComboCom = new System.Windows.Forms.ComboBox();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(537, 203);
            this.txtData.MaxLength = 1;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(103, 35);
            this.txtData.TabIndex = 47;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(311, 202);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(189, 39);
            this.btnSend.TabIndex = 46;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblLED
            // 
            this.lblLED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLED.ForeColor = System.Drawing.Color.White;
            this.lblLED.Location = new System.Drawing.Point(311, 251);
            this.lblLED.Name = "lblLED";
            this.lblLED.Size = new System.Drawing.Size(354, 40);
            this.lblLED.TabIndex = 45;
            this.lblLED.Text = "LED";
            this.lblLED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn8
            // 
            this.btn8.Enabled = false;
            this.btn8.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(439, 141);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(61, 53);
            this.btn8.TabIndex = 44;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Enabled = false;
            this.btn7.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(375, 141);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(61, 53);
            this.btn7.TabIndex = 43;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Enabled = false;
            this.btn6.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(311, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(61, 53);
            this.btn6.TabIndex = 42;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Enabled = false;
            this.btn5.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(439, 82);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(61, 53);
            this.btn5.TabIndex = 41;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Enabled = false;
            this.btn4.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(375, 82);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(61, 53);
            this.btn4.TabIndex = 40;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Enabled = false;
            this.btn3.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(311, 82);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 53);
            this.btn3.TabIndex = 39;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(439, 23);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 53);
            this.btn2.TabIndex = 38;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Cyan;
            this.lblStatus.Location = new System.Drawing.Point(6, 146);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(278, 34);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBaudrate
            // 
            this.ComboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBaudrate.FormattingEnabled = true;
            this.ComboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.ComboBaudrate.Location = new System.Drawing.Point(148, 73);
            this.ComboBaudrate.Name = "ComboBaudrate";
            this.ComboBaudrate.Size = new System.Drawing.Size(136, 30);
            this.ComboBaudrate.TabIndex = 2;
            // 
            // progressConn
            // 
            this.progressConn.Location = new System.Drawing.Point(6, 111);
            this.progressConn.Name = "progressConn";
            this.progressConn.Size = new System.Drawing.Size(278, 28);
            this.progressConn.TabIndex = 3;
            // 
            // btnDéconnexion
            // 
            this.btnDéconnexion.BackColor = System.Drawing.Color.DarkRed;
            this.btnDéconnexion.Enabled = false;
            this.btnDéconnexion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDéconnexion.ForeColor = System.Drawing.Color.Yellow;
            this.btnDéconnexion.Location = new System.Drawing.Point(148, 26);
            this.btnDéconnexion.Name = "btnDéconnexion";
            this.btnDéconnexion.Size = new System.Drawing.Size(136, 41);
            this.btnDéconnexion.TabIndex = 1;
            this.btnDéconnexion.Text = "Déconnexion";
            this.btnDéconnexion.UseVisualStyleBackColor = false;
            this.btnDéconnexion.Click += new System.EventHandler(this.btnDéconnexion_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConnexion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.Yellow;
            this.btnConnexion.Location = new System.Drawing.Point(6, 26);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(136, 41);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btn1
            // 
            this.btn1.Enabled = false;
            this.btn1.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(375, 23);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 53);
            this.btn1.TabIndex = 37;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Enabled = false;
            this.btn0.Font = new System.Drawing.Font("Droid Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(311, 23);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(61, 53);
            this.btn0.TabIndex = 36;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTime.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblTime.Location = new System.Drawing.Point(15, 207);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(290, 40);
            this.lblTime.TabIndex = 35;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDate.Font = new System.Drawing.Font("Droid Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDate.Location = new System.Drawing.Point(15, 251);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(290, 40);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "00/00/0000";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboCom
            // 
            this.ComboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCom.FormattingEnabled = true;
            this.ComboCom.Location = new System.Drawing.Point(6, 73);
            this.ComboCom.Name = "ComboCom";
            this.ComboCom.Size = new System.Drawing.Size(136, 30);
            this.ComboCom.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.ComboBaudrate);
            this.groupBox1.Controls.Add(this.progressConn);
            this.groupBox1.Controls.Add(this.btnDéconnexion);
            this.groupBox1.Controls.Add(this.btnConnexion);
            this.groupBox1.Controls.Add(this.ComboCom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 190);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Communication";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(504, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 299);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblLED);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift_74HC595";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblLED;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox ComboBaudrate;
        private System.Windows.Forms.ProgressBar progressConn;
        private System.Windows.Forms.Button btnDéconnexion;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox ComboCom;
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

