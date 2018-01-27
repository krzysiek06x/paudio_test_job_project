namespace WindowsFormsApplication1
{
    partial class starting_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(starting_window));
            this.logo_box = new System.Windows.Forms.PictureBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_box
            // 
            this.logo_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logo_box.ErrorImage = null;
            this.logo_box.Image = ((System.Drawing.Image)(resources.GetObject("logo_box.Image")));
            this.logo_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo_box.Location = new System.Drawing.Point(114, 12);
            this.logo_box.Name = "logo_box";
            this.logo_box.Size = new System.Drawing.Size(198, 150);
            this.logo_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo_box.TabIndex = 2;
            this.logo_box.TabStop = false;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(136, 165);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(155, 28);
            this.welcome_label.TabIndex = 3;
            this.welcome_label.Text = "Demo Application";
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_button.ForeColor = System.Drawing.SystemColors.Window;
            this.ok_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ok_button.Location = new System.Drawing.Point(55, 260);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(311, 45);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // starting_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(419, 317);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.logo_box);
            this.Name = "starting_window";
            this.Text = "starting_window";
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_box;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button ok_button;
    }
}