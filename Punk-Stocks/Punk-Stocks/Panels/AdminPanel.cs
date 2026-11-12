using Punk_Stocks.Services;
using System;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class AdminPanel : UserControl, IContentPanel
    {
        public AdminPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(usersGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Admin");
            resetCashButton.Text = LanguageManager.Get("Admin_ResetCash");
            deleteUserButton.Text = LanguageManager.Get("Admin_DeleteUser");

            idColumn.HeaderText = LanguageManager.Get("Column_ID");
            usernameColumn.HeaderText = LanguageManager.Get("Common_Username");
            cashColumn.HeaderText = LanguageManager.Get("Column_Cash");
            adminColumn.HeaderText = LanguageManager.Get("Column_IsAdmin");
            createdColumn.HeaderText = LanguageManager.Get("Column_CreatedAt");
        }

        public void RefreshData()
        {
            //load all users
        }

        private void resetCashButton_Click(object sender, EventArgs e)
        {
            //reset selected users cash
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            //delete selected user
        }
    }
}
