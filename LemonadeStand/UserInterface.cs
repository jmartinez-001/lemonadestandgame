using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    static class UserInterface
    {
        //member variables

        //constructor

        //member methods

        public static string GetString(string input)
        {
            Console.WriteLine(input);
            var result = Console.ReadLine();
            return result;
        }
        public static void DisplayBanner(Player player)
        {
            DisplayInventory();
            player.Inventory.DisplayCurrentInventory();
            player.DisplayCashFlow();

        }
        public static void Menu(Player player, Store store)
        {

            Console.Clear();
            Console.WriteLine("\t -MENU- \n");
            var choice = GetString("What do you want to do? \nCheck 'Inventory' \nGo to 'Store' \nCheck 'Weather' Forecast \nChange 'Recipe' \nGo to 'Work' \n");

            switch(choice)
            {
                case "inventory":
                    
                    player.Inventory.DisplayCurrentInventory();
                    Console.ReadLine();
                    Menu(player, store);
                    break;
                case "store":
                    store.SellItems(player);
                    break;
                case "weather":

                    break;
                case "recipe":
                    Console.Clear();
                    player.SetRecipe(store);
                    Menu(player, store);
                    break;
                case "work":
                    break;
                default:
                    Menu(player, store);
                    break;
            }


        }
        public static void WelcomeMessage()
        {
            Console.WriteLine("\t---------------Welcome to Lemonade Stand--------------- \n" +
                "-----Here is how the game will be played. You are a lemonade stand owner,-----\n" +
                "-----responsible for purchasing inventory and selling lemonade. Prior to------\n" +
                "-----every day, you will need to purchase stock and set your day's recipe.----\n" +
                "-----After a work day you will need to restock and check your sales. if-------\n" +
                "-----sales are low, you might need to adjust your recipe. Dont forget to------\n" +
                "-----check on the weather forecast regularly. You dont want to run out of-----\n" +
                "-----lemonade for thirsty customers.\n");
            
        }
        public static void DisplayStore()
        {
            Console.WriteLine("This is the store, you can purchase items needed to make and sell lemonade. \n");
            

        }
        public static void DisplayForecast()
        {

        }
        public static void DisplayRecipe()
        {
            Console.WriteLine("This is your current recipe, you can make adjustments to increase your chances of selling lemonade. \n");
        }
        public static void GoToWork()
        {

        }
        public static void DisplayInventory()
        {
            Console.WriteLine("\t Current Inventory:");

        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}