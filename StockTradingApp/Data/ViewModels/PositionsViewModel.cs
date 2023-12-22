using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class PositionsViewModel
    {
        [Key]
        public int TradeId { get; set; }

        public string StockSymbol { get; set; }

        public decimal PositionSize { get; set; }

        public int Quantity { get; set; }

        public decimal CostBasis { get; set; }

        public decimal DollarStopLoss { get; set; }

        public decimal PercentStopLoss { get; set; }

        public decimal Risk { get; set; }

        public decimal OneRisk { get; set; }

        public decimal TwoRisk { get; set; }

        public decimal ThreeRisk { get; set; }
    }
}
