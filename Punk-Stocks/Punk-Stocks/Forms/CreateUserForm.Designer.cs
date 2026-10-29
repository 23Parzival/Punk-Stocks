using System.Drawing;
using System.Windows.Forms;
namespace Punk_Stocks.Forms
{
    partial class CreateUserForm
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
            components = new System.ComponentModel.Container();
            promptLabel = new Label();
            passwordTextBox = new TextBox();
            passwordConfirmTextBox = new TextBox();
            loginLinkLabel = new LinkLabel();
            backButton = new Button();
            createAccountButton = new Button();
            confirmPasswordLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            cashBalanceTextBox = new TextBox();
            cashBalanceLabel = new Label();
            usernameLabel = new Label();
            validationErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            promptLabel.Location = new Point(29, 36);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(419, 64);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Enter your information to create a new Punk-Stocks account:";
            promptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(203, 170);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(148, 23);
            passwordTextBox.TabIndex = 14;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.Validating += passwordTextBox_Validating;
            // 
            // passwordConfirmTextBox
            // 
            passwordConfirmTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordConfirmTextBox.Location = new Point(203, 199);
            passwordConfirmTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            passwordConfirmTextBox.Size = new Size(148, 23);
            passwordConfirmTextBox.TabIndex = 13;
            passwordConfirmTextBox.UseSystemPasswordChar = true;
            passwordConfirmTextBox.Validating += passwordConfirmTextBox_Validating;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.CausesValidation = false;
            loginLinkLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkLabel.Location = new Point(147, 267);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(184, 13);
            loginLinkLabel.TabIndex = 12;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Already a user? Click here to login.";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // backButton
            // 
            backButton.CausesValidation = false;
            backButton.Location = new Point(241, 236);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(109, 29);
            backButton.TabIndex = 11;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(125, 236);
            createAccountButton.Margin = new Padding(3, 2, 3, 2);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(109, 29);
            createAccountButton.TabIndex = 10;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(84, 201);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(107, 15);
            confirmPasswordLabel.TabIndex = 9;
            confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(125, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(203, 112);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(148, 23);
            usernameTextBox.TabIndex = 18;
            usernameTextBox.Validating += usernameTextBox_Validating;
            // 
            // cashBalanceTextBox
            // 
            cashBalanceTextBox.BorderStyle = BorderStyle.FixedSingle;
            cashBalanceTextBox.Location = new Point(203, 141);
            cashBalanceTextBox.Margin = new Padding(3, 2, 3, 2);
            cashBalanceTextBox.Name = "cashBalanceTextBox";
            cashBalanceTextBox.Size = new Size(148, 23);
            cashBalanceTextBox.TabIndex = 17;
            cashBalanceTextBox.Validating += cashBalanceTextBox_Validating;
            // 
            // cashBalanceLabel
            // 
            cashBalanceLabel.AutoSize = true;
            cashBalanceLabel.Location = new Point(67, 143);
            cashBalanceLabel.Name = "cashBalanceLabel";
            cashBalanceLabel.Size = new Size(124, 15);
            cashBalanceLabel.TabIndex = 16;
            cashBalanceLabel.Text = "Starting Cash Balance:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(125, 113);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(66, 15);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username: ";
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            validationErrorProvider.ContainerControl = this;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(476, 335);
            Controls.Add(usernameTextBox);
            Controls.Add(cashBalanceTextBox);
            Controls.Add(cashBalanceLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordConfirmTextBox);
            Controls.Add(loginLinkLabel);
            Controls.Add(backButton);
            Controls.Add(createAccountButton);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(passwordLabel);
            Controls.Add(promptLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(492, 310);
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUserForm";
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private TextBox passwordTextBox;
        private TextBox passwordConfirmTextBox;
        private LinkLabel loginLinkLabel;
        private Button backButton;
        private Button createAccountButton;
        private Label confirmPasswordLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox cashBalanceTextBox;
        private Label cashBalanceLabel;
        private Label usernameLabel;
        private ErrorProvider validationErrorProvider;
    }
}