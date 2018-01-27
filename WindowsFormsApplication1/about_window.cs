﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class about_window : Form
    {
        public about_window()
        {
            InitializeComponent();
            //Remove the control box so the form will only display client area.
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
