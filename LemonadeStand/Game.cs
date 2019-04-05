using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables
        public Player player;
        public Store store;
        public List<Day> gamePlayDays;
        //public Day day;
        public static Random rnd;



        //constructor
        public Game()
        {
            store = new Store();
            player = new Player();
            //day = new Day();
            gamePlayDays = new List<Day>();
            rnd = new Random();



        }

        
        //member methods
        public void GameSetup()//Prompts the game instructions and objective, Prompts Play Game? (y/n), Prompts how long you would like to play for? (7 days, 14 days, 30 days)
        {
            UserInterface.WelcomeMessage();
            Console.ReadLine();
            //GamePlanning();
            




        }
        public void GameLength()
        {
            int gameLength = int.Parse(UserInterface.GetString("How many days would you like to play for?"));
       
            for (var i = 0; i < gameLength; i++)
            {
                Day day = new Day();
                day.Weather.GenerateConditions();
                day.Weather.GenerateDailyWeather();
                day.Weather.GenerateWeatherFactor();
                day.PotentialCustomers();
                day.CustomerGenerator();
                gamePlayDays.Add(day);

            }

        }
        public void CreateDay()
        {

        }
        public static void GamePlanning(Player player)
        {
            Console.Clear();
            UserInterface.DisplayInventory();
            player.Inventory.DisplayCurrentInventory();
            player.DisplayCashFlow();

        }
        public void RunTheMatrix()//Starts simulation, Work from 9-5, generate customers, consume lemonade cups, make lemonade batches, consume ingredients.
        {

        }
        public void GoToStore()   
        {

            Console.Clear();
            UserInterface.DisplayStore();
            store.DisplayProducts();
            UserInterface.DisplayInventory();
            player.Inventory.DisplayCurrentInventory();
            player.DisplayCashFlow();            
            player.BuyInventory();
            

            GoToStore();
            

        }
        public void CheckWeather()
        {

        }
        public void ChangeRecipe()
        {

        }

        public void Validate(string entry)
        {
            
            

            
        }
    }
}