using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            //Remove the control box so the form will only display client area.
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            // add event to move form via mouse
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }
        // cancel button - exit from application
        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void info_button_Click(object sender, EventArgs e)
        {
            new about_window().Show();

        }

        private void pcb_choose_button_Click(object sender, EventArgs e)
        {
            new choose_board_items().Show();
        }
    }
}
