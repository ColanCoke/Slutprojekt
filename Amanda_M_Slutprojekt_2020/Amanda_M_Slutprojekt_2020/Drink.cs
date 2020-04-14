using System;
using System.Collections.Generic;
using System.Text;

namespace Amanda_M_Slutprojekt_2020
{
    class Drink : Food
    {
        public Drink() //en konstruktor som lägger till drickor till menuItems
        {
            menuItems.Add("Flying Syrup", "sweet");
            menuItems.Add("Brewed Cocoa", "savoury");
            menuItems.Add("Poppy Milk", "sour");
            menuItems.Add("Froglegmonade", "sour");
            menuItems.Add("Juiced Sage", "savoury");
            menuItems.Add("Goat's Breath Milkshake", "sweet");
        }
        //Get a bool method
        //if it is choice 1-3 cold = false
        //if it is choice 4-6 cold = true

        public string choiceDrink;

        public virtual bool Cold()
        {
            return false;
        }

        
    }
}
