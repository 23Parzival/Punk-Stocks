using Punk_Stocks.Repositories;
using Punk_Stocks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punk_Stocks.Panels
{
    public partial class DashboardPanel : UserControl, IContentPanel
    {
        private const int RecentCount = 10;

        private readonly HoldingRepository holdingRepository = new HoldingRepository();
        private readonly TransactionRepository transactionRepository = new TransactionRepository();

        public DashboardPanel()
        {
            InitializeComponent();
            PanelStyle.StyleGrid(recentGrid);
            ApplyLanguage();
        }

        public void ApplyLanguage()
        {
            //not done
        }

        public async void RefreshData()
        {
            User user = SessionManager.CurrentUser;
            if (user == null)
                return;

            List<Holding> holdings;
            List<Transaction> recent;
            try
            {
                holdings = await Task.Run(() => holdingRepository.GetForUser(user.UserID));
                recent = await Task.Run(() => transactionRepository.GetRecent(user.UserID, RecentCount));
            }
            catch (Exception ex)
            {
                PanelStyle.ShowLoadError(ex);
                return;
            }

            decimal holdingsValue = holdings.Sum(h => h.Quantity * h.Stock.CurrentPrice);
            decimal profit = holdingsValue - holdings.Sum(h => h.Quantity * h.AvgCost);

            cashValueLabel.Text = user.CashBalance.ToString("C2");
            holdingsValueLabel.Text = holdingsValue.ToString("C2");
            netWorthValueLabel.Text = (user.CashBalance + holdingsValue).ToString("C2");
            profitValueLabel.Text = profit.ToString("C2");
            profitValueLabel.ForeColor = PanelStyle.ProfitColor(profit);

            recentGrid.DataSource = recent.Select(t => new
            {
                t.ExecutedAt,
                t.TransactionType,
                t.Stock.Symbol,
                t.Quantity,
                t.PricePerShare,
                Total = t.PricePerShare * t.Quantity
            }).ToList();
        }
    }
}
