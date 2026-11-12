using Punk_Stocks.Models.Enums;
using Punk_Stocks.Panels;
using Punk_Stocks.Repositories;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    public partial class MainForm : Form
    {
        private static readonly Color SidebarColor = Color.FromArgb(30, 30, 46);
        private static readonly Color ActiveColor = Color.FromArgb(99, 102, 241);

        private readonly UserRepository userRepository = new UserRepository();
        private readonly Dictionary<Button, UserControl> panels = new Dictionary<Button, UserControl>();

        private Button activeButton;
        public bool LogOutRequested { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            User user = SessionManager.CurrentUser;
            adminButton.Visible = user.IsAdmin;

            SessionManager.CashChanged += SessionManager_CashChanged;
            LanguageManager.LanguageChanged += LanguageManager_LanguageChanged;

            ApplyLanguage();
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            ShowPanel(dashboardButton);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.CashChanged -= SessionManager_CashChanged;
            LanguageManager.LanguageChanged -= LanguageManager_LanguageChanged;
        }

        private void ApplyLanguage()
        {
            fileMenuItem.Text = LanguageManager.Get("Menu_File");
            refreshMenuItem.Text = LanguageManager.Get("Menu_Refresh");
            logOutMenuItem.Text = LanguageManager.Get("Menu_LogOut");
            exitMenuItem.Text = LanguageManager.Get("Menu_Exit");
            viewMenuItem.Text = LanguageManager.Get("Menu_View");
            lightThemeMenuItem.Text = LanguageManager.Get("Menu_LightTheme");
            darkThemeMenuItem.Text = LanguageManager.Get("Menu_DarkTheme");
            settingsMenuItem.Text = LanguageManager.Get("Menu_Settings");
            languageMenuItem.Text = LanguageManager.Get("Menu_Language");
            helpMenuItem.Text = LanguageManager.Get("Menu_Help");
            glossaryMenuItem.Text = LanguageManager.Get("Menu_Glossary");
            aboutMenuItem.Text = LanguageManager.Get("Menu_About");

            englishMenuItem.Checked = LanguageManager.Current == AppLanguage.English;
            frenchMenuItem.Checked = LanguageManager.Current == AppLanguage.French;

            dashboardButton.Text = LanguageManager.Get("Nav_Dashboard");
            marketButton.Text = LanguageManager.Get("Nav_Market");
            holdingsButton.Text = LanguageManager.Get("Nav_Holdings");
            watchlistButton.Text = LanguageManager.Get("Nav_Watchlist");
            historyButton.Text = LanguageManager.Get("Nav_History");
            reportsButton.Text = LanguageManager.Get("Nav_Reports");
            glossaryButton.Text = LanguageManager.Get("Nav_Glossary");
            adminButton.Text = LanguageManager.Get("Nav_Admin");
            settingsButton.Text = LanguageManager.Get("Nav_Settings");

            RefreshStatusBar();

            foreach (UserControl panel in panels.Values)
                ((IContentPanel)panel).ApplyLanguage();
        }

        private void LanguageManager_LanguageChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        private async void ChangeLanguage(AppLanguage language)
        {
            User user = SessionManager.CurrentUser;
            if (user == null || LanguageManager.Current == language)
                return;

            LanguageManager.SetLanguage(language);
            user.Language = (int)language;

            try
            {
                await Task.Run(() => userRepository.UpdateLanguage(user.UserID, (int)language));
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageManager.Get("Error_Save") + "\n" + ex.Message, LanguageManager.Get("Error_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //status bar
        public void RefreshStatusBar()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            userStatusLabel.Text = LanguageManager.Format("Status_User", user.Username);
            cashStatusLabel.Text = LanguageManager.Format("Status_Cash", user.CashBalance.ToString("C2"));
        }

        private void SessionManager_CashChanged(object sender, EventArgs e)
        {
            RefreshStatusBar();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //sidebar nav
        private void navButton_Click(object sender, EventArgs e)
        {
            ShowPanel((Button)sender);
        }

        private void ShowPanel(Button button)
        {
            SetActiveButton(button);

            UserControl panel;
            if (!panels.TryGetValue(button, out panel))
            {
                panel = CreatePanel(button);
                panel.Dock = DockStyle.Fill;
                panels.Add(button, panel);
                contentPanel.Controls.Add(panel);
            }

            foreach (UserControl other in panels.Values)
            {
                bool shown = false;
                if (other == panel)
                {
                    shown = true;
                }
                other.Visible = shown;
            }

            ((IContentPanel)panel).RefreshData();
        }

        private UserControl CreatePanel(Button button)
        {
            if (button == marketButton)
                return new MarketPanel();
            if (button == holdingsButton)
                return new HoldingsPanel();
            if (button == watchlistButton)
                return new WatchlistPanel();
            if (button == historyButton)
                return new HistoryPanel();
            if (button == reportsButton)
                return new ReportsPanel();
            if (button == glossaryButton)
                return new GlossaryPanel();
            if (button == adminButton)
                return new AdminPanel();
            if (button == settingsButton)
                return new SettingsPanel();
            return new DashboardPanel();
        }

        private void RefreshActivePanel()
        {
            UserControl panel;
            if (activeButton != null && panels.TryGetValue(activeButton, out panel))
                ((IContentPanel)panel).RefreshData();
        }

        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
                activeButton.BackColor = SidebarColor;

            activeButton = button;
            activeButton.BackColor = ActiveColor;
        }

        //menu items
        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            RefreshActivePanel();
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            LogOutRequested = true;
            Close();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lightThemeMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void darkThemeMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void englishMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(AppLanguage.English);
        }

        private void frenchMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage(AppLanguage.French);
        }

        private void glossaryMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(glossaryButton);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LanguageManager.Get("About_Message"), LanguageManager.Get("About_Title"),MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
