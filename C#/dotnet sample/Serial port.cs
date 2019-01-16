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

namespace mvenc852_test_win
{
    public partial class Serial_port : Form
    {


        public Serial_port()
        {
            InitializeComponent();
        }

       


        private void Serial_port_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_selectport.Items.Clear();
                comboBox_selectport.Items.Add(port);
            }
            if (ports.Length > 0)
            {
                comboBox_selectport.SelectedIndex = 0;
            }
            

        }

        private void comboBox_selectport_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
