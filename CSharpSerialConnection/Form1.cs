using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpSerialConnection
{
    public partial class Form1 : Form
    {
        private SerialPort sPort;

        public Form1()
        {
            InitializeComponent();
            sPort = null;
        }

        private void RenesSerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rtbOutput.Invoke(
                new EventHandler(
                    delegate
                    {
                        rtbOutput.Text += sPort.ReadExisting();
                        rtbOutput.Select(rtbOutput.Text.Length, 0);
                    }));   
        } 

        private void btnOpenCOM_Click(object sender, EventArgs e)
        {
            if (sPort == null)
            {
                try
                {
                    sPort = new SerialPort("COM1", 9600/*38400*/, Parity.None, 8, StopBits.One);
                    sPort.DataReceived += new SerialDataReceivedEventHandler(RenesSerialDataReceived);
                    sPort.Open();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Creation failed");
                }
            }
        }

        private void btnLeftMotorSpeed_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{{setleftmotorspeed(" + nudLeftMotorSpeed.Value.ToString() + ")}}\0");
            }
        }

        private void btnRightMotorSpeed_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{{setrightmotorspeed(" + nudLeftMotorSpeed.Value.ToString() + ")}}\0");
            }
        }

        private void btnStopMotor_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{{setmotortostop}}\0");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("{{getbatterylvlaspercentage}}\0");
            }
        }

        private void btnCloseCOM_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Close();
            }
        }
    }
}