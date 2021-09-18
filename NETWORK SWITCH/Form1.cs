using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETWORK_SWITCH
{
    public partial class Form1 : Form
    {
        private NetWork netwoker = new NetWork();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            switch (comboBox1.Text)
            {
                case "FARO VANTAGE": netwoker.SetIP("128.128.128.10", "255.255.0.0", null); MessageBox.Show("FARO VANTAGE"); break;
                case "LEICA TRACKER": netwoker.SetIP("192.168.0.10", "255.255.255.0", null); MessageBox.Show("LEICA TRACKER"); break;
                case "INTERNET": netwoker.Reset(); MessageBox.Show("INTERNET"); break;
            }
            
        }
    }
}
