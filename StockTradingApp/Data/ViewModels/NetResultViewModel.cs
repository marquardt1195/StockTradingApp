﻿using System.ComponentModel.DataAnnotations;

namespace StockTradingApp.Data.ViewModels
{
    public class NetResultViewModel
    {
        [Key]public int Id { get; set; }
        public double Pl_dollar {get; set; }

        public double Pl_percent { get; set; }

        public int Num_wins { get; set; }

        public int Num_losses { get; set; }

        public int Total_trades {  get; set; }

        public double Lg_win { get; set; }

        public double Lg_loss { get; set; }
    }
}