using System;

namespace Amanda_M_Slutprojekt_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Witchy Brews, the café where we know more about what you want than you do!");
            Console.WriteLine("You are the owner, having an ability to 'read' incoming costumers to find out what they want.");
            Console.WriteLine("You get to choose a drink and then the optional choices of meal and/or side.");
            Console.WriteLine("Do you want a tutorial?");

            /*
             Ready for customer?
             YesNo
             No exits game

            Yes leads to the primary game loop;

            "While PlayGame == "yes""
            {
            Customer enters

            Read customer?
            YesNo

            Reading customer gives info 
            AnyKey(clear console)

            Order start!

            What drink?
            Flying Syrup <- Warm Sweet
            Brewed Cocoa <- Warm Savoury
            Poppy Milk <- Warm Sour
            Frogle(g)monade <- Cold Sour
            Juiced Sage <- Cold Savoury
            Goat's Breath Milkshake <- Cold Sweet

            Yesno Meal
            Pie of Newt <- Savoury
            Ceramic-su <- Sweet
            Witch's Stew <- Sour

            Yesno Sides
            Cauldron-Cakes <- Sweet
            Snake's Tongue Twizzler <- Sour
            Garlic-Braided Pumpkin Bread <- Savoury

            Order complete!
            Customers comes up and grabs order
            
            . . .
             
            Score!

            Ready for the next costumer?
            Yesno
            
            Yes: Loop restarts
            No: Loop ends
            }

            Thanks for Playing!
             
            */


            Console.ReadLine();
        }

        static void Tutorial()
        {
            Console.WriteLine("Some costumers are more or less hungry. A 1/10 means they're starving and want to eat a lot!");
            Console.WriteLine("A 10/10 means they're full and don't want any food, and so on!");
            Console.WriteLine("");

            Console.WriteLine("Customers like different things! Some have as sweet tooth while others prefer savoury items.");
            Console.WriteLine("Customers also have a temperature preferance. Don't give a customer with a preferance for cold a warm drink!");
            Console.WriteLine("You get the information by READing a customer. You can choose to not READ them if you want to guess.");
            Console.WriteLine("When you READ a customer you have to memorise their preferences! It will not stay for you to look back on.");
            Console.WriteLine("They might leave you with a bad score though, so be careful!");
            Console.WriteLine("");

            Console.WriteLine("When you get started on making the order for the customer you must always choose a Drink first.");
            Console.WriteLine("When you've chosen the drink you have the option of adding a Meal and a Side. Both are optional.");
            Console.WriteLine("If a customer's Hunger is around a 7/10 they probably don't want a Meal, so just a Side would be optimal for them!");
            Console.WriteLine("But if a customer's Hunger is around a 3/10 they probably aren't hungry enough to eat both a Side and a Meal,");
            Console.WriteLine("so you could only give them a Meal to satisfy them. It's up to you though!");
            Console.WriteLine("");

            Console.WriteLine("When the order is ready the customer will review! Depending on how well you did you get a corresponding Score.");
            Console.WriteLine("The higher the Score, the better! Aim for the stars!");
        }
    }
}