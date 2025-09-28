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

namespace Control_led_Via_Arduino_Using_C_Sharp
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
                    MessageBox.Show("Sélectionner Le Port et Le Vitesse de Communication","Control led", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    button3.Enabled = true;
                    button4.Enabled = true;
                    progressBar1.Value = 100;
                    MessageBox.Show("Connexion Réussi", "Control led", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label2.Text = "Connecté";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Control led", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 66;
            MySerial.Close();
            button1.Enabled = true;
            progressBar1.Value = 33;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            MessageBox.Show("Connexion Terminé", "Control led", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label2.Text = "Déconnecté";
            progressBar1.Value = 0;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( MySerial.IsOpen )
            {
                MySerial.Write("A");
                button3.BackColor = Color.Green;
                button3.Enabled = false;
                button4.Enabled = true;
                pictureBox1.Image = global::Control_led_Via_Arduino_Using_C_Sharp.Properties.Resources.Led_Circle_Green;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MySerial.IsOpen)
            {
                MySerial.Write("B");
                button4.BackColor = Color.Red;
                button4.Enabled = false;
                button3.Enabled = true;
                pictureBox1.Image = global::Control_led_Via_Arduino_Using_C_Sharp.Properties.Resources.Led_Circle_Red;
            }
        }
    }
}
