using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables
        public double WeatherDisposition;
        public double PriceDisposition;
        public int Thirst;
        Random rnd = new Random();
               
        //constructor
        public Customer()
        {
                
        }

        //member methods
        public void PurchasePotential()//Based on Weather or Price being at setpoint. Once decision to buy is made, Thirst will determine how many cups they buy
        {
                
        }
    }
}