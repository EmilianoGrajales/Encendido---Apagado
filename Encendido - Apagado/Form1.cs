using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Encendido___Apagado
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; set; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM8";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += CerrandoForm1;
            this.btnApagar.Click += btnApagar_Click;
            this.btnEncender.Click += btnEncender_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
            textBox1.BackColor = Color.Red;
        }

        private void CerrandoForm1 (object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
            textBox1.BackColor = Color.Lime;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
