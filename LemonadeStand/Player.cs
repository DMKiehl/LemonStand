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

        // constructor (SPAWNER)
        public Player()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)

        public void GoToStore()
        {

        }
    }
}
