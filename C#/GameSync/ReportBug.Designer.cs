namespace GameSync
{
    partial class ReportBug
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.titleBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reportType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bodyText = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.captchaBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.captchaPic = new System.Windows.Forms.PictureBox();
            this.sendButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(310, 64);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Please be as accurate as possible when writing your title/body regardless of if i" +
    "t\'s a suggestion or a bug report. If you got an exception, copy and paste it int" +
    "o this form as well. ";
            this.labelX1.WordWrap = true;
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.titleBox.Border.Class = "TextBoxBorder";
            this.titleBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.titleBox.ForeColor = System.Drawing.Color.White;
            this.titleBox.Location = new System.Drawing.Point(50, 82);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(146, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.WatermarkText = "Title";
            // 
            // reportType
            // 
            this.reportType.DisplayMember = "Text";
            this.reportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reportType.FormattingEnabled = true;
            this.reportType.ItemHeight = 14;
            this.reportType.Location = new System.Drawing.Point(50, 108);
            this.reportType.Name = "reportType";
            this.reportType.Size = new System.Drawing.Size(146, 20);
            this.reportType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.reportType.TabIndex = 3;
            // 
            // bodyText
            // 
            // 
            // 
            // 
            this.bodyText.BackgroundStyle.Class = "RichTextBoxBorder";
            this.bodyText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bodyText.Location = new System.Drawing.Point(50, 134);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(272, 188);
            this.bodyText.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 134);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(32, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Body";
            // 
            // captchaBox
            // 
            this.captchaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.captchaBox.Border.Class = "TextBoxBorder";
            this.captchaBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.captchaBox.ForeColor = System.Drawing.Color.White;
            this.captchaBox.Location = new System.Drawing.Point(50, 328);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(146, 20);
            this.captchaBox.TabIndex = 6;
            this.captchaBox.WatermarkText = "Captcha";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(202, 328);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(120, 20);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Give me a new captcha";
            this.buttonX1.Click += new System.EventHandler(this.newCaptcha_Click);
            // 
            // captchaPic
            // 
            this.captchaPic.Location = new System.Drawing.Point(52, 354);
            this.captchaPic.Name = "captchaPic";
            this.captchaPic.Size = new System.Drawing.Size(265, 71);
            this.captchaPic.TabIndex = 8;
            this.captchaPic.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sendButton.Location = new System.Drawing.Point(242, 431);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 457);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.captchaPic);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.reportType);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "ReportBug";
            this.Text = "ReportBug";
            ((System.ComponentModel.ISupportInitialize)(this.captchaPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX titleBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx reportType;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx bodyText;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX captchaBox;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.PictureBox captchaPic;
        private DevComponents.DotNetBar.ButtonX sendButton;
    }
}