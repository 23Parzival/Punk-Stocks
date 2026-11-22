using Punk_Stocks.Forms;
using Punk_Stocks.Models.Enums;
using Punk_Stocks.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class SettingsPanel : UserControl, IContentPanel
    {
        private readonly AuthService authService = new AuthService();

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

            usernameGroupBox.Text = LanguageManager.Get("Settings_ChangeUsername");
            newUsernameLabel.Text = LanguageManager.Get("Settings_NewUsername");
            changeUsernameButton.Text = LanguageManager.Get("Settings_ChangeUsername");

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
            MainForm mainForm = FindForm() as MainForm;
            if (mainForm != null && languageComboBox.SelectedIndex >= 0)
                mainForm.ChangeLanguage((AppLanguage)languageComboBox.SelectedIndex);
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change theme. may not end up adding this feature
        }

        private async void changeUsernameButton_Click(object sender, EventArgs e)
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            string newUsername = newUsernameTextBox.Text;
            changeUsernameButton.Enabled = false;

            AuthResult result;
            try
            {
                result = await Task.Run(() => authService.ChangeUsername(user.UserID, newUsername));
            }
            catch (Exception ex)
            {
                ShowSaveError(ex);
                return;
            }
            finally
            {
                changeUsernameButton.Enabled = true;
            }

            if (!result.Success)
            {
                MessageBox.Show(result.Error, LanguageManager.Get("Settings_ChangeUsername"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.Username = result.User.Username;
            newUsernameTextBox.Clear();

            //status bar shows the username
            MainForm mainForm = FindForm() as MainForm;
            if (mainForm != null)
                mainForm.RefreshStatusBar();

            MessageBox.Show(LanguageManager.Format("Settings_UsernameChanged", user.Username), LanguageManager.Get("Settings_ChangeUsername"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void changePasswordButton_Click(object sender, EventArgs e)
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show(LanguageManager.Get("Validation_PasswordMismatch"), LanguageManager.Get("Settings_ChangePassword"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentPassword = currentPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            changePasswordButton.Enabled = false;

            AuthResult result;
            try
            {
                result = await Task.Run(() => authService.ChangePassword(user.UserID, currentPassword, newPassword));
            }
            catch (Exception ex)
            {
                ShowSaveError(ex);
                return;
            }
            finally
            {
                changePasswordButton.Enabled = true;
            }

            if (!result.Success)
            {
                MessageBox.Show(result.Error, LanguageManager.Get("Settings_ChangePassword"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.PasswordHash = result.User.PasswordHash;
            currentPasswordTextBox.Clear();
            newPasswordTextBox.Clear();
            confirmPasswordTextBox.Clear();

            MessageBox.Show(LanguageManager.Get("Settings_PasswordChanged"), LanguageManager.Get("Settings_ChangePassword"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowSaveError(Exception ex)
        {
            MessageBox.Show(LanguageManager.Get("Error_Save") + "\n" + ex.Message, LanguageManager.Get("Error_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
