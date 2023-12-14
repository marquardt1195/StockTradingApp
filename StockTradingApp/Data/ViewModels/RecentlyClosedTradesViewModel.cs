using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class RecentlyClosedTradesViewModel
    {

        [Key]
        public int? TradeId { get; set; }

        public string? StockSymbol { get; set; }

        public DateTime? BuyDate { get; set; }

        public decimal? DollarPnl {  get; set; }
        
        public decimal? PercentPnl { get; set; }

        public decimal? Nav { get; set; }
    }
}
