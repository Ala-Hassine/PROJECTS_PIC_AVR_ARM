namespace Température
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltime = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbletat = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.cbxbaud = new System.Windows.Forms.ComboBox();
            this.cbxport = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.led1 = new ThanhDangNguyen.LibLED.Led();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(9, 320);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(300, 39);
            this.lbltime.TabIndex = 22;
            this.lbltime.Text = "Date & Time";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Cyan;
            this.btnclose.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclose.Location = new System.Drawing.Point(166, 275);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(130, 34);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Cyan;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnsave.Location = new System.Drawing.Point(166, 229);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(130, 34);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Cyan;
            this.btnopen.Enabled = false;
            this.btnopen.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnopen.Location = new System.Drawing.Point(28, 275);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(130, 34);
            this.btnopen.TabIndex = 18;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnread
            // 
            this.btnread.BackColor = System.Drawing.Color.Cyan;
            this.btnread.Enabled = false;
            this.btnread.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnread.Location = new System.Drawing.Point(28, 229);
            this.btnread.Margin = new System.Windows.Forms.Padding(4);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(130, 34);
            this.btnread.TabIndex = 17;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = false;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbletat);
            this.groupBox1.Controls.Add(this.pb);
            this.groupBox1.Controls.Add(this.cbxbaud);
            this.groupBox1.Controls.Add(this.cbxport);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 195);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Série";
            // 
            // lbletat
            // 
            this.lbletat.BackColor = System.Drawing.Color.Yellow;
            this.lbletat.ForeColor = System.Drawing.Color.Blue;
            this.lbletat.Location = new System.Drawing.Point(60, 152);
            this.lbletat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbletat.Name = "lbletat";
            this.lbletat.Size = new System.Drawing.Size(184, 36);
            this.lbletat.TabIndex = 2;
            this.lbletat.Text = "ETAT";
            this.lbletat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(19, 116);
            this.pb.Margin = new System.Windows.Forms.Padding(4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(268, 31);
            this.pb.TabIndex = 2;
            // 
            // cbxbaud
            // 
            this.cbxbaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbaud.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxbaud.FormattingEnabled = true;
            this.cbxbaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbxbaud.Location = new System.Drawing.Point(157, 78);
            this.cbxbaud.Margin = new System.Windows.Forms.Padding(4);
            this.cbxbaud.Name = "cbxbaud";
            this.cbxbaud.Size = new System.Drawing.Size(130, 31);
            this.cbxbaud.TabIndex = 3;
            // 
            // cbxport
            // 
            this.cbxport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxport.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxport.FormattingEnabled = true;
            this.cbxport.Location = new System.Drawing.Point(19, 78);
            this.cbxport.Margin = new System.Windows.Forms.Padding(4);
            this.cbxport.Name = "cbxport";
            this.cbxport.Size = new System.Drawing.Size(130, 31);
            this.cbxport.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(157, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Déconnexion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(19, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(325, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(362, 332);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "             Read Température\r\n";
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(120, 110);
            aGaugeLabel1.Color = System.Drawing.Color.Blue;
            aGaugeLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(4, 4);
            aGaugeLabel1.Text = null;
            this.aGauge1.GaugeLabels.Add(aGaugeLabel1);
            aGaugeRange1.Color = System.Drawing.Color.Lime;
            aGaugeRange1.EndValue = 30F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.Green;
            aGaugeRange2.EndValue = 70F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 30F;
            aGaugeRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            aGaugeRange3.EndValue = 90F;
            aGaugeRange3.InnerRadius = 70;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange3";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 70F;
            aGaugeRange4.Color = System.Drawing.Color.Red;
            aGaugeRange4.EndValue = 130F;
            aGaugeRange4.InnerRadius = 70;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRange4";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 90F;
            aGaugeRange5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            aGaugeRange5.EndValue = 150F;
            aGaugeRange5.InnerRadius = 70;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRange5";
            aGaugeRange5.OuterRadius = 80;
            aGaugeRange5.StartValue = 130F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange1);
            this.aGauge1.GaugeRanges.Add(aGaugeRange2);
            this.aGauge1.GaugeRanges.Add(aGaugeRange3);
            this.aGauge1.GaugeRanges.Add(aGaugeRange4);
            this.aGauge1.GaugeRanges.Add(aGaugeRange5);
            this.aGauge1.Location = new System.Drawing.Point(694, 12);
            this.aGauge1.MaxValue = 150F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Violet;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Yellow;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 6;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 2;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 4;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 80;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 5;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(229, 218);
            this.aGauge1.TabIndex = 23;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Transparent;
            this.led1.ChangeStateOnClick = false;
            this.led1.Color = System.Drawing.Color.Blue;
            this.led1.ForeColor = System.Drawing.Color.Transparent;
            this.led1.Location = new System.Drawing.Point(777, 274);
            this.led1.Name = "led1";
            this.led1.On = true;
            this.led1.Size = new System.Drawing.Size(84, 84);
            this.led1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(746, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 26;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Température Via PIC16F877A and C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbletat;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.ComboBox cbxbaud;
        private System.Windows.Forms.ComboBox cbxport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.AGauge aGauge1;
        private ThanhDangNguyen.LibLED.Led led1;
        private System.Windows.Forms.Label label1;
    }
}

