using System;
using System.Collections.Generic;
using System.Linq;
//lade till Linq för att kunna göra capitalized first letters i en string

namespace Amanda_M_Slutprojekt_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             gör klart drink och customer
              börja göra vanliga koden. resten faller på plats när drink fungerar och minglar med
              main koden.
              
            */

            //exposition
            Console.WriteLine("Welcome to Witchy Brews, the café where we know more about what you want than you do!");
            Console.WriteLine("You are the owner, having an ability to 'read' incoming costumers to find out what they like.");
            Console.WriteLine("You get to choose a drink and then the optional choices of meal and/or side.");
            Console.WriteLine("Do you want to play? Write yes or no.");

            string play = YesNo(); //vill spelaren spela?

            while (play == "yes") //gör en loop som innehåller spelet
            {
                var c1 = new Customer(); //skapar en customer. använder var för att snygga upp koden (annars skulle jag behövt skriva customer två gånger)

                Console.WriteLine("A costumer enters the shop! They step up to the counter and you greet them.");
                Console.WriteLine("Do you want to 'read' the customer?");
                Console.WriteLine("Write Yes or No.");

                string read = YesNo(); //kollar om spelaren vill veta customer preference eller inte

                if(read == "yes") //if. Om yes får de fakta om customer.
                {
                    Console.WriteLine("You focus in on the customer, taking a deep gander at their eyes.");
                    Console.WriteLine("You feel a gentle tingle of magic...");

                    Console.WriteLine("Customer prefers the flavour " + c1.GetPreference() + " and they like " + c1.GetColdPref() + " drinks!");
                }
                else if (read == "no") //om nej får de ett litet meddelande
                {
                    Console.WriteLine("You decide to wing it. What's the worse that could happen?");
                }
                Console.WriteLine("The customer nods to you and seats themselves at a table. Time to prepare their order!");
                Console.ReadLine();

                Console.Clear(); //clear console


                var drink = new Drink(); //gör en ny instans av drink

                Console.WriteLine("You head to the kitchen to prepare a drink for the customer.");
                Console.WriteLine("Choose drink (please write the item exactly as it is written):");

                drink.GetMenuItems(); //visar vilka menu items som finns
                string inputDrink = Console.ReadLine().ToLower();

                // split into array with one word in each index: ["flying", "whale"]
                string[] w = inputDrink.Split(' ');
                for (int i = 0; i < w.Length; i++)
                {
                    char[] temp = w[i].ToCharArray(); // make temp char array to change first letter
                    temp[0] = temp[0].ToString().ToUpper().ToCharArray()[0]; // make first letter upper case
                    w[i] = new string(temp); // set the word to the new word with upper-case first letter
                }
                inputDrink = w.Aggregate((i, o) => $"{i} {o}"); // turn back into a string

                drink.choiceDrink = inputDrink;

                //en whileloop som kollar att det spelaren skrev finns i menu items. om inte måste de skriva om.
                while (drink.menuItems.ContainsKey(drink.choiceDrink) == false)
                {
                    Console.WriteLine("Hm, I don't remember a drink like that...");
                    Console.WriteLine("Please write one of the following drink names. Write the item EXACTLY as it is written.");
                    inputDrink = Console.ReadLine().ToLower();
                    
                    //Hittade denna på internet. Kan inte förklara den, men den gör så första bokstaven i varje ord blir uppercase.
                    w = inputDrink.Split(' ');
                    for (int i = 0; i < w.Length; i++)
                    {
                        char[] temp = w[i].ToCharArray(); // make temp char array to change first letter
                        temp[0] = temp[0].ToString().ToUpper().ToCharArray()[0]; // make first letter upper case
                        w[i] = new string(temp); // set the word to the new word with upper-case first letter
                    }
                    inputDrink = w.Aggregate((i, o) => $"{i} {o}"); // turn back into a string

                    drink.choiceDrink = inputDrink;
                }

                //om deras val är något av dessa görs drink om
                if (drink.choiceDrink == "Flying Syrup" || drink.choiceDrink == "Brewed Cocoa" || drink.choiceDrink == "Poppymilk")
                {
                    drink.isCold = false;
                    Console.WriteLine("You start preparing a warm cup of " + drink.choiceDrink + "!");
                }
                else //behöver inte definieras som else if då det är onödig kod
                {
                    drink.isCold = true;
                    Console.WriteLine("You start preparing a cold glass of " + drink.choiceDrink + "!");
                }


                Console.ReadLine();
            }


            

            /*
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

        static string YesNo() //metod för yes och no svar
        {
            string yesno = Console.ReadLine().ToLower(); //simpelt. En metod som skickar ut Yes eller No som en string till metoden som kallade på YesNo.

            while ((yesno != "no") && (yesno != "yes"))//Göt en while-loop så att spelaren inte kan skriva annat än yes eller no
            {
                Console.WriteLine("Please write only Yes or No.");

                yesno = Console.ReadLine().ToLower();//gör en toLower för att göra så att spelarens typografi(caps tex) inte spelar någon roll.
            }

            return (yesno);//skickar tillbaka stringen yesno till metoden som kallade på YesNo.
        } //Gjorde en string för Yes eller No eftersom detta används mycket i spelet.

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