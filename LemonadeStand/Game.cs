using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables
        public Player Player;
        public Store Store;
        public List<Day> Day;

        //constructor
        public Game()
        {
            Store = new Store();
            Player = new Player();
            
        }

        
        //member methods
        public void GameSetup()//Prompts the game instructions and objective, Prompts Play Game? (y/n), Prompts how long you would like to play for? (7 days, 14 days, 30 days)
        {
            UserInterface.WelcomeMessage();


        }
        public void RunTheMatrix()//Starts simulation, Work from 9-5, generate customers, consume lemonade cups, make lemonade batches, consume ingredients.
        {

        }
        public void GoToStore()   
        {

            Console.Clear();
            UserInterface.DisplayStore();
            Store.DisplayProducts();
            UserInterface.DisplayInventory();
            Player.Inventory.DisplayCurrentInventory();
            Player.CheckCashFlow();
            Console.ReadLine();
            GoToStore();
            

        }

    }
}