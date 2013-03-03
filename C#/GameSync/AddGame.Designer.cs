namespace GameSync
{
    partial class AddGame
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
            this.addButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.saveBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chooseButton = new DevComponents.DotNetBar.ButtonX();
            this.nameBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(197, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(116, 67);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveBox
            // 
            this.saveBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.saveBox.Border.Class = "TextBoxBorder";
            this.saveBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.saveBox.ForeColor = System.Drawing.Color.White;
            this.saveBox.Location = new System.Drawing.Point(12, 41);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(194, 20);
            this.saveBox.TabIndex = 2;
            this.saveBox.WatermarkText = "Save Game Folder";
            // 
            // chooseButton
            // 
            this.chooseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.chooseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.chooseButton.Location = new System.Drawing.Point(212, 41);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(60, 20);
            this.chooseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chooseButton.TabIndex = 4;
            this.chooseButton.Text = "Choose...";
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.nameBox.Border.Class = "TextBoxBorder";
            this.nameBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(194, 20);
            this.nameBox.TabIndex = 5;
            this.nameBox.WatermarkText = "Game Name";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Custom Game";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX addButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.TextBoxX saveBox;
        private DevComponents.DotNetBar.ButtonX chooseButton;
        private DevComponents.DotNetBar.Controls.TextBoxX nameBox;
    }
}