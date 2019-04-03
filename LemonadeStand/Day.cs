using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public string Name;
        public int DailyProfitLoss;
        public Weather Weather;
        public Customer Customer;

        //constructor
        public Day()
        {
            Weather = new Weather();

        }


        //member methods
        public void RunningTotal()
        {

        }
    }
}