using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public int DailyCustomers;
        public string Name;
        public int DailyProfitLoss;
        public Weather Weather;
        public Customer Customer;


        //constructor
        public Day()
        {
            Weather = new Weather();
            //for (var i = 0; i <) ;
            Customer = new Customer();

        }


        //member methods
        public void RunningTotal()
        {

        }
        public void CustomerGenerator()
        {
            for (var i = 0; i < 100; i++)
            {

            }
        }
        public void PotentialCustomers()
        {
            //DailyCustomers = 

        }

    }
}