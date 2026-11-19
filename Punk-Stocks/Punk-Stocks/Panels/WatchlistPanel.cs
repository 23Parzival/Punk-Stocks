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

        //same order as the grid rows, so a row index finds its stock
        private List<WatchlistItem> items = new List<WatchlistItem>();

        public WatchlistPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(watchlistGrid);
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
        }

        public async void RefreshData()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            List<WatchlistItem> loaded;
            try
            {
                loaded = await Task.Run(() => watchlistRepository.GetForUser(user.UserID));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            BindGrid(loaded);
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

        private WatchlistItem SelectedItem()
        {
            if (watchlistGrid.CurrentRow == null || watchlistGrid.CurrentRow.Index >= items.Count)
                return null;

            return items[watchlistGrid.CurrentRow.Index];
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
                MessageBox.Show(LanguageManager.Get("Error_Save") + "\n" + ex.Message, LanguageManager.Get("Error_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefreshData();
        }
    }
}
