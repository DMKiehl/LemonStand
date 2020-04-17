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

        //constructor
        public Weather()
        {
            weatherConditions = new List<string> { "Sunny", "Overcast", "Cloudy", "Rain", "Thunder", "Windy"};
        }


       
        public void GetForecast()
        {
            int index = myRandom.Next(weatherConditions.Count);
            condition = (weatherConditions[index]);

            int min = 50;
            int max = 100;
            temperature = myRandom.Next(min, max);

        }
        //member methods


    }
}
