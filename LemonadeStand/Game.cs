using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
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
                Console.WriteLine("Welcome to Day " + currentDay + "!");
                Day newDay = new Day(currentDay);
                days.Add(newDay);
               
                StartDayDisplay();
                player.DisplayCurrentRecipe();
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
      
        public void EndDay(Day day)
        {
            player.wallet.AddProfitToWallet(day.dailyTotal);
            Console.WriteLine("\nDaily Total: " + day.dailyTotal);
            Console.WriteLine("Total cups sold today: " + day.cupTotal);
            Console.WriteLine("Overall Total: " + player.wallet.Money);
            //display daily profits and losses
            //display total profits and losses thus far  
            totalEarned += day.dailyTotal;
        }

      

      
    }
}
