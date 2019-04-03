using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        public string ActualWeather;
        public int Temperature;
        public int Condition;
        //public Dictionary<int, string> WeatherConditions;
        //public Tuple<int, string> WeatherConditions;
        public string[] WeatherConditions;
        public int[] WeekForecast;
        Random rnd = new Random();


        //constructor
        public Weather()
        {
            WeatherConditions = new string[] { "Rainy", "Cloudy", "Sunny" };

        }


        //member methods
        public void GenerateDailyWeather()
        {
            ActualWeather = ($"{Temperature} and {WeatherConditions[Condition]}");
          
        }
        public void GenerateConditions()
        {

            Condition = rnd.Next(0, 3);
            switch (Condition)
            {
                case 0:
                    Temperature = rnd.Next(60, 70);
                    break;
                case 1:
                    Temperature = rnd.Next(70, 80);
                    break;
                case 2:
                    Temperature = rnd.Next(80, 90);
                    break;
                default:
                    break;
            }


        }
    }
}