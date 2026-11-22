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
    public partial class ReportsPanel : UserControl, IContentPanel
    {
        private const int PortfolioReport = 0;
        private const int SectorsReport = 1;
        private const int ProfitLossReport = 2;

        //column property name -> resource key for its header
        private static readonly Dictionary<string, string> Headers = new Dictionary<string, string>
        {
            { "Symbol", "Column_Symbol" },
            { "CompanyName", "Column_Company" },
            { "Sector", "Column_Sector" },
            { "Stocks", "Column_Stocks" },
            { "Quantity", "Column_Quantity" },
            { "AvgCost", "Column_AvgCost" },
            { "CurrentPrice", "Column_Price" },
            { "MarketValue", "Column_MarketValue" },
            { "Profit", "Column_Profit" },
            { "Realized", "Column_Realized" },
            { "Unrealized", "Column_Unrealized" },
            { "Weight", "Column_Weight" }
        };

        private readonly HoldingRepository holdingRepository = new HoldingRepository();
        private readonly TransactionRepository transactionRepository = new TransactionRepository();

        public ReportsPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(reportGrid);
            //each report has different columns, so the grid makes them from the rows
            reportGrid.AutoGenerateColumns = true;
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_Reports");
            reportTypeLabel.Text = LanguageManager.Get("Reports_Type");
            generateButton.Text = LanguageManager.Get("Reports_Generate");

            int selected = reportTypeComboBox.SelectedIndex;
            reportTypeComboBox.Items.Clear();
            reportTypeComboBox.Items.Add(LanguageManager.Get("Reports_Portfolio"));
            reportTypeComboBox.Items.Add(LanguageManager.Get("Reports_Sectors"));
            reportTypeComboBox.Items.Add(LanguageManager.Get("Reports_ProfitLoss"));
            reportTypeComboBox.SelectedIndex = selected < 0 ? 0 : selected;

            SetupColumns();
        }

        public void RefreshData()
        {
            //reports are only built when Generate is clicked (for now)
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            int report = reportTypeComboBox.SelectedIndex;
            generateButton.Enabled = false;

            object rows;
            try
            {
                rows = await Task.Run(() => BuildReport(report, user.UserID));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }
            finally
            {
                generateButton.Enabled = true;
            }

            reportGrid.DataSource = rows;
            SetupColumns();
        }

        private object BuildReport(int report, int userId)
        {
            if (report == SectorsReport)
                return BuildSectors(userId);
            if (report == ProfitLossReport)
                return BuildProfitLoss(userId);
            return BuildPortfolio(userId);
        }

        //every holding with its share of the portfolio
        private List<PortfolioRow> BuildPortfolio(int userId)
        {
            List<Holding> holdings = holdingRepository.GetForUser(userId);
            decimal totalValue = holdings.Sum(h => h.Quantity * h.Stock.CurrentPrice);

            List<PortfolioRow> rows = holdings.Select(h => new PortfolioRow
            {
                Symbol = h.Stock.Symbol,
                CompanyName = h.Stock.CompanyName,
                Quantity = h.Quantity,
                AvgCost = h.AvgCost,
                CurrentPrice = h.Stock.CurrentPrice,
                MarketValue = h.Quantity * h.Stock.CurrentPrice,
                Profit = h.Quantity * (h.Stock.CurrentPrice - h.AvgCost),
                Weight = Share(h.Quantity * h.Stock.CurrentPrice, totalValue)
            }).ToList();

            rows.Add(new PortfolioRow
            {
                Symbol = LanguageManager.Get("Reports_Total"),
                MarketValue = totalValue,
                Profit = rows.Sum(r => r.Profit ?? 0),
                Weight = holdings.Count > 0 ? 1 : 0
            });
            return rows;
        }

        //holdings grouped by sector
        private List<SectorRow> BuildSectors(int userId)
        {
            List<Holding> holdings = holdingRepository.GetForUser(userId);
            decimal totalValue = holdings.Sum(h => h.Quantity * h.Stock.CurrentPrice);

            List<SectorRow> rows = holdings
                .GroupBy(h => h.Stock.Sector)
                .Select(g => new SectorRow
                {
                    Sector = g.Key,
                    Stocks = g.Count(),
                    MarketValue = g.Sum(h => h.Quantity * h.Stock.CurrentPrice),
                    Profit = g.Sum(h => h.Quantity * (h.Stock.CurrentPrice - h.AvgCost))
                })
                .OrderByDescending(r => r.MarketValue)
                .ToList();

            foreach (SectorRow row in rows)
                row.Weight = Share(row.MarketValue, totalValue);

            rows.Add(new SectorRow
            {
                Sector = LanguageManager.Get("Reports_Total"),
                Stocks = holdings.Count,
                MarketValue = totalValue,
                Profit = rows.Sum(r => r.Profit),
                Weight = holdings.Count > 0 ? 1 : 0
            });
            return rows;
        }

        //realized = profit from shares already sold, unrealized = profit on shares still owned
        private List<ProfitLossRow> BuildProfitLoss(int userId)
        {
            List<Holding> holdings = holdingRepository.GetForUser(userId);
            List<Transaction> transactions = transactionRepository.GetRecent(userId, int.MaxValue);

            var rows = new List<ProfitLossRow>();
            foreach (var stockTrades in transactions.GroupBy(t => t.StockID))
            {
                //replay the trades in order, keeping the average cost like TradeService does
                int quantity = 0;
                decimal avgCost = 0;
                decimal realized = 0;
                foreach (Transaction t in stockTrades.OrderBy(t => t.ExecutedAt).ThenBy(t => t.TransactionID))
                {
                    if (t.TransactionType == (int)TransactionType.Buy)
                    {
                        avgCost = Math.Round((quantity * avgCost + t.Quantity * t.PricePerShare) / (quantity + t.Quantity), 2);
                        quantity += t.Quantity;
                    }
                    else
                    {
                        realized += t.Quantity * (t.PricePerShare - avgCost);
                        quantity -= t.Quantity;
                        if (quantity <= 0)
                        {
                            quantity = 0;
                            avgCost = 0;
                        }
                    }
                }

                Stock stock = stockTrades.First().Stock;
                Holding holding = holdings.FirstOrDefault(h => h.StockID == stock.StockID);
                decimal unrealized = holding == null ? 0 : holding.Quantity * (holding.Stock.CurrentPrice - holding.AvgCost);

                rows.Add(new ProfitLossRow
                {
                    Symbol = stock.Symbol,
                    CompanyName = stock.CompanyName,
                    Realized = realized,
                    Unrealized = unrealized,
                    Profit = realized + unrealized
                });
            }

            rows = rows.OrderBy(r => r.Symbol).ToList();
            rows.Add(new ProfitLossRow
            {
                Symbol = LanguageManager.Get("Reports_Total"),
                Realized = rows.Sum(r => r.Realized),
                Unrealized = rows.Sum(r => r.Unrealized),
                Profit = rows.Sum(r => r.Profit)
            });
            return rows;
        }

        private static decimal Share(decimal value, decimal total)
        {
            return total == 0 ? 0 : value / total;
        }

        //headers and formats for whatever columns the current report made
        private void SetupColumns()
        {
            foreach (DataGridViewColumn column in reportGrid.Columns)
            {
                string key;
                if (Headers.TryGetValue(column.DataPropertyName, out key))
                    column.HeaderText = LanguageManager.Get(key);

                if (column.DataPropertyName == "Weight")
                    column.DefaultCellStyle.Format = "P1";
                else if (column.ValueType == typeof(decimal) || column.ValueType == typeof(decimal?))
                    column.DefaultCellStyle.Format = "C2";
            }
        }

        private void reportGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string property = reportGrid.Columns[e.ColumnIndex].DataPropertyName;
            if ((property == "Profit" || property == "Realized" || property == "Unrealized") && e.Value is decimal)
                e.CellStyle.ForeColor = PanelStyle.ProfitColor((decimal)e.Value);
        }

        //rows for the grid. nullable values are left blank on the total row
        private class PortfolioRow
        {
            public string Symbol { get; set; }
            public string CompanyName { get; set; }
            public int? Quantity { get; set; }
            public decimal? AvgCost { get; set; }
            public decimal? CurrentPrice { get; set; }
            public decimal MarketValue { get; set; }
            public decimal? Profit { get; set; }
            public decimal Weight { get; set; }
        }

        private class SectorRow
        {
            public string Sector { get; set; }
            public int Stocks { get; set; }
            public decimal MarketValue { get; set; }
            public decimal Profit { get; set; }
            public decimal Weight { get; set; }
        }

        private class ProfitLossRow
        {
            public string Symbol { get; set; }
            public string CompanyName { get; set; }
            public decimal Realized { get; set; }
            public decimal Unrealized { get; set; }
            public decimal Profit { get; set; }
        }
    }
}
