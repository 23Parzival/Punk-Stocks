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
                MessageBox.Show("Could not create the account:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetBusy(false);

            if (!result.Success)
            {
                MessageBox.Show(result.Error, "Account not created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return;
            }

            MessageBox.Show("Account created! You can now log in.", "Welcome to Punk-Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                validationErrorProvider.SetError(passwordConfirmTextBox, "Passwords do not match.");
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
    }
}
