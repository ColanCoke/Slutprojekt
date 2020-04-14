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
            foreach (string key in menuItems.Keys) //en foreach som använder stringen key för att skriva ut varje Key(dvs inskriven grej) i min dictionary
            {
                Console.WriteLine(key);
            }
        }

        int hungerfill;

        //Should make the dictionary of food-name-items here and make it a Virtual so the different classes can override?
    }
}
