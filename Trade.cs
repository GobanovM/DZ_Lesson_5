using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_5
{
    public class Trade
    {
        public decimal Volume;
        public decimal Price;
        public decimal TPPrice;
        public decimal SLPrice;
        public string PosType;
        public string Symbol;
        public Direction Dir;

        //public Trade()
        //{
        //}

        public Trade(string Symbol, decimal Price, decimal Volume, Direction Dir)
        {
            this.Symbol = Symbol;
            this.Price = Price;
            this.Volume = Volume;
            this.Dir = Dir;
        }


    }
}
