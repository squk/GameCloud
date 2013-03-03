namespace GameSync
{
    partial class FirstLoginForm
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
            this.startupChk = new System.Windows.Forms.CheckBox();
            this.saveBtn = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // startupChk
            // 
            this.startupChk.AutoSize = true;
            this.startupChk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.startupChk.ForeColor = System.Drawing.Color.White;
            this.startupChk.Location = new System.Drawing.Point(12, 12);
            this.startupChk.Name = "startupChk";
            this.startupChk.Size = new System.Drawing.Size(254, 17);
            this.startupChk.TabIndex = 0;
            this.startupChk.Text = "Open Game Cloud when my computer starts up. ";
            this.startupChk.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(191, 35);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // FirstLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 67);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startupChk);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FirstLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startupChk;
        private DevComponents.DotNetBar.ButtonX saveBtn;
    }
}