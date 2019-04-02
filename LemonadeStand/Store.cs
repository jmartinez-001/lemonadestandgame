using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variables
        public double Cups;
        public double PricePerCup;
        public double Lemons;
        public double PricePerLemon;
        public double Sugar;
        public double PricePerSugarCup;
        public double Ice;
        public double PricePerCube;

        //constructor
        public Store()
        {
            PricePerCup = .05;
            PricePerLemon = .10;
            PricePerSugarCup = .10;
            PricePerCube = .01;
           
            
        }

        //member methods
        public void DisplayProducts()
        {
            Console.WriteLine($"\t Cups / 10 pack : {(PricePerCup * 10).ToString("C")} \n\t Lemons / 4 pack : {(PricePerLemon * 4).ToString("C")} \n\t Sugar / 4 cups : {(PricePerSugarCup * 4).ToString("C")} \n\t Ice cubes / bag of 50 : {(PricePerCube * 50).ToString("C")} \n");

        }
    }
}