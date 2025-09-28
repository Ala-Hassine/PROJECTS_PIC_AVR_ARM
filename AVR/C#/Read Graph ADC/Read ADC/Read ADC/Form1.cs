using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Read_ADC
{
    public partial class Form1 : Form
    {

        int val = 0;
        string ala = "0";
        int hassine = 0;

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
                    btnCX.Enabled = false;
                    btnDex.Enabled = true;
                    MessageBox.Show("Connexion Réussi", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 100;
                    label1.Text = "Connecté";
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
                timer1.Enabled = false;
                mySerial.Close();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                btnCX.Enabled = true;
                btnDex.Enabled = false;
                textBox1.Text = "00 °C";
                MessageBox.Show("Connexion Terminée", "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = "Déconnecté";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Communication Série", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
            {
                label2.Text = "Reading ....";
            }
            else
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (mySerial.IsOpen)
                {
                    textBox1.Invoke((MethodInvoker)delegate
                    {
                        textBox1.Text = mySerial.ReadLine();
                        timer1.Enabled = true;
                    });
                    val = Convert.ToInt32(textBox1.Text);
                    bgWorker.ReportProgress(val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ala = mySerial.ReadLine();
            this.myChart.Series["Temperature"].Points.AddXY(hassine, ala);
            hassine = hassine + 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = DateTime.Now.ToShortDateString();
        }
    }
}
