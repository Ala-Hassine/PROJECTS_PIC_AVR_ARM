using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Température
{
    public partial class Form1 : Form
    {
        string data;
        int val;
        public Form1()
        {
            InitializeComponent();
            GetPortCom();
        }

        void GetPortCom()
        {
            string[] port = SerialPort.GetPortNames();
            cbxport.Items.AddRange(port);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           TopMost = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxport.Text == "" || cbxbaud.Text == "")
                {
                    MessageBox.Show("Sélectionner la vitesse et le Port", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pb.Value = 33;
                    mySerial.PortName = cbxport.Text;
                    pb.Value = 66;
                    mySerial.BaudRate = Convert.ToInt32(cbxbaud.Text);
                    mySerial.Open();
                    button1.Enabled = false;
                    button2.Enabled = true;
                    btnopen.Enabled = true;
                    btnread.Enabled = true;
                    btnsave.Enabled = true;
                    textBox1.Enabled = true;
                    MessageBox.Show("Connexion Réussi", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pb.Value = 100;
                    lbletat.Text = "Connecté";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                mySerial.Close();
                button1.Enabled = true;
                pb.Value = 0;
                button2.Enabled = false;
                btnopen.Enabled = false;
                btnread.Enabled = false;
                btnsave.Enabled = false;
                textBox1.Enabled = false;
                cbxbaud.SelectedIndex = -1;
                cbxport.SelectedIndex = -1;
                label1.Text = "00 °C";
                aGauge1.Value = 0;
                textBox1.Text = "             Read Température";
                MessageBox.Show("Connexion Terminée", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pb.Value = 100;
                lbletat.Text = "Déconnecté";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Close();
                mySerial.DataReceived += DataReceivedHandler;
                mySerial.Open();
            }
            else
            {
                mySerial.Open();
                mySerial.DataReceived += DataReceivedHandler;
            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (mySerial.IsOpen)
                {
                    Thread.Sleep(100);
                    data = mySerial.ReadExisting();
                    this.Invoke(new EventHandler(displaydata));
                }
            }
            catch (TimeoutException)
            {
                mySerial.Close();
            }
        }

        void displaydata(object sender, EventArgs e)
        {
            textBox1.AppendText(data + " ==> " + lbltime.Text + " ;");
            //aGauge1.Value = (int)Convert.ToDouble(textBox2.Text);
            val = Convert.ToInt32(data);
            aGauge1.Value = val;
            label1.Text = val.ToString() + " °C";
            ala();
        }

        void ala()
        {
            if (aGauge1.Value < 30)
            {
                led1.Color = Color.Lime;
            }
            else if (aGauge1.Value > 30 && aGauge1.Value < 70)
            {
                led1.Color = Color.Green;
            }
            else if (aGauge1.Value > 70 && aGauge1.Value < 90)
            {
                led1.Color = Color.Salmon;
            }
            else if (aGauge1.Value > 90 && aGauge1.Value < 130)
            {
                led1.Color = Color.Red;
            }
            else if (aGauge1.Value > 130)
            {
                led1.Color = Color.Brown;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really Save Data ?", "Température", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (textBox1.Text.Trim() == "")
                    {
                        MessageBox.Show("Please Enter Data In TextBox", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(@"Data.txt", true))
                        {
                            sw.WriteLine(textBox1.Text + "\n");
                            MessageBox.Show("Data Is Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Data Is Not Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                Process.Start(path + "\\Data.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really Exit Application ?", "Write_Read Via Arduino", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
