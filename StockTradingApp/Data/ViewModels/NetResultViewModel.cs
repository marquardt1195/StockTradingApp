using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class NetResultViewModel
    {
        public decimal Pl_dollar {get; set; }

        public decimal Pl_percent { get; set; }

        public int Num_wins { get; set; }

        public int Num_losses { get; set; }

        public int Total_trades {  get; set; }

        public decimal Lg_win { get; set; }

        public decimal Lg_loss { get; set; }

        public int Win_hold { get; set; }

        public int Loss_hold { get; set; }
    }
}
