using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class NetResultViewModel
    {
        public double Pl_dollar {get; set; }

        public double Pl_percent { get; set; }

        public int Num_wins { get; set; }

        public int Num_losses { get; set; }

        public int Total_trades {  get; set; }

        public double Lg_win { get; set; }

        public double Lg_loss { get; set; }

        public int Win_hold { get; set; }

        public int Loss_hold { get; set; }
    }
}
