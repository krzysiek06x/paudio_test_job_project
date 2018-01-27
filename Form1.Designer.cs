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
            this.logo_box = new System.Windows.Forms.PictureBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).BeginInit();
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
            // logo_box
            // 
            resources.ApplyResources(this.logo_box, "logo_box");
            this.logo_box.Image = global::WindowsFormsApplication1.Properties.Resources.logo;
            this.logo_box.Name = "logo_box";
            this.logo_box.TabStop = false;
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
            // info_button
            // 
            resources.ApplyResources(this.info_button, "info_button");
            this.info_button.FlatAppearance.BorderSize = 0;
            this.info_button.ForeColor = System.Drawing.SystemColors.Window;
            this.info_button.Image = global::WindowsFormsApplication1.Properties.Resources.info_128;
            this.info_button.Name = "info_button";
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // welcome_label
            // 
            resources.ApplyResources(this.welcome_label, "welcome_label");
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Name = "welcome_label";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ControlBox = false;
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.pcb_choose_button);
            this.Controls.Add(this.logo_box);
            this.Controls.Add(this.cancel_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.PictureBox logo_box;
        private System.Windows.Forms.Button pcb_choose_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Label welcome_label;
    }
}

