using System;
using System.Collections.Generic;
using System.Text;

namespace Amanda_M_Slutprojekt_2020
{
    class Drink : Food //klass för drycker som ärver från Food
    {
        public Drink() //en konstruktor som lägger till drickor till menuItems
        {
            menuItems.Add("Flying Syrup", "sweet");
            menuItems.Add("Brewed Cocoa", "savoury");
            menuItems.Add("Warm Poppy Milk", "sour");
            menuItems.Add("Froglegmonade", "sour");
            menuItems.Add("Juiced Sage", "savoury");
            menuItems.Add("Goat's Breath Milkshake", "sweet");
        }
        //Get a bool method
        //if it is choice 1-3 cold = false
        //if it is choice 4-6 cold = true

        public string choiceDrink; //a string for player to choose the drink they want

        public bool isCold; //a bool to see if drink is cold or nah
        
    }
}
