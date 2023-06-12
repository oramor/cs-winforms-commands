namespace cs_winforms_commands
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.canShowProductsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainFormMenuStrip.TabIndex = 1;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // canShowProductsCheckBox
            // 
            this.canShowProductsCheckBox.AutoSize = true;
            this.canShowProductsCheckBox.Location = new System.Drawing.Point(333, 183);
            this.canShowProductsCheckBox.Name = "canShowProductsCheckBox";
            this.canShowProductsCheckBox.Size = new System.Drawing.Size(192, 29);
            this.canShowProductsCheckBox.TabIndex = 2;
            this.canShowProductsCheckBox.Text = "Can Show Products";
            this.canShowProductsCheckBox.UseVisualStyleBackColor = true;
            this.canShowProductsCheckBox.CheckedChanged += new System.EventHandler(this.canShowProductsCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canShowProductsCheckBox);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip mainFormMenuStrip;
        private CheckBox canShowProductsCheckBox;
    }
}