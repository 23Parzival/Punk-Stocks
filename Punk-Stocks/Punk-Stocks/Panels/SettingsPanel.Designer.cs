namespace Punk_Stocks.Panels
{
    partial class SettingsPanel
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.usernameGroupBox = new System.Windows.Forms.GroupBox();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.newUsernameTextBox = new System.Windows.Forms.TextBox();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.preferencesGroupBox = new System.Windows.Forms.GroupBox();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.themeLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.usernameGroupBox.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.preferencesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(900, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Settings";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bodyPanel
            // 
            this.bodyPanel.AutoScroll = true;
            this.bodyPanel.Controls.Add(this.usernameGroupBox);
            this.bodyPanel.Controls.Add(this.passwordGroupBox);
            this.bodyPanel.Controls.Add(this.preferencesGroupBox);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 60);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(900, 594);
            this.bodyPanel.TabIndex = 1;
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Controls.Add(this.changeUsernameButton);
            this.usernameGroupBox.Controls.Add(this.newUsernameTextBox);
            this.usernameGroupBox.Controls.Add(this.newUsernameLabel);
            this.usernameGroupBox.Location = new System.Drawing.Point(15, 132);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Size = new System.Drawing.Size(420, 113);
            this.usernameGroupBox.TabIndex = 2;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Change Username";
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.Location = new System.Drawing.Point(250, 65);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(150, 32);
            this.changeUsernameButton.TabIndex = 6;
            this.changeUsernameButton.Text = "Change username";
            this.changeUsernameButton.UseVisualStyleBackColor = true;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // newUsernameTextBox
            // 
            this.newUsernameTextBox.Location = new System.Drawing.Point(160, 28);
            this.newUsernameTextBox.Name = "newUsernameTextBox";
            this.newUsernameTextBox.Size = new System.Drawing.Size(240, 20);
            this.newUsernameTextBox.TabIndex = 3;
            this.newUsernameTextBox.UseSystemPasswordChar = true;
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Location = new System.Drawing.Point(15, 31);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(78, 13);
            this.newUsernameLabel.TabIndex = 2;
            this.newUsernameLabel.Text = "New username";
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.changePasswordButton);
            this.passwordGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.passwordGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.passwordGroupBox.Controls.Add(this.newPasswordTextBox);
            this.passwordGroupBox.Controls.Add(this.newPasswordLabel);
            this.passwordGroupBox.Controls.Add(this.currentPasswordTextBox);
            this.passwordGroupBox.Controls.Add(this.currentPasswordLabel);
            this.passwordGroupBox.Location = new System.Drawing.Point(15, 264);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(420, 190);
            this.passwordGroupBox.TabIndex = 1;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Change password";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(250, 141);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(150, 32);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(160, 104);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(240, 20);
            this.confirmPasswordTextBox.TabIndex = 5;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(15, 107);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(90, 13);
            this.confirmPasswordLabel.TabIndex = 4;
            this.confirmPasswordLabel.Text = "Confirm password";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(160, 67);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(240, 20);
            this.newPasswordTextBox.TabIndex = 3;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(15, 70);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(77, 13);
            this.newPasswordLabel.TabIndex = 2;
            this.newPasswordLabel.Text = "New password";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.Location = new System.Drawing.Point(160, 30);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(240, 20);
            this.currentPasswordTextBox.TabIndex = 1;
            this.currentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Location = new System.Drawing.Point(15, 33);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(89, 13);
            this.currentPasswordLabel.TabIndex = 0;
            this.currentPasswordLabel.Text = "Current password";
            // 
            // preferencesGroupBox
            // 
            this.preferencesGroupBox.Controls.Add(this.themeComboBox);
            this.preferencesGroupBox.Controls.Add(this.themeLabel);
            this.preferencesGroupBox.Controls.Add(this.languageComboBox);
            this.preferencesGroupBox.Controls.Add(this.languageLabel);
            this.preferencesGroupBox.Location = new System.Drawing.Point(15, 5);
            this.preferencesGroupBox.Name = "preferencesGroupBox";
            this.preferencesGroupBox.Size = new System.Drawing.Size(420, 110);
            this.preferencesGroupBox.TabIndex = 0;
            this.preferencesGroupBox.TabStop = false;
            this.preferencesGroupBox.Text = "Preferences";
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(160, 67);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(240, 21);
            this.themeComboBox.TabIndex = 3;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Location = new System.Drawing.Point(15, 70);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(40, 13);
            this.themeLabel.TabIndex = 2;
            this.themeLabel.Text = "Theme";
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Français"});
            this.languageComboBox.Location = new System.Drawing.Point(160, 30);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(240, 21);
            this.languageComboBox.TabIndex = 1;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(15, 33);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "Language";
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.bodyPanel.ResumeLayout(false);
            this.usernameGroupBox.ResumeLayout(false);
            this.usernameGroupBox.PerformLayout();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.preferencesGroupBox.ResumeLayout(false);
            this.preferencesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.GroupBox preferencesGroupBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.GroupBox usernameGroupBox;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.TextBox newUsernameTextBox;
        private System.Windows.Forms.Label newUsernameLabel;
    }
}
