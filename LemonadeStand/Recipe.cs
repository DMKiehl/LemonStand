using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        public int amountofLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        //constructor
        public Recipe()
        {
            amountofLemons = 3;
            amountOfSugarCubes = 10;
            amountOfIceCubes = 24;
            pricePerCup = .25;
        }

        //member methods
        public void SetRecipe()
        {
            Console.WriteLine("\nWould you like to adjust the recipe or Price per cup?");
            string input = Console.ReadLine();
            if (input == "yes" || input == "Yes")
            {
                Console.WriteLine("How many lemons would you like to use?");
                amountofLemons = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nHow many sugar cubes would you like to use?");
                amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nHow many ice cubes would you like to use per pitcher?");
                amountOfIceCubes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nHow much would you like to charge per cup of lemonade?");
                pricePerCup = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("New recipe: \nLemons: " + amountofLemons + "\nSugar Cubes: " + amountOfSugarCubes + "\nIce Cubes: " + amountOfIceCubes + "\nPrice Per Cup: " + pricePerCup);


            }

        }
    }
}
