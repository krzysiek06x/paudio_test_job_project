namespace WindowsFormsApplication1
{
    partial class about_window
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
            this.ok_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_button.ForeColor = System.Drawing.SystemColors.Window;
            this.ok_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ok_button.Location = new System.Drawing.Point(12, 403);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(572, 93);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.info_128;
            this.pictureBox1.Location = new System.Drawing.Point(222, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ten program, jest programem \"demo\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Przysyłam go zgodnie z naszą rozmową. ";
            // 
            // about_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(596, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ok_button);
            this.Name = "about_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "about_window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}