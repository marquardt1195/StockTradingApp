using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public decimal principal_balance { get; set; }

        public DateTime principal_start_date { get; set; }
    }
}
