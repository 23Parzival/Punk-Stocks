namespace Punk_Stocks.Forms
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glossaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.userStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cashStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.marketStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.bottomSeparator = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.glossaryButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.watchlistButton = new System.Windows.Forms.Button();
            this.holdingsButton = new System.Windows.Forms.Button();
            this.marketButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.settingsMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenuItem,
            this.fileSeparator,
            this.logOutMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshMenuItem.Text = "&Refresh Stocks";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // fileSeparator
            // 
            this.fileSeparator.Name = "fileSeparator";
            this.fileSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutMenuItem.Text = "&Log Out";
            this.logOutMenuItem.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeMenuItem,
            this.darkThemeMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "&View";
            // 
            // lightThemeMenuItem
            // 
            this.lightThemeMenuItem.Name = "lightThemeMenuItem";
            this.lightThemeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightThemeMenuItem.Text = "&Light Theme";
            this.lightThemeMenuItem.Click += new System.EventHandler(this.lightThemeMenuItem_Click);
            // 
            // darkThemeMenuItem
            // 
            this.darkThemeMenuItem.Name = "darkThemeMenuItem";
            this.darkThemeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkThemeMenuItem.Text = "&Dark Theme";
            this.darkThemeMenuItem.Click += new System.EventHandler(this.darkThemeMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsMenuItem.Text = "&Settings";
            // 
            // languageMenuItem
            // 
            this.languageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishMenuItem,
            this.frenchMenuItem});
            this.languageMenuItem.Name = "languageMenuItem";
            this.languageMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languageMenuItem.Text = "&Language";
            // 
            // englishMenuItem
            // 
            this.englishMenuItem.Name = "englishMenuItem";
            this.englishMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishMenuItem.Text = "&English";
            this.englishMenuItem.Click += new System.EventHandler(this.englishMenuItem_Click);
            // 
            // frenchMenuItem
            // 
            this.frenchMenuItem.Name = "frenchMenuItem";
            this.frenchMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frenchMenuItem.Text = "&Français";
            this.frenchMenuItem.Click += new System.EventHandler(this.frenchMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glossaryMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "&Help";
            // 
            // glossaryMenuItem
            // 
            this.glossaryMenuItem.Name = "glossaryMenuItem";
            this.glossaryMenuItem.Size = new System.Drawing.Size(180, 22);
            this.glossaryMenuItem.Text = "&Glossary";
            this.glossaryMenuItem.Click += new System.EventHandler(this.glossaryMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userStatusLabel,
            this.statusSeparator1,
            this.cashStatusLabel,
            this.statusSeparator2,
            this.marketStatusLabel,
            this.spacerLabel,
            this.clockLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 678);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.userStatusLabel.Text = "User: -";
            // 
            // statusSeparator1
            // 
            this.statusSeparator1.Name = "statusSeparator1";
            this.statusSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // cashStatusLabel
            // 
            this.cashStatusLabel.Name = "cashStatusLabel";
            this.cashStatusLabel.Size = new System.Drawing.Size(100, 17);
            this.cashStatusLabel.Text = "Cash: $0.00";
            // 
            // statusSeparator2
            // 
            this.statusSeparator2.Name = "statusSeparator2";
            this.statusSeparator2.Size = new System.Drawing.Size(6, 22);
            // 
            // marketStatusLabel
            // 
            this.marketStatusLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.marketStatusLabel.Name = "marketStatusLabel";
            this.marketStatusLabel.Size = new System.Drawing.Size(120, 17);
            this.marketStatusLabel.Text = "● Market: Running x1";
            // 
            // spacerLabel
            // 
            this.spacerLabel.Name = "spacerLabel";
            this.spacerLabel.Size = new System.Drawing.Size(796, 17);
            this.spacerLabel.Spring = true;
            // 
            // clockLabel
            // 
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(50, 17);
            this.clockLabel.Text = "00:00:00";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.sidebarPanel.Controls.Add(this.bottomSeparator);
            this.sidebarPanel.Controls.Add(this.adminButton);
            this.sidebarPanel.Controls.Add(this.glossaryButton);
            this.sidebarPanel.Controls.Add(this.reportsButton);
            this.sidebarPanel.Controls.Add(this.historyButton);
            this.sidebarPanel.Controls.Add(this.watchlistButton);
            this.sidebarPanel.Controls.Add(this.holdingsButton);
            this.sidebarPanel.Controls.Add(this.marketButton);
            this.sidebarPanel.Controls.Add(this.dashboardButton);
            this.sidebarPanel.Controls.Add(this.titleLabel);
            this.sidebarPanel.Controls.Add(this.settingsButton);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 24);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 654);
            this.sidebarPanel.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(0, 610);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(200, 44);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // bottomSeparator
            // 
            this.bottomSeparator.BackColor = System.Drawing.Color.FromArgb(96, 165, 250);
            this.bottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomSeparator.Location = new System.Drawing.Point(0, 565);
            this.bottomSeparator.Name = "bottomSeparator";
            this.bottomSeparator.Size = new System.Drawing.Size(200, 1);
            this.bottomSeparator.TabIndex = 10;
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Location = new System.Drawing.Point(0, 566);
            this.adminButton.Name = "adminButton";
            this.adminButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.adminButton.Size = new System.Drawing.Size(200, 44);
            this.adminButton.TabIndex = 8;
            this.adminButton.Text = "Admin";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // glossaryButton
            // 
            this.glossaryButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.glossaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glossaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.glossaryButton.FlatAppearance.BorderSize = 0;
            this.glossaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.glossaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.glossaryButton.ForeColor = System.Drawing.Color.White;
            this.glossaryButton.Location = new System.Drawing.Point(0, 334);
            this.glossaryButton.Name = "glossaryButton";
            this.glossaryButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.glossaryButton.Size = new System.Drawing.Size(200, 44);
            this.glossaryButton.TabIndex = 7;
            this.glossaryButton.Text = "Glossary";
            this.glossaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glossaryButton.UseVisualStyleBackColor = false;
            this.glossaryButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.Location = new System.Drawing.Point(0, 290);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.reportsButton.Size = new System.Drawing.Size(200, 44);
            this.reportsButton.TabIndex = 6;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(0, 246);
            this.historyButton.Name = "historyButton";
            this.historyButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.historyButton.Size = new System.Drawing.Size(200, 44);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "History";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // watchlistButton
            // 
            this.watchlistButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.watchlistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchlistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.watchlistButton.FlatAppearance.BorderSize = 0;
            this.watchlistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.watchlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistButton.ForeColor = System.Drawing.Color.White;
            this.watchlistButton.Location = new System.Drawing.Point(0, 202);
            this.watchlistButton.Name = "watchlistButton";
            this.watchlistButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.watchlistButton.Size = new System.Drawing.Size(200, 44);
            this.watchlistButton.TabIndex = 4;
            this.watchlistButton.Text = "Watchlist";
            this.watchlistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.watchlistButton.UseVisualStyleBackColor = false;
            this.watchlistButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // holdingsButton
            // 
            this.holdingsButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.holdingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holdingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.holdingsButton.FlatAppearance.BorderSize = 0;
            this.holdingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.holdingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holdingsButton.ForeColor = System.Drawing.Color.White;
            this.holdingsButton.Location = new System.Drawing.Point(0, 158);
            this.holdingsButton.Name = "holdingsButton";
            this.holdingsButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.holdingsButton.Size = new System.Drawing.Size(200, 44);
            this.holdingsButton.TabIndex = 3;
            this.holdingsButton.Text = "Holdings";
            this.holdingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.holdingsButton.UseVisualStyleBackColor = false;
            this.holdingsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // marketButton
            // 
            this.marketButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.marketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marketButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketButton.FlatAppearance.BorderSize = 0;
            this.marketButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.marketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marketButton.ForeColor = System.Drawing.Color.White;
            this.marketButton.Location = new System.Drawing.Point(0, 114);
            this.marketButton.Name = "marketButton";
            this.marketButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.marketButton.Size = new System.Drawing.Size(200, 44);
            this.marketButton.TabIndex = 2;
            this.marketButton.Text = "Market";
            this.marketButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.marketButton.UseVisualStyleBackColor = false;
            this.marketButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(0, 70);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(200, 44);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 70);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PUNK-STOCKS";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 24);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(900, 654);
            this.contentPanel.TabIndex = 3;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punk-Stocks";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileSeparator;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glossaryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel userStatusLabel;
        private System.Windows.Forms.ToolStripSeparator statusSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel cashStatusLabel;
        private System.Windows.Forms.ToolStripSeparator statusSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel marketStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel spacerLabel;
        private System.Windows.Forms.ToolStripStatusLabel clockLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button marketButton;
        private System.Windows.Forms.Button holdingsButton;
        private System.Windows.Forms.Button watchlistButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button glossaryButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Panel bottomSeparator;
    }
}
