using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();

            //game.GoToStore();
            game.day.Weather.GenerateConditions();
            game.day.Weather.GenerateDailyWeather();
            game.day.Weather.GenerateWeatherFactor();
            Console.WriteLine(game.day.Weather.ActualWeather);
            Console.WriteLine(game.day.Weather.WeatherFactor);
            Console.ReadLine();
            
            
        }
    }
}
