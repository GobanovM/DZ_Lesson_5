using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;


namespace DZ_Lesson_5
{
    public class Position
    {
        public string Symbol = "RiZ4";
        public decimal openPrice = 0;
        public decimal openVolume = 0;
        public decimal tpPrice = 0;
        public decimal slPrice = 0;
        public int tpSize = 200;
        public int slSize = 100;
        public Direction PosType = Direction.NoType;


        public Position()

        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += NewTrade;
            timer.Start();

        }
        
        Random random = new Random();

        private void NewTrade(object sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();
            int num = random.Next(-10, 10);
            trade.Volume = Math.Abs(num);
            trade.Symbol = Symbol;
            trade.Price = random.Next(70000, 80000);

            if (num > 0)
            {
                // Long
                PosType = Direction.Long;
                trade.Price = MarketInfo.GetMarketAsk();
                trade.TPPrice = trade.Price + tpSize;
                trade.SLPrice = trade.Price - slSize;
                openVolume += trade.Volume;
            }
            else if (num < 0)
            {
                //Short
                PosType = Direction.Short;
                trade.Price = MarketInfo.GetMarketBid();
                trade.TPPrice = trade.Price - tpSize;
                trade.SLPrice = trade.Price + slSize;
                openVolume -= trade.Volume;
            }

            string str = PosType + "Volume = " + trade.Volume.ToString() + " / Price = " + trade.Price.ToString() + " / Stop = " + trade.SLPrice.ToString() + " / Take = " + trade.TPPrice.ToString();

            Console.WriteLine(str);
        }
    }
}
