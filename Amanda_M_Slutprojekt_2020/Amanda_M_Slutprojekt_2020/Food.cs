using System;
using System.Collections.Generic;
using System.Text;

namespace Amanda_M_Slutprojekt_2020
{
    class Food
    {
        //dictionary for the different menu items
        public Dictionary<string, string> menuItems = new Dictionary<string, string>();


        public void GetMenuItems() //metod för att skriva ut menu items
        {
            /*
            //en foreach som använder stringen key för att skriva ut varje Key(dvs inskriven grej) i min dictionary
            foreach (string key in menuItems.Keys)
            {
                Console.WriteLine(key);

            }
            */

            foreach (KeyValuePair<string, string> item in menuItems)  //en foreach som skriver ut både keys och values i min dictionary
            {
                Console.WriteLine(item.Key + " | Flavour: " + item.Value); //separerar keys och flavours på ett snyggare sätt i koden
            }
        }

        int hungerfill;

        //Should make the dictionary of food-name-items here and make it a Virtual so the different classes can override?
    }
}
