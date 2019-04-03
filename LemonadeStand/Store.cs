using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        //member variables
        public static double CupsPack;
        public static double PricePerCup;
        public static double LemonsPack;
        public static double PricePerLemon;
        public static double SugarPack;
        public static double PricePerSugarCup;
        public static double IceBag;
        public static double PricePerCube;

        //constructor
        public Store()
        {
            PricePerCup = .05;
            PricePerLemon = .10;
            PricePerSugarCup = .10;
            PricePerCube = .01;
            CupsPack = 10;
            LemonsPack = 4;
            SugarPack = 4;
            IceBag = 50;
           
            
        }

        //member methods
        public void DisplayProducts()
        {
            Console.WriteLine($"\t Cups / 10 pack : {(PricePerCup * 10).ToString("C")} \n\t Lemons / 4 pack : {(PricePerLemon * 4).ToString("C")} \n\t Sugar / 4 cups : {(PricePerSugarCup * 4).ToString("C")} \n\t Ice cubes / bag of 50 : {(PricePerCube * 50).ToString("C")} \n");

        }
    }
}