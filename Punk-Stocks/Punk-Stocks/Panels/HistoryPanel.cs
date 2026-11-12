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
            try
            {
                transactions = await Task.Run(() => transactionRepository.GetRecent(user.UserID, int.MaxValue));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            historyGrid.DataSource = transactions.Select(t => new
            {
                t.ExecutedAt,
                Type = LanguageManager.Get(t.TransactionType == (int)TransactionType.Buy ? "Market_Buy" : "Market_Sell"),
                t.Stock.Symbol,
                t.Quantity,
                t.PricePerShare,
                Total = t.PricePerShare * t.Quantity
            }).ToList();
        }
    }
}
