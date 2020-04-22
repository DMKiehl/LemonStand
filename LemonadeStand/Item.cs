using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Item
    {
        //SOLID - O - By using this parent class and creating the child classes it would allow me to add additional concepts and functions to further the game experience, such as adding 
        //ice melting or spoilage to the game without changing the code. A spoilage variable would be added to the item class and a number would be assigned to the variable in each child class. 
        //A method would be added during the game play to apply the spoilage.

        // member variables (HAS A)
        public string name;
        

        // constructor (SPAWNER)
        static Item()
        {

        }

        // member methods (CAN DO)
    }
}
