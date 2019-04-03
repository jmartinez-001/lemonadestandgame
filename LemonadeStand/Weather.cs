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
        //public int TempRange;
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
        public void GenerateTemp()
        {
            Temperature = rnd.Next(70, 100);
          //  Temperature = TempRange;
        }
        public void GenereateConditions()
        {
            //var values = Enum.GetValues(typeof(WeatherConditions));
            // Condition = values.GetValue(1);

            Condition = rnd.Next(0, 4);

        }
    }
}