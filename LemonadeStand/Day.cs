using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;
       
        //constructor
        public Day()
        {

        }

        //member methods

        public void DaysForecast(int currentDay)
        {
            weather = new Weather();
            weather.GetForecast(currentDay);
            Console.WriteLine("Weather Forecast: " + weather.condition + " " + weather.temperature + "F");
            
            //Console.ReadLine();

        }

        public void DaysActualWeather()
        {
            weather.ActualWeather(weather.condition, weather.temperature);
            Console.WriteLine("Today's weather is: " + weather.actualCondition + " " + weather.actualTemp + "F");
            Console.ReadLine();
        }

    }
}
