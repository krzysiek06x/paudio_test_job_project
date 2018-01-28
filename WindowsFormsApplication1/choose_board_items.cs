using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    


    public partial class choose_board_items : Form
    {
        
        public choose_board_items()
        {
            InitializeComponent();
            listBox2.SelectionMode = SelectionMode.None;
            
        }

        private void find_ports_button_Click(object sender, EventArgs e)
        {
            //create port
            SerialPort port = new SerialPort();
            //show list of valid com ports
            foreach (string s in SerialPort.GetPortNames())
            {
                listBox1.Items.Add(s);
            }
            listBox2.Items.Add("Checking ports");
            int port_number = 1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                try
                {
                    port.PortName = "COM" + port_number;
                    port.Open();
                    listBox2.Items.Add("Port " + port.PortName + " not busy");
                    port.Close();
                    port_number++;
                }
                catch
                {
                    listBox2.Items.Add("Port " + port.PortName + " busy");
                }
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {


            try
            {
                listBox2.Items.Add("");
                SerialPort port = new SerialPort();
                port.PortName = listBox1.SelectedItem.ToString();
                port.BaudRate = 9600;
                port.Open();
                listBox2.Items.Add("Otwarto port" + port.PortName);
                port.Close();
                listBox2.Items.Add("Zamknięto port " + port.PortName);
            }
            catch
            {
                listBox2.Items.Add("Błąd, nie można otworzyć portu " + listBox1.SelectedItem.ToString());
            }
        }

    
    
    
    
    
    
    }
}
