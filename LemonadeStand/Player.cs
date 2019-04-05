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
        public Inventory Inventory;
        
        public int LemonsPerBatch;
        public int SugarPerBatch;
        public int CupsPerBatch;
        public int IceCubesPerCup;
        public double CostPerCup;



        //constructor (Build This Thing)
        public Player()
        {
            money = 20.00;
            Inventory = new Inventory();
            LemonsPerBatch = 2;
            SugarPerBatch = 3;
            CupsPerBatch = 10;
            IceCubesPerCup = 4;
            CostPerCup = .25;
            
            
        }


        //member methods (Can Do)
        public void BuyInventory(Store store)
        {
            var item = UserInterface.GetString("What do you want to buy? Enter choice or 'H' for Homescreen.");
            var orderquantity = UserInterface.GetString("How many orders? Enter Value or type 'C' to make another selection.");


            switch (orderquantity)
            {
                case "c":
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    BuyInventory(store);
                    break;
                case "h":
                    UserInterface.Menu(this, store);
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
                        
                        default:
                            UserInterface.ClearLine();
                            UserInterface.ClearLine();
                            BuyInventory(store);
                            break;
                    }
                    break;

            }
            
        
        }
        public void SetRecipe(Store store)
        {
            Console.WriteLine($"\t 'Cost' per Cup : {CostPerCup.ToString("C")} \n\t 'Lemons' / Batch  : {LemonsPerBatch.ToString()} \n\t 'Sugar'(cups) / Batch : {SugarPerBatch.ToString()} \n\t 'Ice' cubes / Cup : {IceCubesPerCup.ToString()} \n");
            var item = UserInterface.GetString("What do you want to change? Enter choice or 'H' for HomeScreen.");
            var quantity = UserInterface.GetString($"What do you want to change {item} to? Enter Value or type 'C' to make another selection.");

            switch (quantity)
            {
                case "c":
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    UserInterface.ClearLine();
                    SetRecipe(store);
                    break;
                default:
                    switch (item)
                    {
                        case "lemons":
                            LemonsPerBatch = int.Parse(quantity);
                            break;
                        case "sugar":
                            SugarPerBatch = int.Parse(quantity);
                            break;
                        case "cost":
                            CostPerCup = double.Parse(quantity);
                            break;
                        case "ice":
                            IceCubesPerCup = int.Parse(quantity);
                            break;
                        case "h":
                            UserInterface.Menu(this, store);
                            break;
                        default:
                            UserInterface.ClearLine();
                            UserInterface.ClearLine();
                            SetRecipe(store);
                            break;
                    }
                    break;

            }


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