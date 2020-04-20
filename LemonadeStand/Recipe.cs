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
            amountofLemons = 4;
            amountOfSugarCubes = 10;
            amountOfIceCubes = 48;
            pricePerCup = .25;
        }

        //member methods
        public void SetRecipe()
        {

        }

    }
}
