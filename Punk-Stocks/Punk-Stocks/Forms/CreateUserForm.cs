using Punk_Stocks.Models.Enums;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    public partial class CreateUserForm : Form
    {
        private readonly AuthService authService = new AuthService();

        //so that the username can be accessed from the login form after the user is created
        public string CreatedUsername { get; private set; }

        public CreateUserForm()
        {
            InitializeComponent();
            ApplyLanguage();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            LanguageManager.LanguageChanged += LanguageManager_LanguageChanged;
        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= LanguageManager_LanguageChanged;
        }

        private void LanguageManager_LanguageChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            Text = LanguageManager.Get("CreateUser_Title");
            promptLabel.Text = LanguageManager.Get("CreateUser_Prompt");
            usernameLabel.Text = LanguageManager.Get("Common_Username");
            cashBalanceLabel.Text = LanguageManager.Get("CreateUser_StartingCash");
            passwordLabel.Text = LanguageManager.Get("Common_Password");
            confirmPasswordLabel.Text = LanguageManager.Get("CreateUser_ConfirmPassword");
            createAccountButton.Text = LanguageManager.Get("CreateUser_Create");
            backButton.Text = LanguageManager.Get("CreateUser_Back");
            loginLinkLabel.Text = LanguageManager.Get("CreateUser_LoginLink");
            changeLanguageLinkLabel.Text = LanguageManager.Current == AppLanguage.English ? "🌐 Français" : "🌐 English";
        }

        private async void createAccountButton_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors())
                return;

            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;
            decimal startingCash = Math.Round(decimal.Parse(cashBalanceTextBox.Text), 2);

            SetBusy(true);
            AuthResult result;
            try
            {
                result = await Task.Run(() => authService.Register(username, password, startingCash));
            }
            catch (Exception ex)
            {
                SetBusy(false);
                MessageBox.Show(LanguageManager.Get("CreateUser_Error") + "\n" + ex.Message, LanguageManager.Get("Error_Title"),MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetBusy(false);

            if (!result.Success)
            {
                MessageBox.Show(result.Error, LanguageManager.Get("CreateUser_FailedTitle"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return;
            }

            MessageBox.Show(LanguageManager.Get("CreateUser_Success"), LanguageManager.Get("CreateUser_SuccessTitle"),MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreatedUsername = username;
            DialogResult = DialogResult.OK;
        }

        private void SetBusy(bool busy)
        {
            createAccountButton.Enabled = !busy;
            backButton.Enabled = !busy;
            loginLinkLabel.Enabled = !busy;
            UseWaitCursor = busy;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            validationErrorProvider.SetError(usernameTextBox, ValidationService.ValidateUsername(usernameTextBox.Text) ?? "");
        }

        private void cashBalanceTextBox_Validating(object sender, CancelEventArgs e)
        {
            validationErrorProvider.SetError(cashBalanceTextBox, ValidationService.ValidateStartingCash(cashBalanceTextBox.Text) ?? "");
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            validationErrorProvider.SetError(passwordTextBox, ValidationService.ValidatePassword(passwordTextBox.Text) ?? "");
        }

        private void passwordConfirmTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordConfirmTextBox.Text != passwordTextBox.Text)
                validationErrorProvider.SetError(passwordConfirmTextBox, LanguageManager.Get("Validation_PasswordMismatch"));
            else
                validationErrorProvider.SetError(passwordConfirmTextBox, "");
        }

        private bool HasValidationErrors()
        {
            foreach (Control control in Controls)
            {
                if (validationErrorProvider.GetError(control) != "")
                    return true;
            }
            return false;
        }

        private void changeLanguageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LanguageManager.SetLanguage(LanguageManager.Current == AppLanguage.English ? AppLanguage.French : AppLanguage.English);
        }
    }
}
