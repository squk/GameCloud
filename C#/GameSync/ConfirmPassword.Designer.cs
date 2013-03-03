namespace GameSync
{
    partial class ConfirmPassword
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
            this.passwordText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.okay = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.passwordText.Border.Class = "TextBoxBorder";
            this.passwordText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passwordText.ForeColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(23, 12);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(128, 20);
            this.passwordText.TabIndex = 0;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.WatermarkText = "Confirm Password";
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(8, 38);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // okay
            // 
            this.okay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okay.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okay.Location = new System.Drawing.Point(89, 38);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(75, 23);
            this.okay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okay.TabIndex = 2;
            this.okay.Text = "Okay";
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // ConfirmPassword
            // 
            this.AcceptButton = this.okay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(172, 78);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.passwordText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm your password";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX passwordText;
        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.ButtonX okay;
    }
}