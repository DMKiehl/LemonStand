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

        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 12;
        }

        //member methods

        public void FillPitcher(Player player)
        {
            player.inventory.RemoveLemonsFromInventory(player.recipe.amountofLemons);
            player.inventory.RemoveSugarFromInventory(player.recipe.amountOfSugarCubes);
            player.inventory.RemoveIceCubesFromInventory(player.recipe.amountOfIceCubes);
            player.inventory.RemoveCupsFromInventory(cupsLeftInPitcher);

            cupsLeftInPitcher = 12;

        }


    }
}
