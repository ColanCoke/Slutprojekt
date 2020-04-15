using System;
using System.Collections.Generic;
using System.Text;

namespace Amanda_M_Slutprojekt_2020
{
    public class Customer
    {
        public Customer() //en konstruktor som randomiserar en Customers flavour preference
        {
            string[] arrPref = new string[] { "sweet", "sour", "savoury" }; //an array for the different kinds of preferences
            Random gen = new Random(); //random generator
            int pref = gen.Next(0, 3); //randomiserar en siffra som korresponderar med en plats i arrayn
            preference = arrPref[pref]; //säger att preference är den delen i listan som pref korresponderar med

            //random generator
            int cold = gen.Next(1, 2);

            if (cold == 1)
            {
                coldPref = true;
                
            }
            else
            {
                coldPref = false;
            }

        }

        bool coldPref;
        string preference; //string för preference så det kan användas genom hela klassen

        public string GetPreference() //metod som skriver ut customers preference
        {
            return preference;
        }
        public string GetColdPref()
        {
            if (coldPref == true)
            {
                return "They prefers cold drinks!";
            }

            return "They prefers warm drinks!";
        }
        

        public void Score()
        {
            
        }


        //Make an array or list containing preferences and name it preferences.
        //Then you can use that list to reference it with a variable/string

        /* customers has a hidden hierarchy of things they like (Constructor):
         The only one that shows up for the player is the "most liked" attribute. (maybe it should only show liked and you have
         to guess their absolute favourite? hmm...)Anyway this should randomise the score a bit more so that the player can still
         earn points if they choose the wrong kind of order (or completely mess it up if they want to do that) 

         So there should be a method that randomises the list of preferences and chooses the order of how much customer likes
         preferences.

         Should be a method that helps count the score? maybe?

         If time: Add random words that are used to describe the customers as they enter
         Dictionary for that.

        */

    }
}
