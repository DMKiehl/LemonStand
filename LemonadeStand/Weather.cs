using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        Random myRandom = new Random();
        public string actualCondition;
        public int actualTemp;
        public int index;
        

        //constructor
        public Weather()
        {
            weatherConditions = new List<string> { "Sunny", "Partly Cloudy", "Cloudy", "Windy", "Rain", "Thunder"};

        }


        //member methods
        public int GetForecast(int currentDay)
        {
            index = myRandom.Next(weatherConditions.Count);
            condition = (weatherConditions[index]);

            int min = 50;
            int max = 100;
            temperature = myRandom.Next(min, max);

            return index;

        }

        public void ActualWeather(string newCondition, int newTemperature)
        {
            int min = temperature -= 3;
            int max = temperature += 3;
            actualTemp = myRandom.Next(min, max);

            int minLocation = index -= 1;
            int maxLocation = index += 1;

            if (minLocation == -1)
            {
                minLocation = 0;
            }

            if (maxLocation == 6)
            {
                maxLocation = 5;
            }

            index = myRandom.Next(minLocation, maxLocation);
            actualCondition = (weatherConditions[index]);


        }


    }
}
