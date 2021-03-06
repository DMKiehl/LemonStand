﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //SOLID - S - Single Responsibility Principle. The game classes responsibility is to run the game from start to finish. 
        //It welcomes the player, allows the player to set the number of days they want to play. Is responsible for displays the start display which shows the current inventory and money available.
        //The play game method calls the methods used to run the entire game on a day to day basis.
        
        //member variables
        private Player player;
        private List<Day> days;
        private int currentDay;
        public int totalDaysToPlay;
        public double totalEarned;
        
        
        //constructor
        public Game()
        {
            player = new Player();
            currentDay = 1;
            days = new List<Day>();
            

        }

        //member methods
        public void PlayGame()
        {
            Console.WriteLine("\nWelcome to Lemonade Stand " + player.name + "!");
            SetDays();
            while(totalDaysToPlay > 0)
            {
                Console.WriteLine("\nWelcome to Day " + currentDay + "!");
                Day newDay = new Day(currentDay);
                days.Add(newDay);
               
                StartDayDisplay();
                DisplayCurrentRecipe(player);
                player.GoToStore(player);

                
                player.recipe.SetRecipe();

                newDay.PrintActualWeather();
                newDay.DailyCustomerNumber();

                while (player.inventory.lemons.Count >= player.recipe.amountofLemons && player.inventory.iceCubes.Count >= player.recipe.amountOfIceCubes && player.inventory.cups.Count >= player.pitcher.cupsInPitcher && player.inventory.sugarCubes.Count >= player.recipe.amountOfSugarCubes && newDay.dailyCustomerNumber > 0)
                {
                    player.pitcher.FillPitcher(player);
                    newDay.SellLemonade(player);


                }

                EndDay(newDay);
                

                currentDay++;
                totalDaysToPlay--;
            }
            player.EndCalculations(totalEarned);
            

        }
        public void SetDays()
        {
            Console.WriteLine("\nHow many days would you like to play? 7 or 14");
            int input = Convert.ToInt32(Console.ReadLine()); 

            if (input == 7)
            {
                totalDaysToPlay = input;
            }
            else if (input == 14)
            {
                totalDaysToPlay = input;
            }
            else
            {
                Console.WriteLine("\nNot valid option, please select again");
                SetDays();
            }
            
           
        }

        public void StartDayDisplay()
        {
            Console.WriteLine("\nMoney available: $" + player.wallet.Money);
            Console.WriteLine("\nCurrent inventory: \nLemons: " + player.inventory.lemons.Count + "\nSugar Cubes: " + player.inventory.sugarCubes.Count + "\nCups: " + player.inventory.cups.Count + "\nIce Cubes: " + player.inventory.iceCubes.Count);
        }

        public void DisplayCurrentRecipe(Player player)
        {
            Console.WriteLine("\nCurrent recipe: \nLemons: " + player.recipe.amountofLemons + "\nSugar Cubes: " + player.recipe.amountOfSugarCubes + "\nIce Cubes: " + player.recipe.amountOfIceCubes + "\nPrice Per Cup: " + player.recipe.pricePerCup);
            Console.WriteLine("\nTotal number of cups per pitcher: " + player.pitcher.cupsInPitcher);

        }

        public void EndDay(Day day)
        {
            player.MeltIce();
            player.wallet.AddProfitToWallet(day.dailyTotal);
            totalEarned += day.dailyTotal;
            Console.WriteLine("\nDaily Total: $" + day.dailyTotal);
            Console.WriteLine("Total cups sold today: " + day.cupTotal);
            Console.WriteLine("Total earned to date: $" + totalEarned);
            Console.WriteLine("Total available: $" + player.wallet.Money);
            
            
        }

      

      
    }
}
