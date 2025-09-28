using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace Control_Servo
{
    public partial class Form1 : Form
    {
        SerialPort MySerial = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            SearchPort();
        }
        private void SearchPort()
        {
            string[] port = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(port);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToShortDateString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Sélectionner Le Port et Le Vitesse de Communication", "Control led", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progressBar1.Value = 33;
                    MySerial.PortName = comboBox1.Text;
                    progressBar1.Value = 66;
                    MySerial.BaudRate = Convert.ToInt32(comboBox2.Text);
                    MySerial.Open();
                    button1.Enabled = false;
                    button2.Enabled = true;
                    trackBar1.Enabled = true;
                    progressBar1.Value = 100;
                    MessageBox.Show("Connexion Réussi", "Servo Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "Connecté";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Servo Motor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            MySerial.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            trackBar1.Enabled = false;
            trackBar1.Value = 0;
            label2.Text = label6.Text = "PWM";
            aGauge1.Value = 0;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            MessageBox.Show("Connexion Terminé", "Servo Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = "Déconnecté";
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (MySerial.IsOpen)
            {
                aGauge1.Value = trackBar1.Value;
                MySerial.WriteLine(trackBar1.Value.ToString());
                label2.Text = trackBar1.Value.ToString();
                label6.Text = trackBar1.Value.ToString();
            }
        }
    }
}
