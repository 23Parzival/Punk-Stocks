using Punk_Stocks.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService authService = new AuthService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string passwd = passwordTextBox.Text;

            SetBusy(true);
            AuthResult result;
            try
            {
                result = await Task.Run(() => authService.Login(username, passwd));
            }
            catch (Exception ex)
            {
                SetBusy(false);
                MessageBox.Show("Could not log in:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetBusy(false);

            if (!result.Success)
            {
                MessageBox.Show(result.Error, "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }

            passwordTextBox.Clear();
            SessionManager.SignIn(result.User);
            OpenMainForm();
        }

        private void OpenMainForm()
        {
            Hide();
            //temp false
            bool logOut = false;
            using (var main = new MainForm())
            {
                main.ShowDialog();
                //logOut = main.LogOutRequested; -> will be true if the user requested to log out from the main form
            }
            SessionManager.SignOut();

            if (logOut)
            {
                Show();
                usernameTextBox.Focus();
            }
            else
            {
                Application.Exit();
            }
        }

        private void SetBusy(bool busy)
        {
            loginButton.Enabled = !busy;
            exitButton.Enabled = !busy;
            createUserLinkLabel.Enabled = !busy;
            usernameTextBox.Enabled = !busy;
            passwordTextBox.Enabled = !busy;
            UseWaitCursor = busy;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var createUserForm = new CreateUserForm())
            {
                if (createUserForm.ShowDialog(this) == DialogResult.OK)
                {
                    usernameTextBox.Text = createUserForm.CreatedUsername;
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
            }
        }
    }
}
