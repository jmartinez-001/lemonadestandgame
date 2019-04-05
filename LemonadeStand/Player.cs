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
        public string item;
        public string orderquantity;
        public int LemonsPerBatch;
        public int SugarPerBatch;
        public int CupsPerBatch;
        public int IceCubesPerCup;
        public double PricePerCup;



        //constructor (Build This Thing)
        public Player()
        {
            money = 20.00;
            Inventory = new Inventory();
            
            
        }


        //member methods (Can Do)
        public void BuyInventory()
        {
            item = UserInterface.GetString("What do you want to buy? Type choice or 'H' for Homescreen.");
            orderquantity = UserInterface.GetString("How many orders? Enter Value or type 'C' to make another selection.");


            switch (orderquantity)
            {
                case "c":
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    BuyInventory();
                    break;
                default:
                    switch (item)
                    {
                        case "lemons":
                            Inventory.Lemons = (Inventory.Lemons += (int.Parse(orderquantity) * Store.LemonsPack));
                            Money = (Money - (Store.PricePerLemon * (Store.LemonsPack * int.Parse(orderquantity))));
                            break;
                        case "sugar":
                            Inventory.Sugar = (Inventory.Sugar += (int.Parse(orderquantity) * Store.SugarPack));
                            Money = (Money - (Store.PricePerSugarCup * (Store.SugarPack * int.Parse(orderquantity))));
                            break;
                        case "cups":
                            Inventory.Cups = (Inventory.Cups += (int.Parse(orderquantity) * Store.CupsPack));
                            Money = (Money - (Store.PricePerCup * (Store.CupsPack * int.Parse(orderquantity))));
                            break;
                        case "ice":
                            Inventory.Ice = (Inventory.Ice += (int.Parse(orderquantity) * Store.IceBag));
                            Money = (Money - (Store.PricePerCube * (Store.IceBag * int.Parse(orderquantity))));
                            break;
                        case "h":
                            //Game.GamePlanning(Player.Money);
                            break;
                        default:
                            UserInterface.ClearLine();
                            UserInterface.ClearLine();
                            BuyInventory();
                            break;
                    }
                    break;

            }
            
        
        }
        public void SetRecipe()
        {    
            
            
        }
        public void ConsumeInventory()
        {


        }
        public void DisplayCashFlow()
        {
            Console.WriteLine($"\t Business Net Cash Flow:\n\t {Money.ToString("C")}\n");

        }
        public void CheckCashOnHand(double price)
        {
            
        }
        

    }
}