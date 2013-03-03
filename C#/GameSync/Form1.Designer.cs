namespace GameSync
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginButton = new DevComponents.DotNetBar.ButtonX();
            this.userLBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.passLBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.registerButton = new DevComponents.DotNetBar.ButtonX();
            this.cPassRBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.passRBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.userRBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.regularExpressionValidator3 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("You must enter a username.");
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroShell1.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            this.metroTabPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.loginButton.Location = new System.Drawing.Point(67, 138);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOGIN";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userLBox
            // 
            this.userLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.userLBox.Border.Class = "TextBoxBorder";
            this.userLBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userLBox.ForeColor = System.Drawing.Color.White;
            this.userLBox.Location = new System.Drawing.Point(49, 86);
            this.userLBox.Name = "userLBox";
            this.userLBox.Size = new System.Drawing.Size(113, 20);
            this.userLBox.TabIndex = 1;
            this.userLBox.WatermarkText = "Username";
            // 
            // passLBox
            // 
            this.passLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.passLBox.Border.Class = "TextBoxBorder";
            this.passLBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passLBox.ForeColor = System.Drawing.Color.White;
            this.passLBox.Location = new System.Drawing.Point(49, 112);
            this.passLBox.Name = "passLBox";
            this.passLBox.Size = new System.Drawing.Size(113, 20);
            this.passLBox.TabIndex = 2;
            this.passLBox.UseSystemPasswordChar = true;
            this.passLBox.WatermarkText = "Password";
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CanCustomize = false;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.White;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTabItem1,
            this.metroTabItem2});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(0, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.Size = new System.Drawing.Size(210, 227);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 4;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.Text = "metroShell1";
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.pictureBox1);
            this.metroTabPanel1.Controls.Add(this.passLBox);
            this.metroTabPanel1.Controls.Add(this.userLBox);
            this.metroTabPanel1.Controls.Add(this.loginButton);
            this.metroTabPanel1.Controls.Add(this.blue);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(210, 176);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pictureBox1.ForeColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GameSync.Properties.Resources.cloudLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 74);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.blue.ForeColor = System.Drawing.Color.White;
            this.blue.Location = new System.Drawing.Point(0, 0);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(100, 50);
            this.blue.TabIndex = 4;
            this.blue.TabStop = false;
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Controls.Add(this.registerButton);
            this.metroTabPanel2.Controls.Add(this.cPassRBox);
            this.metroTabPanel2.Controls.Add(this.passRBox);
            this.metroTabPanel2.Controls.Add(this.emailBox);
            this.metroTabPanel2.Controls.Add(this.userRBox);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(210, 176);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.registerButton.Location = new System.Drawing.Point(67, 129);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "REGISTER";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cPassRBox
            // 
            this.cPassRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.cPassRBox.Border.Class = "TextBoxBorder";
            this.cPassRBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cPassRBox.ForeColor = System.Drawing.Color.White;
            this.cPassRBox.Location = new System.Drawing.Point(43, 76);
            this.cPassRBox.Name = "cPassRBox";
            this.cPassRBox.Size = new System.Drawing.Size(125, 20);
            this.cPassRBox.TabIndex = 7;
            this.cPassRBox.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.cPassRBox, this.compareValidator1);
            this.cPassRBox.WatermarkText = "Confirm Password";
            // 
            // passRBox
            // 
            this.passRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.passRBox.Border.Class = "TextBoxBorder";
            this.passRBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passRBox.ForeColor = System.Drawing.Color.White;
            this.passRBox.Location = new System.Drawing.Point(43, 50);
            this.passRBox.Name = "passRBox";
            this.passRBox.Size = new System.Drawing.Size(125, 20);
            this.passRBox.TabIndex = 6;
            this.passRBox.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator3(this.passRBox, this.regularExpressionValidator3);
            this.passRBox.WatermarkText = "Password";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.emailBox.Border.Class = "TextBoxBorder";
            this.emailBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(43, 103);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(125, 20);
            this.emailBox.TabIndex = 8;
            this.superValidator1.SetValidator1(this.emailBox, this.regularExpressionValidator1);
            this.emailBox.WatermarkText = "E-Mail";
            // 
            // userRBox
            // 
            this.userRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.userRBox.Border.Class = "TextBoxBorder";
            this.userRBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userRBox.ForeColor = System.Drawing.Color.White;
            this.highlighter1.SetHighlightColor(this.userRBox, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            this.userRBox.Location = new System.Drawing.Point(43, 24);
            this.userRBox.Name = "userRBox";
            this.userRBox.Size = new System.Drawing.Size(125, 20);
            this.userRBox.TabIndex = 5;
            this.superValidator1.SetValidator1(this.userRBox, this.requiredFieldValidator1);
            this.superValidator1.SetValidator2(this.userRBox, this.regularExpressionValidator2);
            this.userRBox.WatermarkText = "Username";
            // 
            // metroTabItem1
            // 
            this.metroTabItem1.Checked = true;
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&LOGIN";
            this.metroTabItem1.Click += new System.EventHandler(this.metroTabItem1_Click);
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&REGISTER";
            this.metroTabItem2.Click += new System.EventHandler(this.metroTabItem2_Click);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            this.superValidator1.CustomValidatorValidateValue += new DevComponents.DotNetBar.Validator.ValidateValueEventHandler(this.customValidator1_ValidateValue);
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.passRBox;
            this.compareValidator1.ErrorMessage = "Your passwords do not match.";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator3
            // 
            this.regularExpressionValidator3.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator3.ValidationExpression = "\\S{6,6}";
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
    "})$";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "You must enter a username.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "\\S{5,5}";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(43))))));
            // 
            // Form1
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 228);
            this.Controls.Add(this.metroShell1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            this.metroTabPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX loginButton;
        private DevComponents.DotNetBar.Controls.TextBoxX userLBox;
        private DevComponents.DotNetBar.Controls.TextBoxX passLBox;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX emailBox;
        private DevComponents.DotNetBar.Controls.TextBoxX userRBox;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX passRBox;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX cPassRBox;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.ButtonX registerButton;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox blue;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}

