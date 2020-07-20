using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Adventure_Game_Project
{
    
   
    class Program
    {
        public static Player john = new Player();
        public static Enemy demon = new Enemy();
        public static Access access1 = new Access();






        static void Main(string[] args)
        {
            string name ="name...?";
            foreach (var character in name)
            {
                Console.Write(character);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            john.Name = Convert.ToString(Console.ReadLine());

            Console.Clear();
            string intro = $"JAKE------''{john.Name} wake up man, remember that old couple that lived out in the valley? Yeah, well they kicked bucket a few days ago. \n" +
                $"If we hurry up we could probably hit the house before the family or whoever come. {john.Name} get up dude lets get this shit done... \n\n" +
                "Ill meet you at the car, dont forget to grab your crowbar.... unlike last time......''";
            foreach (var character in intro)
            {
                Console.Write(character);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            Console.Clear();
            string intro1 ="~~This should be a simple job, I dont think I need my entire kit~~:\n" +
            "1 - Take crowbar\n" +
            "2 - Take knife\n" +
            "3 - Take pistol";
            foreach (var character in intro1)
            {
                Console.Write(character);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Program.john.crowbar = 1;
                    Console.WriteLine("Crowbar added to your inventory");
                    Console.ReadLine();
                    break;
                case 2:                    
                    Program.john.knife = 1;
                    Console.WriteLine("Knife added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    Program.john.pistol = 1;
                    Console.WriteLine("Pistol added to your inventory");
                    Program.john.bullets = 4;
                    Console.WriteLine("4 bullets added to your inventory");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();
            string intro2 = "....This is where Ill explain story and give exposition... ultimately they see the house.. its big they start to loot it when they discover \nthe old people were in a cult " +
                "They left the house to the cult and they are doing rituals. They capture your friend and sacrifice him to bring a demon into the world.. the house cant be left\n" +
                "you try to escape but gets knocked out by a cultist. you wake up weak due to the hit.. and the house seems to be empty.. you try the door but it wont budge...\n";
            foreach (var character in intro2)
            {
                Console.Write(character);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("You make your way into the foyer\n" +
                "Press Enter...");
            Console.ReadLine();
            Console.Clear();
            while (Program.john.health > 0)
            {
                Mechanics.battle();
                Console.Clear();
                Console.WriteLine();
            CChoice:
                Console.WriteLine("The door is blocked...you decide to venture further.....\n\n" +
                    "\n" +
                    "1 - Hallway \n" +
                    "2 - Courtyard (Under Developer construction)\n" +
                    "3 - Stairwell (Under Developer construction) \n" +
                    "4 - MENU");
                Console.WriteLine();
                string choice1 = Console.ReadLine();

                if (choice1 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You run into the hall, at least its quiet but there are several inches of water on the floor. \n" +
                        "Press enter...");
                    Console.ReadLine();
                    Console.Clear();
                    Locations.hallWay();
                }
                else if (choice1 == "2")
                {
                    Console.WriteLine("You run out to the blinding sun... it seems to be a courtyard with no other exits but the one you came in..");
                    Console.ReadLine();
                    Console.Clear();
                    Locations.courtYard();
                }
                else if (choice1 == "3")
                {
                    Console.WriteLine("You enter a hallway that is a series of flights of stairs and doors, a low rumble can be heard from somewhere....");
                    Console.ReadLine();
                    Console.Clear();
                    Locations.stairWell();
                }
                else if (choice1 == "4")
                {
                    
                    Console.Clear();
                    Menu.MENU();
                }
                {
                    Console.Clear();
                    goto CChoice;
                }
                




            }
            Mechanics.gameOver();
        }

        }
       

    }

