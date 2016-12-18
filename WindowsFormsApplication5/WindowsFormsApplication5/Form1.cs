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
using System.IO;


namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        public Form1()
        {
            InitializeComponent();
           
            serialPort1.PortName = "COM9";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int DoorStatus = Convert.ToInt32(serialPort1.ReadLine());
            if (DoorStatus == 2)
            {
                pictureBox1.Image = WindowsFormsApplication5.Properties.Resources.closed;
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                if(DoorStatus == 1)
                {
                    pictureBox1.BackColor = Color.White;
                    pictureBox1.Image = WindowsFormsApplication5.Properties.Resources.opened;
                }
                else
                {
                    pictureBox1.BackColor = Color.White;
                    pictureBox1.Image = WindowsFormsApplication5.Properties.Resources.closed;
                }
                    
            }
        }
    }
}
