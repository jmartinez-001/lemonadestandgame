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


        //constructor (Build This Thing)
        public Player()
        {
            Money = 20.00;
            
        }

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }

        //member methods (Can Do)
        public void BuyInventory()
        {
            
        }

        public void SetRecipe()
        {
            
        }

        public void ConsumeInventory()
        {

        }
    }
}