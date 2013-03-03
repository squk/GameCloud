namespace GameSync
{
    partial class settingsForm
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
            this.chk = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chooseButton = new DevComponents.DotNetBar.ButtonX();
            this.locationBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.saveButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.startupChk = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.logOutButton = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk
            // 
            this.chk.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk.ForeColor = System.Drawing.Color.White;
            this.chk.Location = new System.Drawing.Point(3, 3);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(222, 23);
            this.chk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk.TabIndex = 0;
            this.chk.Text = "Recover all saves to a custom location";
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chooseButton
            // 
            this.chooseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.chooseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.chooseButton.Enabled = false;
            this.chooseButton.Location = new System.Drawing.Point(203, 32);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(60, 20);
            this.chooseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "Choose...";
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.locationBox.Border.Class = "TextBoxBorder";
            this.locationBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.locationBox.Enabled = false;
            this.locationBox.ForeColor = System.Drawing.Color.White;
            this.locationBox.Location = new System.Drawing.Point(3, 32);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(194, 20);
            this.locationBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(227, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 23);
            this.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "SAVE";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(161, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupPanel1.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.startupChk);
            this.groupPanel1.Location = new System.Drawing.Point(10, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(277, 59);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 8;
            this.groupPanel1.Text = "Asked On First Login";
            // 
            // startupChk
            // 
            this.startupChk.BackColor = System.Drawing.Color.Transparent;
            this.startupChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // 
            // 
            this.startupChk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.startupChk.ForeColor = System.Drawing.Color.White;
            this.startupChk.Location = new System.Drawing.Point(3, 3);
            this.startupChk.Name = "startupChk";
            this.startupChk.Size = new System.Drawing.Size(260, 23);
            this.startupChk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.startupChk.TabIndex = 3;
            this.startupChk.Text = "Open GameCloud when my computer starts";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupPanel2.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.locationBox);
            this.groupPanel2.Controls.Add(this.chk);
            this.groupPanel2.Controls.Add(this.chooseButton);
            this.groupPanel2.Location = new System.Drawing.Point(10, 77);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(277, 85);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 9;
            this.groupPanel2.Text = "Customization";
            // 
            // logOutButton
            // 
            this.logOutButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.logOutButton.BackColor = System.Drawing.Color.Red;
            this.logOutButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.logOutButton.Location = new System.Drawing.Point(10, 168);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.logOutButton.TabIndex = 10;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 196);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX chk;
        private DevComponents.DotNetBar.ButtonX chooseButton;
        private DevComponents.DotNetBar.Controls.TextBoxX locationBox;
        private DevComponents.DotNetBar.ButtonX saveButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.CheckBoxX startupChk;
        private DevComponents.DotNetBar.ButtonX logOutButton;
    }
}