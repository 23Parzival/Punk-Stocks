namespace Punk_Stocks.Services
{
    internal sealed class TradeResult
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public decimal CashBalance { get; private set; }

        public static TradeResult Ok(string message, decimal cashBalance)
        {
            return new TradeResult { Success = true, Message = message, CashBalance = cashBalance };
        }

        public static TradeResult Fail(string message)
        {
            return new TradeResult { Success = false, Message = message };
        }
    }
}
