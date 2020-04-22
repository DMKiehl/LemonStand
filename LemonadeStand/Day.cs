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
        public double transactionTotal;
        public double dailyTotal;
        public int cupTotal;
        public int dailyPitcherTotal;
        
       
        //constructor
        public Day(int currentDay)
        {
            customers = new List<Customer>();
            DaysForecast(currentDay);
            DaysActualWeather();
            transactionTotal = 0;
            dailyTotal = 0;

        }

        //member methods

        public void DaysForecast(int currentDay)
        {
            weather = new Weather();
            weather.GetForecast(currentDay);
            Console.WriteLine("\nWeather Forecast: " + weather.condition + " " + weather.temperature + "F");

        }

        public void DaysActualWeather()
        {
            weather.ActualWeather(weather.condition, weather.temperature);
            
        }

        public void PrintActualWeather()
        {
            Console.WriteLine("\nToday's weather is: " + weather.actualCondition + " " + weather.actualTemp + "F");
        }

        public void DailyCustomerNumber()
        {
            if(weather.actualCondition == "Sunny" && weather.actualTemp >= 80)
            {
                dailyCustomerNumber = 50;
            }
            else if (weather.actualCondition == "Sunny" && weather.actualTemp < 79 && weather.actualTemp >= 60 )
            {
                dailyCustomerNumber = 40;
            }
            else if (weather.actualCondition == "Sunny" && weather.actualTemp < 59)
            {
                dailyCustomerNumber = 25;
            }
            else if (weather.actualCondition == "Partly Cloudy" && weather.actualTemp >= 80)
            {
                dailyCustomerNumber = 45;
            }
            else if (weather.actualCondition == "Partly Cloudy" && weather.actualTemp < 79 && weather.actualTemp >= 60)
            {
                dailyCustomerNumber = 30;
            }
            else if (weather.actualCondition == "Partly Cloudy" && weather.actualTemp < 59)
            {
                dailyCustomerNumber = 25;
            }
            else if (weather.actualCondition == "Cloudy" && weather.actualTemp >= 80)
            {
                dailyCustomerNumber = 40;
            }
            else if (weather.actualCondition == "Cloudy" && weather.actualTemp < 79 && weather.actualTemp >= 60)
            {
                dailyCustomerNumber = 35;
            }
            else if (weather.actualCondition == "Cloudy" && weather.actualTemp < 59)
            {
                dailyCustomerNumber = 30;
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

                customer.CustomerSales(weather, player);

                if(customer.actualCupsToPurchase > player.pitcher.cupsLeftInPitcher)
                {
                    customer.actualCupsToPurchase = player.pitcher.cupsLeftInPitcher;
                }
                transactionTotal = player.recipe.pricePerCup * customer.actualCupsToPurchase;
                dailyTotal += transactionTotal;
                

                cupTotal += customer.actualCupsToPurchase;


                dailyCustomerNumber--;
                player.pitcher.cupsLeftInPitcher -= customer.actualCupsToPurchase;
            }
            
            
            
           
        }

        
    }
}
