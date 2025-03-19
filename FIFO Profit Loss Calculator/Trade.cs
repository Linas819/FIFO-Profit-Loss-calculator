using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO_Profit_Loss_Calculator
{
    public class Trade
    {
        public int TradeId { get; set; } = 0;
        public string Type { get; set; } = ""; //BUY or SELL
        public DateTime Date { get; set; } = DateTime.Now;
        public string Client { get; set; } = "";
        public string Security { get; set; } = "";
        public int Amount { get; set; } = 0;
        public decimal Price { get; set; } = decimal.Zero;
        public decimal Fee { get; set; } = decimal.Zero;
    }
}
