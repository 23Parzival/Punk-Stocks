namespace Punk_Stocks
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            promptLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            exitButton = new Button();
            createUserLinkLabel = new LinkLabel();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            promptLabel.Location = new Point(53, 79);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(436, 31);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Log In using your Punk-Stocks account:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(140, 132);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(82, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(140, 165);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(140, 209);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(125, 29);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(272, 209);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(125, 29);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // createUserLinkLabel
            // 
            createUserLinkLabel.AutoSize = true;
            createUserLinkLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createUserLinkLabel.Location = new Point(140, 241);
            createUserLinkLabel.Name = "createUserLinkLabel";
            createUserLinkLabel.Size = new Size(262, 17);
            createUserLinkLabel.TabIndex = 5;
            createUserLinkLabel.TabStop = true;
            createUserLinkLabel.Text = "Not a user? Click here to create an account.";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(228, 163);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(169, 27);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(228, 130);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(169, 27);
            usernameTextBox.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 353);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(createUserLinkLabel);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(promptLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(560, 400);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punk-Stocks Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button exitButton;
        private LinkLabel createUserLinkLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}
