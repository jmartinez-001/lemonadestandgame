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
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome... to Lemonade Stand Park!(Cue Jurassic Park Music). Your Mission, should you choose to accept it, will test your business savy and decision making skills. Your objective is to make a profit in a specified length of time. You will have all the tools you need at your disposal. Lie, cheat or steal; but as always, should any of your IM Force be caught or killed, the Secretary will disavow any knowledge of your actions. This computer will self-destruct in ten seconds. Good luck.");
            Console.WriteLine("Do you want to play? (y/n)");
            Console.ReadLine();
        }
        public static void DisplayStore()
        {
            Console.WriteLine($"This is the store, you can purchase items needed to make and sell lemonade. \r\nWhat would you like to purchase? \r\n");
            

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
        
    }
}