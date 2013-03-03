namespace GameSync
{
    partial class Updater
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
            this.updateText = new DevComponents.DotNetBar.LabelX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.SuspendLayout();
            // 
            // updateText
            // 
            // 
            // 
            // 
            this.updateText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.updateText.Location = new System.Drawing.Point(12, -7);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(260, 23);
            this.updateText.TabIndex = 0;
            this.updateText.Text = "Updating...";
            this.updateText.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(12, 22);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(260, 23);
            this.progressBarX1.TabIndex = 1;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 55);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.progressBarX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Updater_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX updateText;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
    }
}