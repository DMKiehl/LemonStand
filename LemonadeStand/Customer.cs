using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        private List<string> names;
        public string name;
        Random myRandom = new Random();
        public int maxCupsCustomerWillBuy;
        public int tempThreshold;
        public double priceThreshold;

        //constructor
        public Customer()
        {
            names = new List<string> { "Dana", "Brad", "Fred", "Paul", "Chloe", "Shannon", "Teresa", "Aaron", "Brian", "Amy", "Ethan", "Dave", "Laurie", "Ken", "Lisa", "Kelly", "Tom", "Tony", "Trevor" };
            CustomerPreferences();

        }

        //member methods
        public void CustomerPreferences()
        {
            //assign name
            int index = myRandom.Next(names.Count);
            name = (names[index]);

            int min = 50;
            int max = 100;

            //assign temp
            tempThreshold = myRandom.Next(min, max);

            //assign price threshold
            priceThreshold = myRandom.NextDouble();

            
               


        }
            

    }
}
