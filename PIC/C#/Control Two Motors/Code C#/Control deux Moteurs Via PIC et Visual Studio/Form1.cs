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

namespace Control_deux_Moteurs_Via_PIC_et_Visual_Studio
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Sélectionner Le Port et Le Vitesse de Communication", "Control Moteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progressBar1.Value = 33;
                    mySerial.PortName = comboBox1.Text;
                    progressBar1.Value = 66;
                    mySerial.BaudRate = Convert.ToInt32(comboBox2.Text);
                    mySerial.Open();
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    progressBar1.Value = 100;
                    MessageBox.Show("Connexion Réussi", "Control Moteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "Connecté";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Control Moteur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mySerial.Close();
            button1.Enabled = true;
            progressBar1.Value = 0;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            label2.Text = "Moteur";
            label3.Text = "SENS";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            MessageBox.Show("Connexion Terminé", "Control Moteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = "Déconnecté";
        }
        private void button3_Click(object sender, EventArgs e)
        {
          if (mySerial.IsOpen)
            {
                mySerial.Write("1");
                label2.Text = "Moteur 1 et 2";
                label3.Text = "Forward";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("2");
                label2.Text = "Moteur 1 et 2";
                label3.Text = "Backward";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("3");
                label2.Text = "Moteur 1";
                label3.Text = "Right";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("4");
                label2.Text = "Moteur 2";
                label3.Text = "Left";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("5");
                label2.Text = "Moteur 1 et 2";
                label3.Text = "Stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
