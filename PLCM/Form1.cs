using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
using ACTETHERLib;

namespace PLCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_port.Text = "2000";
            txt_ip.Text = "127.0.0.1";
            txt_sn.Text = "5";

            btn_connect.Text = "CONNECT";
            btn_connect.BackColor = Color.Gray;

            // plc = new ActUtlTypeClass();
        }

        private ActUtlType plc = new ActUtlType();
        // private ActUtlType plc;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            int x = -1;

            var address = txt_ip.Text;
            var port = txt_port.Text;
     
            
            // CHANGE COLOR, TEXT
            var isConnected = btn_connect.Text == "CONNECTED";

            // GET CONNECTED OR DISCONNECTED

            var stationNumber = int.Parse(txt_sn.Text);
            plc.ActLogicalStationNumber = stationNumber;
            
            if (!isConnected)
            {
                x = plc.Open();
                Console.WriteLine(" x is "+x);
                isConnected = (x == 0);
            }
            else if (plc.ActLogicalStationNumber == stationNumber)
            {
                plc.Close();
                plc.ActLogicalStationNumber = 0;
                isConnected = false;
            }
            
            btn_connect.Text = !isConnected ? "CONNECT" : "CONNECTED";
            btn_connect.BackColor = !isConnected ? Color.Gray : Color.Green;
            
        }
        
        private void btn_write_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_value.Text, out int value))
            {
                plc.SetDevice(txt_device.Text, value);
            }
            else
            {
                MessageBox.Show("Invalid value. Please enter a valid number.");
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            if (plc.GetDevice(txt_device.Text, out int readResult) == 0)
            {
                txt_value.Text = readResult.ToString();
            }
            else
            {
                MessageBox.Show("Failed to read from device.");
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            plc.Close();
        }
    }
}