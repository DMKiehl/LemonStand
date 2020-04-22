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
        public int CupsCustomerWillBuy;
        public int tempLowThreshold;
        public int tempHighThreshold;
        public double priceThreshold;
        public int actualCupsToPurchase;

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

            int min = 60;
            int max = 69;

            //assign temp
            tempLowThreshold = myRandom.Next(min, max);

            int low = 70;
            int high = 80;

            tempHighThreshold = myRandom.Next(low, high);

            //assign price threshold
            double minimum = .20;
            double maximum = .50;
            priceThreshold = myRandom.NextDouble() * (maximum - minimum) + minimum;


            CupsCustomerWillBuy = myRandom.Next(1, 3);

        }

        public int CustomerSales(Weather weather, Player player)
        {
            if (player.recipe.pricePerCup > priceThreshold)
            {
                actualCupsToPurchase = 0;
            }
            else if (tempLowThreshold <= weather.actualTemp && weather.actualTemp <= tempHighThreshold)
            {
                actualCupsToPurchase = CupsCustomerWillBuy;
            }

            else if (weather.actualTemp < tempLowThreshold)
            {
                actualCupsToPurchase = CupsCustomerWillBuy - 1;
            }
           
            else
            {
                actualCupsToPurchase = CupsCustomerWillBuy + 1;
            }

            return actualCupsToPurchase;

        }
            

    }
}
