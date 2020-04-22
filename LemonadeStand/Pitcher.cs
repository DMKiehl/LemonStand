using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //SOLID - S - Pitcher class is responsible for filling the pitcher throughout the day and keeping track of how many cups are left in the pitcher.
        //member variables
        public int cupsLeftInPitcher;
        public int cupsInPitcher;

        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
            cupsInPitcher = 15;
        }

        //member methods

        public void FillPitcher(Player player)
        {
            cupsLeftInPitcher = 15;

            if (player.inventory.lemons.Count >= player.recipe.amountofLemons)
            {
                player.inventory.RemoveLemonsFromInventory(player.recipe.amountofLemons);
            }

            if (player.inventory.sugarCubes.Count >= player.recipe.amountOfSugarCubes)
            {
                player.inventory.RemoveSugarFromInventory(player.recipe.amountOfSugarCubes);
            }

            if (player.inventory.iceCubes.Count >= player.recipe.amountOfIceCubes)
            {
                player.inventory.RemoveIceCubesFromInventory(player.recipe.amountOfIceCubes);
            }

            if (player.inventory.cups.Count >= player.pitcher.cupsInPitcher)
            {
                player.inventory.RemoveCupsFromInventory(cupsInPitcher);
            }

        }


    }
}
