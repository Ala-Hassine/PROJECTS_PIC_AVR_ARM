using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Shift_74HC595
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SearchPort();
        }
        void SearchPort()
        {
            string[] port = SerialPort.GetPortNames();
            ComboCom.Items.AddRange(port);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboCom.Text == "" || ComboBaudrate.Text == "")
                {
                    MessageBox.Show("Select Speed And Port", "Serial Communication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progressConn.Value = 33;
                    mySerial.PortName = ComboCom.Text;
                    progressConn.Value = 66;
                    mySerial.BaudRate = Convert.ToInt32(ComboBaudrate.Text);
                    mySerial.Open();
                    btnConnexion.Enabled = false;
                    btnDéconnexion.Enabled = true;
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btnSend.Enabled = true;
                    txtData.Enabled = true;
                    MessageBox.Show("Successful Connection", "Serial Communication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressConn.Value = 100;
                    pictureBox1.Visible = true;
                    lblStatus.Text = "Connected";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Communication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDéconnexion_Click(object sender, EventArgs e)
        {
            try
            {
                mySerial.Close();
                btnConnexion.Enabled = true;
                progressConn.Value = 0;
                btnDéconnexion.Enabled = false;
                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btnSend.Enabled = false;
                txtData.Enabled = false;
                ComboCom.SelectedIndex = -1;
                ComboBaudrate.SelectedIndex = -1;
                txtData.Text = "";
                lblLED.Text = "LED";
                pictureBox1.Visible = false;
                MessageBox.Show("Connection Complete", "Serial Communication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "Disconnected";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Communication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("0");
                    lblLED.Text = "... LED 1 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("1");
                    lblLED.Text = "... LED 2 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("2");
                    lblLED.Text = "... LED 3 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("3");
                    lblLED.Text = "... LED 4 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_yellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("4");
                    lblLED.Text = "... LED 5 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("5");
                    lblLED.Text = "... LED 6 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("6");
                    lblLED.Text = "... LED 7 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("7");
                    lblLED.Text = "... LED 8 Is ON ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_yellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write("8");
                    lblLED.Text = "... All LED Is OFF ...";
                    pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Write(txtData.Text);
                    switch (txtData.Text)
                    {
                        case "0":
                            lblLED.Text = "... LED 1 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_blue; break;
                        case "1":
                            lblLED.Text = "... LED 2 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_green; break;
                        case "2":
                            lblLED.Text = "... LED 3 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_red; break;
                        case "3":
                            lblLED.Text = "... LED 4 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_yellow; break;
                        case "4":
                            lblLED.Text = "... LED 5 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_blue; break;
                        case "5":
                            lblLED.Text = "... LED 6 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_green; break;
                        case "6":
                            lblLED.Text = "... LED 7 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_red; break;
                        case "7":
                            lblLED.Text = "... LED 8 Is ON ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_yellow; break;
                        default :
                            lblLED.Text = "... All LED Is OFF ...";
                            pictureBox1.Image = global::Shift_74HC595.Properties.Resources.led_black;break;
                    }
                    txtData.Text = "";
                    txtData.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
