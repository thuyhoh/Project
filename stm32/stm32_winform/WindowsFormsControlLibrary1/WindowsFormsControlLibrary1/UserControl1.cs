using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                bntConnect.Text = "DISCONECT";
                serialPort1.PortName = "COM4";
                serialPort1.BaudRate = Convert.ToInt32("115200");

                serialPort1.Open();
            }
            else
            {
                bntConnect.Text = "CONNECT";
                serialPort1.Write("000");
                serialPort1.Close();
               
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        string Value;
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Value = trackBar.Value.ToString("D3");
            double pwmValue = int.Parse(Value);

            lbspeed.Text = "SPEED: " + pwmValue.ToString();

            serialPort1.Write(Value);

        }
    }
}
