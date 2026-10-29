using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (HasValidationErrors())
                return;
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
