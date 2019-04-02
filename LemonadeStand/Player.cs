using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        //member variables (Has A)
        private double money;
        public double Money
        {
            get => money;
            set
            {
                if (value <= 0)
                {
                    money = 0;
                }
                else if (money >= 100)
                {
                    money = 100;
                }
                else
                {
                    money = value;
                }

            }
        }
        public Recipe Recipe;
        public Inventory Inventory;



        //constructor (Build This Thing)
        public Player()
        {
            money = 20.00;
            Inventory = new Inventory();
            
            
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
        public void CheckCashFlow()
        {
            Console.WriteLine($"\t Business Net Cash Flow:\n\t {Money.ToString("C")}\n");

        }
    }
}