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

namespace hello
{
   
    public partial class Hello1 : Form
    {
        int progress = 0;
        public Hello1()
        {
            InitializeComponent();
        }

        private void Hello1_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progress > 99)
            {
                progress = 100;
            }
            else
            {
                progress = progress + 10;
                progressBar1.Value = progress;
                textBox1.Text = progress.ToString();
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (progress < 1)
            {
                progress = 0;
            }
            else
            {
                progress = progress - 10;
                progressBar1.Value = progress;
                textBox1.Text = progress.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            int portsCnt = ports.Length;
            //foreach (string port in ports)
            //{
                textBox1.Text = portsCnt.ToString();
            //}



        }
    }
}
