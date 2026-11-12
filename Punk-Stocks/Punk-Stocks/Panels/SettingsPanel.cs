using Punk_Stocks.Services;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class SettingsPanel : UserControl, IContentPanel
    {
        public SettingsPanel()
        {
            InitializeComponent();
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Settings");

            preferencesGroupBox.Text = LanguageManager.Get("Settings_Preferences");
            languageLabel.Text = LanguageManager.Get("Settings_Language");
            themeLabel.Text = LanguageManager.Get("Settings_Theme");

            passwordGroupBox.Text = LanguageManager.Get("Settings_ChangePassword");
            currentPasswordLabel.Text = LanguageManager.Get("Settings_CurrentPassword");
            newPasswordLabel.Text = LanguageManager.Get("Settings_NewPassword");
            confirmPasswordLabel.Text = LanguageManager.Get("Settings_ConfirmPassword");
            changePasswordButton.Text = LanguageManager.Get("Settings_ChangePassword");

            int theme = themeComboBox.SelectedIndex;
            themeComboBox.Items.Clear();
            themeComboBox.Items.Add(LanguageManager.Get("Menu_LightTheme"));
            themeComboBox.Items.Add(LanguageManager.Get("Menu_DarkTheme"));
            themeComboBox.SelectedIndex = theme < 0 ? 0 : theme;

            languageComboBox.SelectedIndex = (int)LanguageManager.Current;
        }

        public void RefreshData()
        {
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change language
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change theme. may not end up adding this feature
        }

        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            //validate and save new username
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //validate and save new password
        }
    }
}
