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
        public double inventoryLoss;
            

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
      
        public void MeltIce()
        {
            Console.WriteLine(inventory.iceCubes.Count + "ice cubes have melted.");
            inventoryLoss += (inventory.iceCubes.Count * store.pricePerIceCube);
            inventory.RemoveIceCubesFromInventory(inventory.iceCubes.Count);
        }

        public void EndCalculations(double totalEarned)
        {
            Console.WriteLine("\nTotal earned at Lemonade Stand: $" + totalEarned);
            Console.WriteLine("Total expenses: $" + store.supplyExpenses);
            Console.WriteLine("Total inventory losses: $" + inventoryLoss);

            Console.WriteLine("Net profits: $" + (totalEarned - store.supplyExpenses - inventoryLoss));
            Console.ReadLine();
            
        }



    }


}
