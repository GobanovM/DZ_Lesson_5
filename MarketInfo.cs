using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson_5
{
    public static class MarketInfo
    {
        private static Random random;

        static MarketInfo()
        {
            random = new Random();
        }

        public static int GetSprad()
        {
           return random.Next(10,100);
        }

        public static int GetMarketAsk()
        {
           return random.Next(1000, 10000);
        }

        public static int GetMarketBid()
        {
           return GetMarketAsk() - GetSprad();
        }
    }
}
