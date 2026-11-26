using Punk_Stocks.Models.Enums;
using Punk_Stocks.Repositories;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class WatchlistPanel : UserControl, IContentPanel
    {
        private readonly WatchlistRepository watchlistRepository = new WatchlistRepository();
        private readonly AlertRepository alertRepository = new AlertRepository();

        //same order as the grid rows, so a row index finds its stock
        private List<WatchlistItem> items = new List<WatchlistItem>();

        //same thing for the alerts grid
        private List<Alert> alerts = new List<Alert>();

        public WatchlistPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(watchlistGrid);
            PanelStyle.StyleGrid(alertsGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Watchlist");
            removeButton.Text = LanguageManager.Get("Watchlist_Remove");

            symbolColumn.HeaderText = LanguageManager.Get("Column_Symbol");
            companyColumn.HeaderText = LanguageManager.Get("Column_Company");
            sectorColumn.HeaderText = LanguageManager.Get("Column_Sector");
            priceColumn.HeaderText = LanguageManager.Get("Column_Price");

            alertsTitleLabel.Text = LanguageManager.Get("Watchlist_Alerts");
            removeAlertButton.Text = LanguageManager.Get("Watchlist_RemoveAlert");

            alertSymbolColumn.HeaderText = LanguageManager.Get("Column_Symbol");
            conditionColumn.HeaderText = LanguageManager.Get("Column_Condition");
            targetColumn.HeaderText = LanguageManager.Get("Column_Target");
            alertPriceColumn.HeaderText = LanguageManager.Get("Column_Price");
            statusColumn.HeaderText = LanguageManager.Get("Column_Status");

            //condition and status are text, they need the new language too
            BindAlerts(alerts);
        }

        public async void RefreshData()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            List<WatchlistItem> loaded;
            List<Alert> loadedAlerts;
            try
            {
                loaded = await Task.Run(() => watchlistRepository.GetForUser(user.UserID));
                loadedAlerts = await Task.Run(() => alertRepository.GetForUser(user.UserID));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            BindGrid(loaded);
            BindAlerts(loadedAlerts);
        }

        private void BindGrid(List<WatchlistItem> loaded)
        {
            //keep the selected stock when prices refresh
            WatchlistItem selected = SelectedItem();

            items = loaded;
            watchlistGrid.DataSource = items.Select(w => new
            {
                w.Stock.Symbol,
                w.Stock.CompanyName,
                w.Stock.Sector,
                w.Stock.CurrentPrice
            }).ToList();

            if (selected != null)
            {
                int index = items.FindIndex(w => w.StockID == selected.StockID);
                if (index >= 0)
                    watchlistGrid.CurrentCell = watchlistGrid.Rows[index].Cells[symbolColumn.Index];
            }

            removeButton.Enabled = items.Count > 0;
        }

        private void BindAlerts(List<Alert> loaded)
        {
            //keep the selected alert when prices refresh
            Alert selected = SelectedAlert();

            alerts = loaded;
            alertsGrid.DataSource = alerts.Select(a => new
            {
                a.Stock.Symbol,
                Condition = LanguageManager.Get(a.Direction == (int)AlertDirection.Above ? "Alert_Above" : "Alert_Below"),
                a.TargetPrice,
                a.Stock.CurrentPrice,
                Status = LanguageManager.Get(a.IsTriggered ? "Alert_Triggered" : "Alert_Waiting")
            }).ToList();

            if (selected != null)
            {
                int index = alerts.FindIndex(a => a.AlertID == selected.AlertID);
                if (index >= 0)
                    alertsGrid.CurrentCell = alertsGrid.Rows[index].Cells[alertSymbolColumn.Index];
            }

            removeAlertButton.Enabled = alerts.Count > 0;
        }

        private WatchlistItem SelectedItem()
        {
            if (watchlistGrid.CurrentRow == null || watchlistGrid.CurrentRow.Index >= items.Count)
                return null;

            return items[watchlistGrid.CurrentRow.Index];
        }

        private Alert SelectedAlert()
        {
            if (alertsGrid.CurrentRow == null || alertsGrid.CurrentRow.Index >= alerts.Count)
                return null;

            return alerts[alertsGrid.CurrentRow.Index];
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            WatchlistItem item = SelectedItem();
            User user = SessionManager.CurrentUser;
            if (item == null || user == null)
                return;

            try
            {
                await Task.Run(() => watchlistRepository.Remove(user.UserID, item.StockID));
            }
            catch (Exception ex)
            {
                ShowSaveError(ex);
                return;
            }

            RefreshData();
        }

        private async void removeAlertButton_Click(object sender, EventArgs e)
        {
            Alert alert = SelectedAlert();
            User user = SessionManager.CurrentUser;
            if (alert == null || user == null)
                return;

            try
            {
                await Task.Run(() => alertRepository.Remove(alert.AlertID, user.UserID));
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
