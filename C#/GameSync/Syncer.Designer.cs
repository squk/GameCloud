namespace GameSync
{
    partial class Syncer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Syncer));
            this.localGamesTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.refreshButton = new DevComponents.DotNetBar.ButtonX();
            this.addGame = new DevComponents.DotNetBar.ButtonX();
            this.cancelB = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.syncButton = new DevComponents.DotNetBar.ButtonX();
            this.detailLabel = new DevComponents.DotNetBar.LabelX();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.statusLabel = new DevComponents.DotNetBar.LabelX();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.restoreTab = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.serverGamesTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.cancelR = new DevComponents.DotNetBar.ButtonX();
            this.serverLabel = new DevComponents.DotNetBar.LabelX();
            this.downloadButton = new DevComponents.DotNetBar.ButtonX();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.deleteGameButton = new DevComponents.DotNetBar.ButtonX();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabItem1 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabItem2 = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.progressBarX2 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            ((System.ComponentModel.ISupportInitialize)(this.localGamesTree)).BeginInit();
            this.metroStatusBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverGamesTree)).BeginInit();
            this.metroShell1.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            this.metroTabPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // localGamesTree
            // 
            this.localGamesTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.localGamesTree.AllowDrop = true;
            this.localGamesTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.localGamesTree.BackgroundStyle.Class = "TreeBorderKey";
            this.localGamesTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.localGamesTree.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.localGamesTree.ForeColor = System.Drawing.Color.White;
            this.localGamesTree.Location = new System.Drawing.Point(15, 28);
            this.localGamesTree.Name = "localGamesTree";
            this.localGamesTree.NodesConnector = this.nodeConnector1;
            this.localGamesTree.NodeStyle = this.elementStyle1;
            this.localGamesTree.PathSeparator = ";";
            this.localGamesTree.Size = new System.Drawing.Size(267, 278);
            this.localGamesTree.Styles.Add(this.elementStyle1);
            this.localGamesTree.TabIndex = 0;
            this.localGamesTree.Text = "advTree1";
            this.localGamesTree.SelectedIndexChanged += new System.EventHandler(this.localGamesTree_SelectedIndexChanged);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.Color.White;
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.refreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.refreshButton.Location = new System.Drawing.Point(288, 254);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(84, 23);
            this.refreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "REFRESH LIST";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // addGame
            // 
            this.addGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addGame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addGame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.addGame.Location = new System.Drawing.Point(288, 283);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(84, 23);
            this.addGame.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addGame.TabIndex = 11;
            this.addGame.Text = "ADD GAME";
            this.addGame.Click += new System.EventHandler(this.addGame_Click);
            // 
            // cancelB
            // 
            this.cancelB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancelB.Location = new System.Drawing.Point(288, 72);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(84, 23);
            this.cancelB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelB.TabIndex = 10;
            this.cancelB.Text = "CANCEL";
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(15, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "DETECTED GAMES";
            // 
            // syncButton
            // 
            this.syncButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.syncButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.syncButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.syncButton.Location = new System.Drawing.Point(288, 32);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(84, 34);
            this.syncButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.syncButton.TabIndex = 5;
            this.syncButton.Text = "SYNC TO SERVER";
            this.syncButton.Tooltip = "Will compress, encrypt, and upload the \r\nselected game saves to the Game Cloud\r\n " +
    "server. ";
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // detailLabel
            // 
            this.detailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.detailLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.detailLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.detailLabel.ForeColor = System.Drawing.Color.White;
            this.detailLabel.Location = new System.Drawing.Point(15, 370);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(324, 31);
            this.detailLabel.TabIndex = 15;
            this.detailLabel.Text = "Size : ";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.BeginGroup = true;
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Controls.Add(this.statusLabel);
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.White;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 416);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(378, 22);
            this.metroStatusBar1.TabIndex = 1;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.statusLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(6, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(366, 23);
            this.statusLabel.TabIndex = 23;
            this.statusLabel.Text = "READY";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.statusLabel;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // progressBarX1
            // 
            this.progressBarX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.ForeColor = System.Drawing.Color.White;
            this.progressBarX1.Location = new System.Drawing.Point(0, 407);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(378, 8);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX1.TabIndex = 16;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // restoreTab
            // 
            this.restoreTab.Checked = true;
            this.restoreTab.Name = "restoreTab";
            this.restoreTab.Text = "&RESTORE";
            this.restoreTab.Click += new System.EventHandler(this.restoreTab_Click);
            // 
            // serverGamesTree
            // 
            this.serverGamesTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.serverGamesTree.AllowDrop = true;
            this.serverGamesTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.serverGamesTree.BackgroundStyle.Class = "TreeBorderKey";
            this.serverGamesTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serverGamesTree.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.serverGamesTree.ForeColor = System.Drawing.Color.White;
            this.serverGamesTree.Location = new System.Drawing.Point(15, 28);
            this.serverGamesTree.Name = "serverGamesTree";
            this.serverGamesTree.NodesConnector = this.nodeConnector2;
            this.serverGamesTree.NodeStyle = this.elementStyle2;
            this.serverGamesTree.PathSeparator = ";";
            this.serverGamesTree.Size = new System.Drawing.Size(267, 278);
            this.serverGamesTree.Styles.Add(this.elementStyle2);
            this.serverGamesTree.TabIndex = 17;
            this.serverGamesTree.Text = "advTree1";
            this.serverGamesTree.SelectedIndexChanged += new System.EventHandler(this.serverListBox_SelectedIndexChanged);
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.Color.White;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonX2.Location = new System.Drawing.Point(288, 283);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(84, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 21;
            this.buttonX2.Text = "DELETE SAVE";
            this.buttonX2.Click += new System.EventHandler(this.deleteFromServer_Click);
            // 
            // cancelR
            // 
            this.cancelR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cancelR.Location = new System.Drawing.Point(288, 72);
            this.cancelR.Name = "cancelR";
            this.cancelR.Size = new System.Drawing.Size(84, 23);
            this.cancelR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelR.TabIndex = 20;
            this.cancelR.Text = "CANCEL";
            this.cancelR.Click += new System.EventHandler(this.cancelR_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.serverLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serverLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.serverLabel.ForeColor = System.Drawing.Color.White;
            this.serverLabel.Location = new System.Drawing.Point(15, 7);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(163, 23);
            this.serverLabel.TabIndex = 19;
            this.serverLabel.Text = "GAMES ON SERVER";
            // 
            // downloadButton
            // 
            this.downloadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.downloadButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.downloadButton.Location = new System.Drawing.Point(288, 32);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(84, 34);
            this.downloadButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.downloadButton.TabIndex = 18;
            this.downloadButton.Text = "DOWNLOAD FROM SERVER";
            this.downloadButton.Tooltip = "Will download, de-crypt, and decompress the \r\nselected game saves from the Game C" +
    "loud\r\n server. ";
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
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
            this.metroShell1.HelpButtonText = "HELP";
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTabItem1,
            this.metroTabItem2});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Segoe UI Semibold", 7F);
            this.metroShell1.Location = new System.Drawing.Point(0, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.Size = new System.Drawing.Size(378, 363);
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
            this.metroShell1.TabIndex = 22;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.UseCustomizeDialog = false;
            this.metroShell1.SettingsButtonClick += new System.EventHandler(this.settingsButton_Click);
            this.metroShell1.HelpButtonClick += new System.EventHandler(this.helpButton_Click);
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.deleteGameButton);
            this.metroTabPanel1.Controls.Add(this.localGamesTree);
            this.metroTabPanel1.Controls.Add(this.syncButton);
            this.metroTabPanel1.Controls.Add(this.labelX1);
            this.metroTabPanel1.Controls.Add(this.cancelB);
            this.metroTabPanel1.Controls.Add(this.addGame);
            this.metroTabPanel1.Controls.Add(this.refreshButton);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(378, 312);
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
            // deleteGameButton
            // 
            this.deleteGameButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.deleteGameButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.deleteGameButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteGameButton.Location = new System.Drawing.Point(288, 225);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(84, 23);
            this.deleteGameButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteGameButton.TabIndex = 13;
            this.deleteGameButton.Text = "DELETE";
            this.deleteGameButton.Visible = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Controls.Add(this.serverGamesTree);
            this.metroTabPanel2.Controls.Add(this.downloadButton);
            this.metroTabPanel2.Controls.Add(this.buttonX2);
            this.metroTabPanel2.Controls.Add(this.serverLabel);
            this.metroTabPanel2.Controls.Add(this.cancelR);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(378, 312);
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
            // metroTabItem1
            // 
            this.metroTabItem1.Checked = true;
            this.metroTabItem1.Name = "metroTabItem1";
            this.metroTabItem1.Panel = this.metroTabPanel1;
            this.metroTabItem1.Text = "&BACKUP";
            this.metroTabItem1.Click += new System.EventHandler(this.backupTab_Click);
            // 
            // metroTabItem2
            // 
            this.metroTabItem2.Name = "metroTabItem2";
            this.metroTabItem2.Panel = this.metroTabPanel2;
            this.metroTabItem2.Text = "&RESTORE";
            this.metroTabItem2.Click += new System.EventHandler(this.restoreTab_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(43))))));
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "buttonItem2";
            // 
            // progressBarX2
            // 
            this.progressBarX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            // 
            // 
            // 
            this.progressBarX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX2.ForeColor = System.Drawing.Color.White;
            this.progressBarX2.Location = new System.Drawing.Point(0, 400);
            this.progressBarX2.Name = "progressBarX2";
            this.progressBarX2.Size = new System.Drawing.Size(378, 8);
            this.progressBarX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progressBarX2.TabIndex = 23;
            this.progressBarX2.Text = "progressBarX2";
            this.progressBarX2.Visible = false;
            // 
            // Syncer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 439);
            this.Controls.Add(this.progressBarX2);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.metroStatusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Syncer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syncer";
            this.Load += new System.EventHandler(this.Syncer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localGamesTree)).EndInit();
            this.metroStatusBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverGamesTree)).EndInit();
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            this.metroTabPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX syncButton;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelX detailLabel;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.ButtonX cancelB;
        private DevComponents.DotNetBar.ButtonX addGame;
        private DevComponents.DotNetBar.ButtonX refreshButton;
        private DevComponents.AdvTree.AdvTree localGamesTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Metro.MetroTabItem restoreTab;
        private DevComponents.AdvTree.AdvTree serverGamesTree;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX cancelR;
        private DevComponents.DotNetBar.LabelX serverLabel;
        private DevComponents.DotNetBar.ButtonX downloadButton;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem1;
        private DevComponents.DotNetBar.Metro.MetroTabItem metroTabItem2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.LabelX statusLabel;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonX deleteGameButton;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX2;
    }
}