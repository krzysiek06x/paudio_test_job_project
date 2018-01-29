namespace WindowsFormsApplication1
{
    partial class choose_board_items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_button = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.find_ports_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.logo_box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cancel_button.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_64_white;
            this.cancel_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel_button.Location = new System.Drawing.Point(13, 573);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(914, 95);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(13, 434);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(914, 128);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 296);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 132);
            this.listBox1.TabIndex = 4;
            // 
            // find_ports_button
            // 
            this.find_ports_button.FlatAppearance.BorderSize = 0;
            this.find_ports_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_ports_button.Location = new System.Drawing.Point(13, 181);
            this.find_ports_button.Name = "find_ports_button";
            this.find_ports_button.Size = new System.Drawing.Size(199, 58);
            this.find_ports_button.TabIndex = 5;
            this.find_ports_button.Text = "Find ports";
            this.find_ports_button.UseVisualStyleBackColor = false;
            this.find_ports_button.Click += new System.EventHandler(this.find_ports_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.welcome_label.Location = new System.Drawing.Point(263, 31);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(266, 35);
            this.welcome_label.TabIndex = 6;
            this.welcome_label.Text = "Board programming tool";
            // 
            // connect_button
            // 
            this.connect_button.Enabled = false;
            this.connect_button.FlatAppearance.BorderSize = 0;
            this.connect_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_button.Location = new System.Drawing.Point(13, 245);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(199, 36);
            this.connect_button.TabIndex = 7;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // logo_box
            // 
            this.logo_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logo_box.ErrorImage = null;
            this.logo_box.Image = global::WindowsFormsApplication1.Properties.Resources.logo;
            this.logo_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo_box.Location = new System.Drawing.Point(13, 13);
            this.logo_box.Margin = new System.Windows.Forms.Padding(4);
            this.logo_box.Name = "logo_box";
            this.logo_box.Size = new System.Drawing.Size(189, 150);
            this.logo_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo_box.TabIndex = 8;
            this.logo_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(263, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Demo Application";
            // 
            // choose_board_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(940, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo_box);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.find_ports_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.cancel_button);
            this.Name = "choose_board_items";
            this.Text = "choose_board_items";
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button find_ports_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.PictureBox logo_box;
        private System.Windows.Forms.Label label1;
    }
}