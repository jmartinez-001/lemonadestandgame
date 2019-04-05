using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        public double Cups;
        public double Lemons;
        public double Sugar;
        public double Ice;

        //constructor
        public Inventory()
        {
            Cups = 0;
            Lemons = 0;
            Sugar = 0;
            Ice = 0;
        }

        //member methods 
       public void DisplayCurrentInventory()
        {
            Console.Clear();
            Console.WriteLine("This is your current inventory, you can purchase inventory at the store to prepare for the work day.\n");
            Console.WriteLine($"\t Cups : {Cups} \n\t Lemons : {Lemons} \n\t Sugar : {Sugar} \n\t Ice cubes : {Ice} \n");

        }

    }
}