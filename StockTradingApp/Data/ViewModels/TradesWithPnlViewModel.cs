using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class TradesWithPnlViewModel
    {
        [Key]
        public int TradeId { get; set; }

        public string? StockSymbol { get; set; }

        public decimal? CostBasis { get; set; }

        public decimal? SellBasis { get; set; }

        public decimal? DollarPnl { get; set; }

        public decimal? PercentPnl { get; set; }

        public int? HoldTime { get; set; }
    }
}
