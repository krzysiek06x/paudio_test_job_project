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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.find_ports_button = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(89, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 148);
            this.listBox1.TabIndex = 0;
            // 
            // find_ports_button
            // 
            this.find_ports_button.Location = new System.Drawing.Point(89, 65);
            this.find_ports_button.Name = "find_ports_button";
            this.find_ports_button.Size = new System.Drawing.Size(199, 58);
            this.find_ports_button.TabIndex = 1;
            this.find_ports_button.Text = "Find ports";
            this.find_ports_button.UseVisualStyleBackColor = true;
            this.find_ports_button.Click += new System.EventHandler(this.find_ports_button_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(89, 422);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(872, 132);
            this.listBox2.TabIndex = 2;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(89, 334);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(120, 23);
            this.connect_button.TabIndex = 3;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // choose_board_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 595);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.find_ports_button);
            this.Controls.Add(this.listBox1);
            this.Name = "choose_board_items";
            this.Text = "choose_board_items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button find_ports_button;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button connect_button;
    }
}