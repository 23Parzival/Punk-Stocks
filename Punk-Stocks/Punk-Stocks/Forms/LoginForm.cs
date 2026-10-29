using Punk_Stocks.Forms;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string passwd = passwordTextBox.Text;


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
        }
    }
}
