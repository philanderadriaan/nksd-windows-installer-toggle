namespace Windows_Installer_Toggle
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_off = new System.Windows.Forms.Button();
            this.button_on = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_off
            // 
            this.button_off.Location = new System.Drawing.Point(10, 10);
            this.button_off.Name = "Button Off";
            this.button_off.Size = new System.Drawing.Size(150, 25);
            this.button_off.TabIndex = 0;
            this.button_off.Text = "Turn Off Windows Installer";
            this.button_off.UseVisualStyleBackColor = true;
            this.button_off.Click += new System.EventHandler(this.button_off_Click);
            // 
            // button_on
            // 
            this.button_on.Location = new System.Drawing.Point(10, 40);
            this.button_on.Name = "Button On";
            this.button_on.Size = new System.Drawing.Size(150, 25);
            this.button_on.TabIndex = 1;
            this.button_on.Text = "Turn On Windows Installer";
            this.button_on.UseVisualStyleBackColor = true;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 70);
            this.Controls.Add(this.button_on);
            this.Controls.Add(this.button_off);
            this.Name = "Form";
            this.Text = "Windows Installer Toggle";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button button_off;
        private System.Windows.Forms.Button button_on;
    }
}