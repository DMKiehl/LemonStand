using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        private Store store;
            

        // constructor (SPAWNER)
        public Player()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            store = new Store();
        }

        // member methods (CAN DO)
        public void DisplayCurrentRecipe()
        {
            Console.WriteLine("\nCurrent recipe: \nLemons: " + recipe.amountofLemons + "\nSugar Cubes: " + recipe.amountOfSugarCubes + "\nIce Cubes: " + recipe.amountOfIceCubes + "\nPrice Per Cup: " + recipe.pricePerCup);
            Console.WriteLine("\nTotal number of cups per pitcher: " + pitcher.cupsInPitcher);
      
        }

        public void GoToStore(Player player)
        {
            Console.WriteLine("\nWould you like to go to the store?");
            string input = Console.ReadLine();
            if (input == "yes" || input == "Yes")
            {
                store.SellLemons(player);
                store.SellSugarCubes(player);
                store.SellIceCubes(player);
                store.SellCups(player);
                
                Console.WriteLine("\nMoney left: $" + player.wallet.Money);
                Console.WriteLine("\nCurrent inventory: \nLemons: " + player.inventory.lemons.Count + "\nSugar Cubes: " + player.inventory.sugarCubes.Count + "\nCups: " + player.inventory.cups.Count + "\nIce Cubes: " + player.inventory.iceCubes.Count);
            }
           

        }
      

        public void EndCalculations(double totalEarned)
        {
            Console.WriteLine("\nTotal earned at Lemonade Stand: $" + totalEarned);
            Console.WriteLine("Total expenses: $" + store.supplyExpenses);

            Console.WriteLine("Net profits: $" + (totalEarned - store.supplyExpenses));
            Console.ReadLine();
            
        }



    }


}
