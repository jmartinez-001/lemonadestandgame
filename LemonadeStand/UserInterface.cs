using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    static class UserInterface
    {
        //member variables
        //private static int currentNumberOfPrintedLines;

        //constructor



        //member methods

        public static string GetString(string input)
        {
            Console.WriteLine(input);
            var result = Console.ReadLine();
            return result;
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
            Console.WriteLine("Welcome... to Lemonade Stand Park!(Cue Jurassic Park Music). \nYour Mission, should you choose to accept it, will test \nyour business savy and decision making skills. Your objective \nis to make a profit in a specified length of time. \nYou will have all the tools you need at your disposal. \nLie, cheat or steal; but as always, \nshould any of your IM Force be caught or killed, \nthe Secretary will disavow any knowledge of your actions. \nThis computer will self-destruct in ten seconds. \nGood luck.");
            Console.WriteLine("Do you want to play? (y/n)");
            
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