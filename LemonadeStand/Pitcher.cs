using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables
        public int cupsLeftInPitcher;
        public int cupsInPitcher;

        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
            cupsInPitcher = 12;
        }

        //member methods

        public void FillPitcher(Player player)
        {
            cupsLeftInPitcher = 12;

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
