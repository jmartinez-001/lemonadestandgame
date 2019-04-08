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
        public int WeatherFactor;
        public int Temperature;
        public int Condition;
        public string[] WeatherConditions;
        public string[] WeekForecast;


        //constructor
        public Weather()
        {
            WeatherConditions = new string[] { "Rainy", "Cloudy", "Sunny", "Scorcher" };
            WeekForecast = new string[7];

        }


        //member methods        
        public void GenerateConditions()
        {

            Condition = Game.rnd.Next(0, 4);
            switch (Condition)
            {
                case 0:
                    Temperature = Game.rnd.Next(60, 70);
                    break;
                case 1:
                    Temperature = Game.rnd.Next(70, 80);
                    break;
                case 2:
                    Temperature = Game.rnd.Next(80, 90);
                    break;
                case 3:
                    Temperature = Game.rnd.Next(90, 100);
                    break;
                default:
                    break;
            }


        }
        public void GenerateDailyWeather()
        {
            ActualWeather = ($"{Temperature} and {WeatherConditions[Condition]}");

        }
        public void GenerateWeekForecast()
        {
            for(var i = 0; i < WeekForecast.Length; i++)
            {
                GenerateConditions();
                GenerateDailyWeather();
                WeekForecast[i] = ActualWeather;
            }
        }
        public void GenerateWeatherFactor()
        {
            var n = Temperature;
            
            if(n >= 60 && n <= 63)
            {
                WeatherFactor = 1;
            }
            else if(n >= 64 && n <= 67)
            {
                WeatherFactor = 2;
            }
            else if (n >= 68 && n <= 71)
            {
                WeatherFactor = 3;
            }
            else if (n >= 72 && n <= 75)
            {
                WeatherFactor = 4;
            }
            else if (n >= 76 && n <= 79)
            {
                WeatherFactor = 5;
            }
            else if (n >= 80 && n <= 83)
            {
                WeatherFactor = 6;
            }
            else if (n >= 84 && n <= 87)
            {
                WeatherFactor = 7;
            }
            else if (n >= 88 && n <= 91)
            {
                WeatherFactor = 8;
            }
            else if (n >= 92 && n <= 95)
            {
                WeatherFactor = 9;
            }
            else if (n >= 96 && n <= 99)
            {
                WeatherFactor = 10;
            }



        }
    }
}