using Punk_Stocks.Repositories;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class AdminPanel : UserControl, IContentPanel
    {
        private readonly UserRepository userRepository = new UserRepository();

        //same order as the grid rows, a row index fits its user
        private List<User> users = new List<User>();

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

        public async void RefreshData()
        {
            List<User> loaded;
            try
            {
                loaded = await Task.Run(() => userRepository.GetAll());
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            BindGrid(loaded);
        }

        private void BindGrid(List<User> loaded)
        {
            //keep the selected user when the grid refreshes
            User selected = SelectedUser();

            users = loaded;
            usersGrid.DataSource = users;

            if (selected != null)
            {
                int index = users.FindIndex(u => u.UserID == selected.UserID);
                if (index >= 0)
                    usersGrid.CurrentCell = usersGrid.Rows[index].Cells[idColumn.Index];
            }

            resetCashButton.Enabled = users.Count > 0;
            deleteUserButton.Enabled = users.Count > 0;
        }

        private User SelectedUser()
        {
            if (usersGrid.CurrentRow == null || usersGrid.CurrentRow.Index >= users.Count)
                return null;

            return users[usersGrid.CurrentRow.Index];
        }

        private async void resetCashButton_Click(object sender, EventArgs e)
        {
            User user = SelectedUser();
            if (user == null)
                return;

            string title = LanguageManager.Get("Admin_ResetCash");
            if (MessageBox.Show(LanguageManager.Format("Admin_ConfirmReset", user.Username), title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            decimal? cash;
            try
            {
                cash = await Task.Run(() => userRepository.ResetAccount(user.UserID));
            }
            catch (Exception ex)
            {
                ShowSaveError(ex);
                return;
            }

            //resetting yourself changes the cash in the status bar
            if (cash.HasValue && SessionManager.CurrentUser != null && SessionManager.CurrentUser.UserID == user.UserID)
                SessionManager.UpdateCash(cash.Value);

            RefreshData();
            if (cash.HasValue)
                MessageBox.Show(LanguageManager.Format("Admin_ResetDone", user.Username, cash.Value.ToString("C2")), title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void deleteUserButton_Click(object sender, EventArgs e)
        {
            User user = SelectedUser();
            User current = SessionManager.CurrentUser;
            if (user == null || current == null)
                return;

            string title = LanguageManager.Get("Admin_DeleteUser");
            if (user.UserID == current.UserID)
            {
                MessageBox.Show(LanguageManager.Get("Admin_CannotDeleteSelf"), title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (user.IsAdmin)
            {
                MessageBox.Show(LanguageManager.Get("Admin_CannotDeleteAdmin"), title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(LanguageManager.Format("Admin_ConfirmDelete", user.Username), title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                await Task.Run(() => userRepository.Delete(user.UserID));
            }
            catch (Exception ex)
            {
                ShowSaveError(ex);
                return;
            }

            RefreshData();
        }

        private static void ShowSaveError(Exception ex)
        {
            MessageBox.Show(LanguageManager.Get("Error_Save") + "\n" + ex.Message, LanguageManager.Get("Error_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
