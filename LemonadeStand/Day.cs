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
        public Customer customer;
        public List<Customer> customerArray;


        //constructor
        public Day()
        {
            Weather = new Weather();            
            customer = new Customer();
            customerArray = new List<Customer> { };
            
        }


        //member methods
        public void RunningTotal()
        {

        }
        public void CustomerGenerator()
        {
            for (var i = 0; i < DailyCustomers; i++)
            {
                customer = new Customer();
                customerArray.Add(customer);

            }
        }
        public void PotentialCustomers()
        {
            var n = Weather.WeatherFactor;
            switch (n)
            {
                case 1:
                    DailyCustomers = 50;
                    break;
                case 2:
                    DailyCustomers = 55;
                    break;
                case 3:
                    DailyCustomers = 60;
                    break;
                case 4:
                    DailyCustomers = 65;
                    break;
                case 5:
                    DailyCustomers = 70;
                    break;
                case 6:
                    DailyCustomers = 75;
                    break;
                case 7:
                    DailyCustomers = 80;
                    break;
                case 8:
                    DailyCustomers = 85;
                    break;
                case 9:
                    DailyCustomers = 90;
                    break;
                case 10:
                    DailyCustomers = 100;
                    break;


            }

        }

    }
}