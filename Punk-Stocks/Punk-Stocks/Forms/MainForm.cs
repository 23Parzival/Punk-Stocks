using Punk_Stocks.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punk_Stocks.Forms
{
    public partial class MainForm : Form
    {
        private static readonly Color SidebarColor = Color.FromArgb(30, 30, 46);
        private static readonly Color ActiveColor = Color.FromArgb(99, 102, 241);

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

            RefreshStatusBar();
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            SetActiveButton(dashboardButton);
        }

        //status bar
        public void RefreshStatusBar()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            userStatusLabel.Text = "User: " + user.Username;
            cashStatusLabel.Text = "Cash: " + user.CashBalance.ToString("C2");
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //sidebar nav
        private void navButton_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);

            //todo
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
            //reload stocks list
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
        }

        private void frenchMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void glossaryMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveButton(glossaryButton);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Punk-Stocks v1.0\nA stock market simulator for new investors.\nSimulated data and virtual money only.", "About Punk-Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
