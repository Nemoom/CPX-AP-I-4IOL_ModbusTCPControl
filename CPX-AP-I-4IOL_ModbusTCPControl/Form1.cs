using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus;

namespace CPX_AP_I_4IOL_ModbusTCPControl
{
    public partial class Form1 : Form
    {
        private TcpClient tcpListener;
        private static Modbus.Device.ModbusIpMaster m_Master;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
