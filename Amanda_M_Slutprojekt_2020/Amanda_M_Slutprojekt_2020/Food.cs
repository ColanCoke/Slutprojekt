using System;
using System.Collections.Generic;
using System.Text;

namespace Amanda_M_Slutprojekt_2020
{
    class Food
    {
        //dictionary for the different menu items
        public Dictionary<string, string> menuItems = new Dictionary<string, string>();

        /*
        public void GetMenuItems()
        {
            List<string> menuList = new List<string>(this.menuItems.Keys);
            Console.WriteLine(menuList);
        }
        */

        public void GetMenuItems()
        {
            foreach (string key in menuItems.Keys)
            {
                Console.WriteLine(key);
            }
        }

        int hungerfill;

        //Should make the dictionary of food-name-items here and make it a Virtual so the different classes can override?
    }
}
