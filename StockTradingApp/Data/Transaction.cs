using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int TradeId { get; set; }
        [ForeignKey("Trade")]

        [Required]
        public string StockSymbol { get; set; }

        public double? EntryPrice { get; set; }

        public int? NumberSharesEntered { get; set; }

        public DateTime? EntryDate { get; set; }

        public double? SellPrice { get; set; }

        public int? NumberSharesExited { get; set; }

        public DateTime? ExitDate { get; set; }

        public Trade Trade { get; set; }
    }
}
