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
        SerialPort port = new SerialPort();
        public choose_board_items()
        {
            InitializeComponent();
            //Remove the control box so the form will only display client area.
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            // add event to move form via mouse
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.choose_board_items_MouseDown);
            this.ResumeLayout(false);

            listBox2.SelectionMode = SelectionMode.None;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void find_ports_button_Click(object sender, EventArgs e)
        {
            int port_number = 1;
            listBox1.Items.Clear();
            //create port
            SerialPort port = new SerialPort();
            //show list of valid com ports
            foreach (string s in SerialPort.GetPortNames())
            {
                listBox1.Items.Add(s);
            }
            listBox2.Items.Add("Checking ports");
            //listBox2.Items.Add("items = " + listBox1.Items.Count);

            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    try
                    {
                        port.PortName = "COM" + port_number;
                        port.Open();
                        listBox2.Items.Add("Port " + port.PortName + " not busy");
                        port.Dispose();
                        port.Close();

                    }
                    catch
                    {
                        listBox2.Items.Add("Port " + port.PortName + " busy");
                    }
                    port_number++;
                }
                connect_button.Enabled = true;
            }
            else
            {
                listBox2.Items.Add("No avilable ports");
            }



        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                connect_button.Text = "Connect";
                port.Dispose();
                port.Close();
                listBox2.Items.Add("Port " + port.PortName.ToString() + " closed");
                connect_button.Enabled = false;
                find_ports_button.Enabled = true;
                foreach (string s in SerialPort.GetPortNames())
                {
                    listBox1.Items.Add(s);
                }
            }
            else
            {
                try
                {
                    port.PortName = listBox1.SelectedItem.ToString();
                    port.Open();
                    listBox2.Items.Add("Port " + listBox1.SelectedItem.ToString() + " opened");
                    connect_button.Text = "Disconnect";
                    listBox1.Items.Clear();
                }
                catch
                {
                    listBox2.Items.Add("Can't open port  " + listBox1.SelectedItem.ToString() + "or port not selected");
                }
                find_ports_button.Enabled = false;
            }
        }
    }
}
