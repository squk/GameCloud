namespace GameSync
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelVersion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelCopyright = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelCompanyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reportBug = new DevComponents.DotNetBar.ButtonX();
            this.donateButton = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonX1.Location = new System.Drawing.Point(193, 436);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "OKAY";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.labelProductName.Border.Class = "TextBoxBorder";
            this.labelProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelProductName.ForeColor = System.Drawing.Color.White;
            this.labelProductName.Location = new System.Drawing.Point(12, 162);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.ReadOnly = true;
            this.labelProductName.Size = new System.Drawing.Size(259, 20);
            this.labelProductName.TabIndex = 1;
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.labelVersion.Border.Class = "TextBoxBorder";
            this.labelVersion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(12, 188);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.ReadOnly = true;
            this.labelVersion.Size = new System.Drawing.Size(259, 20);
            this.labelVersion.TabIndex = 2;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.labelCopyright.Border.Class = "TextBoxBorder";
            this.labelCopyright.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(12, 214);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.ReadOnly = true;
            this.labelCopyright.Size = new System.Drawing.Size(259, 20);
            this.labelCopyright.TabIndex = 3;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.labelCompanyName.Border.Class = "TextBoxBorder";
            this.labelCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelCompanyName.ForeColor = System.Drawing.Color.White;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 240);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.ReadOnly = true;
            this.labelCompanyName.Size = new System.Drawing.Size(259, 20);
            this.labelCompanyName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.textBoxDescription.Border.Class = "TextBoxBorder";
            this.textBoxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxDescription.Location = new System.Drawing.Point(12, 266);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(259, 126);
            this.textBoxDescription.TabIndex = 5;
            // 
            // reportBug
            // 
            this.reportBug.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.reportBug.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.reportBug.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.reportBug.Location = new System.Drawing.Point(12, 398);
            this.reportBug.Name = "reportBug";
            this.reportBug.Size = new System.Drawing.Size(124, 23);
            this.reportBug.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.reportBug.TabIndex = 7;
            this.reportBug.Text = "REPORT BUG";
            this.reportBug.TextColor = System.Drawing.Color.Red;
            this.reportBug.Click += new System.EventHandler(this.reportBug_Click);
            // 
            // donateButton
            // 
            this.donateButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.donateButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.donateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.donateButton.Location = new System.Drawing.Point(147, 398);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(124, 23);
            this.donateButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.donateButton.TabIndex = 8;
            this.donateButton.Text = "DONATE";
            this.donateButton.TextColor = System.Drawing.Color.DeepSkyBlue;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.ForeColor = System.Drawing.Color.White;
            this.reflectionImage1.Image = global::GameSync.Properties.Resources.cloudLogo;
            this.reflectionImage1.Location = new System.Drawing.Point(37, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(206, 144);
            this.reflectionImage1.TabIndex = 6;
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 466);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.reportBug);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.buttonX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About Game Cloud";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX labelProductName;
        private DevComponents.DotNetBar.Controls.TextBoxX labelVersion;
        private DevComponents.DotNetBar.Controls.TextBoxX labelCopyright;
        private DevComponents.DotNetBar.Controls.TextBoxX labelCompanyName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxDescription;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonX reportBug;
        private DevComponents.DotNetBar.ButtonX donateButton;

    }
}
