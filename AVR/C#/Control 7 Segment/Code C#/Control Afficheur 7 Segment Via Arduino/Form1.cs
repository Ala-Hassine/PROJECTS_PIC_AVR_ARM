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

namespace Control_Afficheur_7_Segment_Via_Arduino
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            GetPort();
        }
        private void GetPort()
        {
            string[] port = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(port);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 33;
                mySerial.Close();
                button1.Enabled = true;
                progressBar1.Value = 66;
                button2.Enabled = false;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                MessageBox.Show("Connexion Terminée", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 100;
                label1.Text = "Déconnecté";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                label2.Text = "Connexion State";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Sélectionner la vitesse et le Port", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    MessageBox.Show("Connexion Réussi", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 100;
                    label1.Text = "Connecté";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            numericUpDown1.Value = 0;
            label2.Text = "Automatic";
            mySerial.Write("X");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            label2.Text = "Manual";
            mySerial.Write("X");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                try
                {
                    if (numericUpDown1.Value.ToString() == "0")
                    {
                        mySerial.Write("0");
                    }
                    else if (numericUpDown1.Value.ToString() == "1")
                    {
                        mySerial.Write("1");
                    }
                    else if (numericUpDown1.Value.ToString() == "2")
                    {
                        mySerial.Write("2");
                    }
                    else if (numericUpDown1.Value.ToString() == "3")
                    {
                        mySerial.Write("3");
                    }
                    else if (numericUpDown1.Value.ToString() == "4")
                    {
                        mySerial.Write("4");
                    }
                    else if (numericUpDown1.Value.ToString() == "5")
                    {
                        mySerial.Write("5");
                    }
                    else if (numericUpDown1.Value.ToString() == "6")
                    {
                        mySerial.Write("6");
                    }
                    else if (numericUpDown1.Value.ToString() == "7")
                    {
                        mySerial.Write("7");
                    }
                    else if (numericUpDown1.Value.ToString() == "8")
                    {
                        mySerial.Write("8");
                    }
                    else if (numericUpDown1.Value.ToString() == "9")
                    {
                        mySerial.Write("9");
                    }
                    else if (numericUpDown1.Value.ToString() == "10")
                    {
                        mySerial.Write("0");
                    }
                    cnt++;
                    if (cnt >= 10)
                    {
                        cnt = -1;
                        MessageBox.Show("Numéro dépassé le Max", "Control 7 Segment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numericUpDown1.Value = 0;
                    }
                    led7Segment1.LEDNumber = (byte)(cnt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Control 7 Segment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("A");
                button4.BackColor = Color.Green;
                button4.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("B");
                button6.BackColor = Color.Green;
                button6.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("C");
                button8.BackColor = Color.Green;
                button8.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("D");
                button5.BackColor = Color.Green;
                button5.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("E");
                button9.BackColor = Color.Green;
                button9.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("F");
                button7.BackColor = Color.Green;
                button7.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)
            {
                mySerial.Write("G");
                button3.BackColor = Color.Green;
                button3.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mySerial.Write("X");
            button3.Enabled = true;
            button3.BackColor = Color.Gainsboro;
            button4.Enabled = true;
            button4.BackColor = Color.Gainsboro;
            button5.Enabled = true;
            button5.BackColor = Color.Gainsboro;
            button6.Enabled = true;
            button6.BackColor = Color.Gainsboro;
            button7.Enabled = true;
            button7.BackColor = Color.Gainsboro;
            button8.Enabled = true;
            button8.BackColor = Color.Gainsboro;
            button9.Enabled = true;
            button9.BackColor = Color.Gainsboro;
        }
    }
}
