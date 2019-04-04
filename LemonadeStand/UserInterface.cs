using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    static class UserInterface
    {
        //member variables
        private static int currentNumberOfPrintedLines;

        //constructor



        //member methods
        public static string GetString(string input)
        {
            Console.WriteLine(input);
            var result = Console.ReadLine();
            return result;
        }
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome... to Lemonade Stand Park!(Cue Jurassic Park Music). Your Mission, should you choose to accept it, will test your business savy and decision making skills. Your objective is to make a profit in a specified length of time. You will have all the tools you need at your disposal. Lie, cheat or steal; but as always, should any of your IM Force be caught or killed, the Secretary will disavow any knowledge of your actions. This computer will self-destruct in ten seconds. Good luck.");
            Console.WriteLine("Do you want to play? (y/n)");
            
        }
        public static void DisplayStore()
        {
            Console.WriteLine($"This is the store, you can purchase items needed to make and sell lemonade. \n");
            

        }
        public static void DisplayForecast()
        {

        }
        public static void GoToWork()
        {

        }
        public static void DisplayInventory()
        {
            Console.WriteLine("\t Current Inventory:");

        }
        public static void SellItem(string choice)
        {
            Console.WriteLine($"How many packs of {choice} would you like to purchase?");

        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}