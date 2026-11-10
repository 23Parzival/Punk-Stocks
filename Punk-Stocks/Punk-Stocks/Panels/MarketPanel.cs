using Punk_Stocks.Repositories;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class MarketPanel : UserControl, IContentPanel
    {
        private readonly StockRepository stockRepository = new StockRepository();
        private readonly WatchlistRepository watchlistRepository = new WatchlistRepository();

        private List<Stock> stocks = new List<Stock>();
        private List<string> sectors = new List<string>();
        private bool fillingSectors;

        public MarketPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(stocksGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            //not done
        }

        public async void RefreshData()
        {
            try
            {
                stocks = await Task.Run(() => stockRepository.GetAll());
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            sectors = stocks.Select(s => s.Sector).Distinct().OrderBy(s => s).ToList();
            FillSectors();
            BindGrid();
        }

        private void FillSectors()
        {
            fillingSectors = true;
            sectorComboBox.Items.Clear();
            sectorComboBox.Items.Add("All sectors");
            foreach (string sector in sectors)
                sectorComboBox.Items.Add(sector);
            sectorComboBox.SelectedIndex = 0;
            fillingSectors = false;
        }

        private void BindGrid()
        {
            string search = searchTextBox.Text.Trim();
            string sector = sectorComboBox.SelectedIndex > 0 ? sectors[sectorComboBox.SelectedIndex - 1] : null;
            Stock selected = SelectedStock();

            stocksGrid.DataSource = stocks
                .Where(s => sector == null || s.Sector == sector)
                .Where(s => search.Length == 0 || s.Symbol.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0
                    || s.CompanyName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(s => new
                {
                    s.StockID,
                    s.Symbol,
                    s.CompanyName,
                    s.Sector,
                    s.CurrentPrice,
                    s.Volatility,
                    s.DividendYield
                }).ToList();

            if (selected != null)
            {
                foreach (DataGridViewRow row in stocksGrid.Rows)
                {
                    if ((int)row.Cells[idColumn.Index].Value == selected.StockID)
                    {
                        stocksGrid.CurrentCell = row.Cells[symbolColumn.Index];
                        break;
                    }
                }
            }

            UpdateSelection();
        }

        private Stock SelectedStock()
        {
            if (stocksGrid.CurrentRow == null)
                return null;

            int stockId = (int)stocksGrid.CurrentRow.Cells[idColumn.Index].Value;
            return stocks.FirstOrDefault(s => s.StockID == stockId);
        }

        private void UpdateSelection()
        {
            Stock stock = SelectedStock();
            bool hasStock = stock != null;

            buyButton.Enabled = hasStock;
            sellButton.Enabled = hasStock;
            watchButton.Enabled = hasStock;

            if (!hasStock)
            {
                stockNameLabel.Text = "Select a stock";
                descriptionLabel.Text = "";
                estimateLabel.Text = "";
                return;
            }

            stockNameLabel.Text = stock.Symbol + " - " + stock.CompanyName;
            descriptionLabel.Text = stock.Description;
            estimateLabel.Text = "Estimated total: " + (stock.CurrentPrice * quantityNumericUpDown.Value).ToString("C2");
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void sectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!fillingSectors)
                BindGrid();
        }

        private void stocksGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelection();
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateSelection();
        }

        private async void buyButton_Click(object sender, EventArgs e)
        {
            //make trade
        }

        private async void sellButton_Click(object sender, EventArgs e)
        {
            //make trade
        }

        private async void watchButton_Click(object sender, EventArgs e)
        {
            Stock stock = SelectedStock();
            User user = SessionManager.CurrentUser;
            if (stock == null || user == null)
                return;

            bool added;
            try
            {
                added = await Task.Run(() => watchlistRepository.Add(user.UserID, stock.StockID));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the changes:" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = stock.Symbol + (added ? " was added to your watchlist." : " is already on your watchlist.");
            MessageBox.Show(message, "Watchlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
