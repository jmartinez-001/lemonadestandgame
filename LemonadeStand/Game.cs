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
        public int CurrentDay;
        public List<string> weekForecast;
        //public Day day;
        public static Random rnd;



        //constructor
        public Game()
        {
            store = new Store();
            player = new Player();
            //day = new Day();
            gamePlayDays = new List<Day>();
            weekForecast = new List<string>();
            rnd = new Random();



        }

        
        //member methods
        public void GameSetup()//Prompts the game instructions and objective, Prompts Play Game? (y/n), Prompts how long you would like to play for? (7 days, 14 days, 30 days)
        {
            UserInterface.WelcomeMessage();
            UserInterface.GetString("\t-----Do you want to Play?(y/n)-----");
            GameLength();
            UserInterface.Menu(player, store);
            




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
        public void WeekForecast()
        {
            int week = 7;
            for (var i = 0; i < week; i++)
            {
                //weekForecast.Add(CurrentDay);
            }
        }
        public void CreateDay()//method will have a for loop that loops created list of days to play within those contstraints and customers.
        {

        }
        
        public void RunTheMatrix()//Starts simulation, Work from 9-5, generate customers, consume lemonade cups, make lemonade batches, consume ingredients.
        {

        }
        
        public void CheckWeather()//Display a 7 day forecast
        {

        }
        public void ChangeRecipe()
        {

            Console.Clear();
            UserInterface.DisplayRecipe();
            player.SetRecipe(store);
            ChangeRecipe();

        }

        public void Validate(string entry)
        {
            
            

            
        }
    }
}