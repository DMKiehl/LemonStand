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
            Console.WriteLine("Welcome to Lemonade Stand " + player.name + "!");
            SetDays();
            while(totalDaysToPlay > 0)
            {
                Day newDay = new Day();
                newDay.DaysForecast(currentDay);
                //add day to list??

                StartDayDisplay();
                player.DisplayCurrentRecipe();

                newDay.DaysActualWeather();
                StartDay();




                currentDay++;
                totalDaysToPlay--;
            }

        }
        public void SetDays()
        {
            Console.WriteLine("How many days would you like to play? 7 or 14");
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
                Console.WriteLine("Not valid option, please select again");
                SetDays();
            }
            
           
        }

        public void StartDayDisplay()
        {
            

            Console.WriteLine("Money available: $" + player.wallet.Money);
            Console.WriteLine("Current inventory: \nLemons: " + player.inventory.lemons.Count + "\nSugar Cubes: " + player.inventory.sugarCubes.Count + "\nCups: " + player.inventory.cups.Count + "\nIce Cubes: " + player.inventory.iceCubes.Count);

            Console.WriteLine("Would you like to go to the store?");
            string input = Console.ReadLine();
            if (input == "yes" || input == "Yes")
            {
                player.GoToStore(player);
                //send player to store to purchase inventory
                Console.WriteLine("Money left: $" + player.wallet.Money);
                Console.WriteLine("Current inventory: \nLemons: " + player.inventory.lemons.Count + "\nSugar Cubes: " + player.inventory.sugarCubes.Count + "\nCups: " + player.inventory.cups.Count + "\nIce Cubes: " + player.inventory.iceCubes.Count);
            }

           
        }

        public void StartDay()
        {

            player.pitcher.FillPitcher(player);

        }

        public void EndDay()
        {

        }

      
    }
}
