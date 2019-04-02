using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variables (Has A)
        public double Money;
        public Recipe Recipe;
        public Inventory Inventory;



        //constructor (Build This Thing)
        public Player()
        {
            Money = 20.00;
            
        }

        
       

        //member methods (Can Do)
        public void BuyInventory()
        {
            
        }

        public void SetRecipe()
        {
            Console.WriteLine($"What would you like to change:" );
            
        }

        public void ConsumeInventory()
        {

        }
    }
}