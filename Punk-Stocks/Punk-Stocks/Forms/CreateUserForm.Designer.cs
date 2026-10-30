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
            this.components = new System.ComponentModel.Container();
            this.promptLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.backButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.cashBalanceTextBox = new System.Windows.Forms.TextBox();
            this.cashBalanceLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.validationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(29, 36);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(419, 64);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter your information to create a new Punk-Stocks account:";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(203, 170);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 20);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordConfirmTextBox
            // 
            this.passwordConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordConfirmTextBox.Location = new System.Drawing.Point(203, 199);
            this.passwordConfirmTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(148, 20);
            this.passwordConfirmTextBox.TabIndex = 13;
            this.passwordConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.CausesValidation = false;
            this.loginLinkLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLinkLabel.Location = new System.Drawing.Point(147, 267);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(184, 13);
            this.loginLinkLabel.TabIndex = 12;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Already a user? Click here to login.";
            // 
            // backButton
            // 
            this.backButton.CausesValidation = false;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Location = new System.Drawing.Point(241, 236);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 29);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(125, 236);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(109, 29);
            this.createAccountButton.TabIndex = 10;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(84, 201);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmPasswordLabel.TabIndex = 9;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(125, 171);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Location = new System.Drawing.Point(203, 112);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(148, 20);
            this.usernameTextBox.TabIndex = 18;
            // 
            // cashBalanceTextBox
            // 
            this.cashBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashBalanceTextBox.Location = new System.Drawing.Point(203, 141);
            this.cashBalanceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashBalanceTextBox.Name = "cashBalanceTextBox";
            this.cashBalanceTextBox.Size = new System.Drawing.Size(148, 20);
            this.cashBalanceTextBox.TabIndex = 17;
            // 
            // cashBalanceLabel
            // 
            this.cashBalanceLabel.AutoSize = true;
            this.cashBalanceLabel.Location = new System.Drawing.Point(67, 143);
            this.cashBalanceLabel.Name = "cashBalanceLabel";
            this.cashBalanceLabel.Size = new System.Drawing.Size(115, 13);
            this.cashBalanceLabel.TabIndex = 16;
            this.cashBalanceLabel.Text = "Starting Cash Balance:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(125, 113);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 15;
            this.usernameLabel.Text = "Username: ";
            // 
            // validationErrorProvider
            // 
            this.validationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validationErrorProvider.ContainerControl = this;
            // 
            // CreateUserForm
            // 
            this.AcceptButton = this.createAccountButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(476, 335);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.cashBalanceTextBox);
            this.Controls.Add(this.cashBalanceLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordConfirmTextBox);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.promptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(492, 310);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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