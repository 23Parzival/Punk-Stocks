using Punk_Stocks.Models.Enums;
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
            ApplyLanguage();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LanguageManager.LanguageChanged += LanguageManager_LanguageChanged;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LanguageManager.LanguageChanged -= LanguageManager_LanguageChanged;
        }

        private void ApplyLanguage()
        {
            Text = LanguageManager.Get("Login_Title");
            promptLabel.Text = LanguageManager.Get("Login_Prompt");
            usernameLabel.Text = LanguageManager.Get("Common_Username");
            passwordLabel.Text = LanguageManager.Get("Common_Password");
            loginButton.Text = LanguageManager.Get("Login_Button");
            exitButton.Text = LanguageManager.Get("Login_Exit");
            createUserLinkLabel.Text = LanguageManager.Get("Login_CreateLink");
            changeLanguageLinkLabel.Text = LanguageManager.Current == AppLanguage.English ? "🌐 Français" : "🌐 English";
        }

        private void LanguageManager_LanguageChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
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
                MessageBox.Show(LanguageManager.Get("Login_Error") + "\n" + ex.Message, LanguageManager.Get("Error_Title"),MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetBusy(false);

            if (!result.Success)
            {
                MessageBox.Show(result.Error, LanguageManager.Get("Login_FailedTitle"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }

            passwordTextBox.Clear();
            SessionManager.SignIn(result.User);
            LanguageManager.SetLanguage((AppLanguage)result.User.Language);

            SetBusy(true);
            try
            {
                await Task.Run(() => StockSeeder.SeedIfEmpty());
            }
            catch (Exception ex)
            {
                SetBusy(false);
                SessionManager.SignOut();
                MessageBox.Show(LanguageManager.Get("Login_SeedError") + "\n" + ex.Message, LanguageManager.Get("Error_Title"),MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetBusy(false);

            OpenMainForm();
        }

        private void OpenMainForm()
        {
            Hide();
            bool logOut;
            using (var main = new MainForm())
            {
                main.ShowDialog();
                logOut = main.LogOutRequested;
            }
            SessionManager.SignOut();

            if (logOut)
            {
                ApplyLanguage();
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

        private void changeLanguageLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LanguageManager.SetLanguage(LanguageManager.Current == AppLanguage.English ? AppLanguage.French : AppLanguage.English);
        }
    }
}
