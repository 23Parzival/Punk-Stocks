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
    public partial class MarketPanel : UserControl, IContentPanel
    {
        private readonly StockRepository stockRepository = new StockRepository();
        private readonly WatchlistRepository watchlistRepository = new WatchlistRepository();
        private readonly TradeService tradeService = new TradeService();

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
            titleLabel.Text = LanguageManager.Get("Nav_Market");
            searchLabel.Text = LanguageManager.Get("Market_Search");
            sectorLabel.Text = LanguageManager.Get("Market_Sector");
            quantityLabel.Text = LanguageManager.Get("Market_Quantity");
            buyButton.Text = LanguageManager.Get("Market_Buy");
            sellButton.Text = LanguageManager.Get("Market_Sell");
            watchButton.Text = LanguageManager.Get("Market_Watch");

            idColumn.HeaderText = LanguageManager.Get("Column_ID");
            symbolColumn.HeaderText = LanguageManager.Get("Column_Symbol");
            companyColumn.HeaderText = LanguageManager.Get("Column_Company");
            sectorColumn.HeaderText = LanguageManager.Get("Column_Sector");
            priceColumn.HeaderText = LanguageManager.Get("Column_Price");
            volatilityColumn.HeaderText = LanguageManager.Get("Column_Volatility");
            yieldColumn.HeaderText = LanguageManager.Get("Column_DividendYield");

            if (sectorComboBox.Items.Count > 0)
            {
                fillingSectors = true;
                sectorComboBox.Items[0] = LanguageManager.Get("Market_AllSectors");
                fillingSectors = false;
            }

            UpdateSelection();
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
            //keep the chosen sector when prices refresh
            string selectedSector = sectorComboBox.SelectedIndex > 0 ? (string)sectorComboBox.SelectedItem : null;

            fillingSectors = true;
            sectorComboBox.Items.Clear();
            sectorComboBox.Items.Add(LanguageManager.Get("Market_AllSectors"));
            foreach (string sector in sectors)
                sectorComboBox.Items.Add(sector);

            int index = selectedSector == null ? -1 : sectors.IndexOf(selectedSector);
            sectorComboBox.SelectedIndex = index + 1;
            fillingSectors = false;
        }

        private void BindGrid()
        {
            string search = searchTextBox.Text.Trim();
            string sector = sectorComboBox.SelectedIndex > 0 ? sectors[sectorComboBox.SelectedIndex - 1] : null;
            Stock selected = SelectedStock();
            int firstRow = stocksGrid.FirstDisplayedScrollingRowIndex;

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

            //keep the scroll position when prices refresh
            if (firstRow >= 0 && firstRow < stocksGrid.RowCount)
                stocksGrid.FirstDisplayedScrollingRowIndex = firstRow;

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

            //no trading 0 shares
            bool hasQuantity = quantityNumericUpDown.Value > 0;
            buyButton.Enabled = hasStock && hasQuantity;
            sellButton.Enabled = hasStock && hasQuantity;
            watchButton.Enabled = hasStock;

            if (!hasStock)
            {
                stockNameLabel.Text = LanguageManager.Get("Market_SelectStock");
                descriptionLabel.Text = "";
                estimateLabel.Text = "";
                return;
            }

            stockNameLabel.Text = stock.Symbol + " - " + stock.CompanyName;
            descriptionLabel.Text = stock.Description;
            estimateLabel.Text = LanguageManager.Format("Market_EstimatedTotal", (stock.CurrentPrice * quantityNumericUpDown.Value).ToString("C2"));
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
            await MakeTrade(TransactionType.Buy);
        }

        private async void sellButton_Click(object sender, EventArgs e)
        {
            await MakeTrade(TransactionType.Sell);
        }

        private async Task MakeTrade(TransactionType type)
        {
            Stock stock = SelectedStock();
            User user = SessionManager.CurrentUser;
            if (stock == null || user == null)
                return;

            int quantity = (int)quantityNumericUpDown.Value;
            string title = LanguageManager.Get(type == TransactionType.Buy ? "Market_Buy" : "Market_Sell");

            //stop double clicks while the trade is saving
            buyButton.Enabled = false;
            sellButton.Enabled = false;

            TradeResult result;
            try
            {
                if (type == TransactionType.Buy)
                    result = await Task.Run(() => tradeService.Buy(user.UserID, stock.StockID, quantity));
                else
                    result = await Task.Run(() => tradeService.Sell(user.UserID, stock.StockID, quantity));
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageManager.Get("Error_Save") + "\n" + ex.Message, LanguageManager.Get("Error_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                UpdateSelection();
            }

            if (!result.Success)
            {
                MessageBox.Show(result.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SessionManager.UpdateCash(result.CashBalance);
            quantityNumericUpDown.Value = 0;
            MessageBox.Show(result.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(LanguageManager.Get("Error_Save") + "\n" + ex.Message, LanguageManager.Get("Error_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = LanguageManager.Format(added ? "Market_WatchAdded" : "Market_WatchExists", stock.Symbol);
            MessageBox.Show(message, LanguageManager.Get("Nav_Watchlist"),MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
