namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcb_choose_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_choose_button
            // 
            resources.ApplyResources(this.pcb_choose_button, "pcb_choose_button");
            this.pcb_choose_button.FlatAppearance.BorderSize = 0;
            this.pcb_choose_button.ForeColor = System.Drawing.SystemColors.Window;
            this.pcb_choose_button.Image = global::WindowsFormsApplication1.Properties.Resources.circuit_board_128;
            this.pcb_choose_button.Name = "pcb_choose_button";
            this.pcb_choose_button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cancel_button
            // 
            resources.ApplyResources(this.cancel_button, "cancel_button");
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_64_white;
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.info_128;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcb_choose_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pcb_choose_button;
        private System.Windows.Forms.Button button1;
    }
}

