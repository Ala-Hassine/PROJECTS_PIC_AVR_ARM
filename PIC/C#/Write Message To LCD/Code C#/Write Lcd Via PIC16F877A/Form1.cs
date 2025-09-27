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

namespace Write_Lcd_Via_PIC16F877A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SearchPort();
        }
        void SearchPort()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Sélectionner Le Port et Le Vitesse de Communication", "Write Lcd", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    progressBar1.Value = 100;
                    MessageBox.Show("Connexion Réussi", "Write Lcd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "Connecté";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Control led", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            mySerial.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            MessageBox.Show("Connexion Terminé", "Control led", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = "Déconnecté";
        }
        private void button4_Click(object sender, EventArgs e)
        {
           if (mySerial.IsOpen)
            {
                mySerial.Write(textBox1.Text);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (mySerial.IsOpen)
            {
                mySerial.Write("A");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
