namespace StockTradingApp.Data.ViewModels
{
    public class MonthlyResultViewModel
    {
        public string Month_closed { get; set; }

        public decimal Monthly_dollar_pl { get; set; }

        public decimal Monthly_percent_pl { get; set; }

        public decimal Monthly_avg_percent_gain { get; set; }

        public decimal Monthly_avg_percent_loss { get; set; }

        public int Monthly_wins { get; set; }

        public int Monthly_losses { get; set; }

        public decimal Monthly_batting_avg { get; set; }

        public decimal Monthly_winloss { get; set; }

        public decimal Monthly_adj_winloss { get; set; }

    }
}
