using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Models
{
    public class PortfolioViewModel
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfShares { get; set; }
        public decimal Price { get; set; }
    }
}
