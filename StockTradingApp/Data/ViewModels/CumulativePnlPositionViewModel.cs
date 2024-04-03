using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class CumulativePnlPositionViewModel
    {
        [Key]
        public int TradeId { get; set; }

        public decimal CumulativeDollarPnl { get; set;}

        public DateTime ShareBuyDate { get; set; }
    }
}
