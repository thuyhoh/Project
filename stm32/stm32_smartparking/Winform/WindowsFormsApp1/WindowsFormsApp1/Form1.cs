using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool btnState = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!btnState)
            {
                button1.Text = "Disconnect";
                btnState = true;
            }
            else 
            {
                button1.Text = "Connect";
                btnState = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.ShowDialog();
            f.Text = "history";
        }

        bool labelMode_Status = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!labelMode_Status)
            {
                labelMode.Text = "Leaving";
                labelMode_Status = true;
            }
            else 
            {
                labelMode.Text = "Parking";
                labelMode_Status = false;
            }
        }
    }
}
