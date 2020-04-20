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
        public int dailyCustomerNumber;
       
        //constructor
        public Day(int currentDay)
        {
            customers = new List<Customer>();
            DaysForecast(currentDay);
            DaysActualWeather();
        }

        //member methods

        public void DaysForecast(int currentDay)
        {
            weather = new Weather();
            weather.GetForecast(currentDay);
            Console.WriteLine("Weather Forecast: " + weather.condition + " " + weather.temperature + "F");

        }

        public void DaysActualWeather()
        {
            weather.ActualWeather(weather.condition, weather.temperature);
            
        }

        public void PrintActualWeather()
        {
            Console.WriteLine("Today's weather is: " + weather.actualCondition + " " + weather.actualTemp + "F");
        }

        public void DailyCustomerNumber()
        {
            if(weather.actualCondition == "Sunny")
            {
                dailyCustomerNumber = 50;
            }
            else if (weather.actualCondition == "Overcast")
            {
                dailyCustomerNumber = 45;
            }
            else if (weather.actualCondition == "Cloudy")
            {
                dailyCustomerNumber = 40;
            }
            else if (weather.actualCondition == "Windy")
            {
                dailyCustomerNumber = 30;
            }
            else if (weather.actualCondition == "Rain")
            {
                dailyCustomerNumber = 20;
            }
            else
            {
                dailyCustomerNumber = 10;
            }
        }



        public void SellLemonade(Player player)
        {
            while(player.pitcher.cupsLeftInPitcher > 0)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                

                player.pitcher.cupsLeftInPitcher--;
            }
            
            
            
           
        }

        
    }
}
