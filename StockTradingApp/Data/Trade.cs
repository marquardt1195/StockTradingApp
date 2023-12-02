using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data
{
    public class Trade
    {
        [Key]
        public int TradeId { get; set; }

        [Required]
        public string StockSymbol { get; set; } = string.Empty;

        public double? BuyPrice { get; set; }

        public int? NumberSharesBought { get; set; }

        public DateTime? ShareBuyDate { get; set; }

        public double? DollarStopLoss { get; set; }

        public double? SellPrice { get; set; }

        public int? NumberSharesSold { get; set; }

        public DateTime? ShareSellDate { get; set; }

        public ICollection<Transaction>? Transactions { get; set; }
    }
}
