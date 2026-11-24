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
    public partial class HistoryPanel : UserControl, IContentPanel
    {
        private readonly TransactionRepository transactionRepository = new TransactionRepository();
        private readonly DividendRepository dividendRepository = new DividendRepository();

        public HistoryPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(historyGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            titleLabel.Text = LanguageManager.Get("Nav_History");

            dateColumn.HeaderText = LanguageManager.Get("Column_Date");
            typeColumn.HeaderText = LanguageManager.Get("Column_Type");
            symbolColumn.HeaderText = LanguageManager.Get("Column_Symbol");
            quantityColumn.HeaderText = LanguageManager.Get("Column_Quantity");
            priceColumn.HeaderText = LanguageManager.Get("Column_Price");
            totalColumn.HeaderText = LanguageManager.Get("Column_Total");
        }

        public async void RefreshData()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            List<Transaction> transactions;
            List<Dividend> dividends;
            try
            {
                transactions = await Task.Run(() => transactionRepository.GetRecent(user.UserID, int.MaxValue));
                dividends = await Task.Run(() => dividendRepository.GetForUser(user.UserID));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            //trades and dividends in one list, newest first. dividends have no quantity or price, so those are left blank
            var trades = transactions.Select(t => new
            {
                ExecutedAt = t.ExecutedAt,
                Type = LanguageManager.Get(t.TransactionType == (int)TransactionType.Buy ? "Market_Buy" : "Market_Sell"),
                Symbol = t.Stock.Symbol,
                Quantity = (int?)t.Quantity,
                PricePerShare = (decimal?)t.PricePerShare,
                Total = t.PricePerShare * t.Quantity
            });
            var payouts = dividends.Select(d => new
            {
                ExecutedAt = d.PaidAt,
                Type = LanguageManager.Get("History_Dividend"),
                Symbol = d.Stock.Symbol,
                Quantity = (int?)null,
                PricePerShare = (decimal?)null,
                Total = d.Amount
            });

            historyGrid.DataSource = trades.Concat(payouts).OrderByDescending(r => r.ExecutedAt).ToList();
        }
    }
}
