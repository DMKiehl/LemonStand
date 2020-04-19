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
        private int currentDay = 1;
        public int totalDaysToPlay;

        //constructor
        public Game()
        {
            player = new Player();

        }

        //member methods
        public void PlayGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            SetDays();
            while(totalDaysToPlay > 0)
            {


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
    }
}
