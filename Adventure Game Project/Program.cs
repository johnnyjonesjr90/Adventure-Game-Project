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
        public static Enemy CultLeader = new Enemy();





        static void Main(string[] args)
        {

            StartMenu.SMenu();
            Console.Clear();
            Console.WriteLine("Press Enter to Continue....");
            Console.ReadLine();
            Console.Clear();
            string name = "name...?";
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
            Console.WriteLine("Press Enter to Continue....");
            Console.ReadLine();
            Console.Clear();
            choice1:
            
            string intro1 = "~~This should be a simple job, I dont think I need my entire kit~~:\n" +
            "1 - Take crowbar\n" +
            "2 - Take knife\n" +
            "3 - Take pistol\n\n" +
            "Choose a number and Press Enter";
            foreach (var character in intro1)
            {
                Console.Write(character);
                Thread.Sleep(10);
            }
            Console.WriteLine();

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 1 && choice != 2 && choice != 3)
            {
                Console.Clear();
                goto choice1;
            }
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
            string intro2 = "You and Jake make your way to the house and begin to scope it out. 'Yo man it looks like theres just a few dudes here, we can wait until\n" +
                "they leave and see what we can find.' You  wait until the sun goes down and the men leave in a large black van... Jake leads you to a window in the front of \n" +
                " the house and you make your way through.. as soon as you climb in you see Jake standing with his hands up shaking his head. You see several men in long robes \n" +
                " with hood pointing a gun at him. Before you can say a word he pulls out his switch blade and cuts one of the men's arms and wrestle the one with the gun to the\n" +
                "ground. They eventually knock him out and drag the two of you to a courtyard in the house. they place Jake on a large table and hit you in the back of the head. \n" +
                "You go in and out of conciousness but you were able to see what looks like them strabbing him and then a brignt light emits from far on the other side of the yard..\n" +
                "You gather your strength and run to the front door, its locked so you look around and decide to hide under a large tarp.... you black out......";
            foreach (var character in intro2)
            {
                Console.Write(character);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("You wake up and head towards the front door, it wont budge... you hear what sounds like footsteps in the distance... youve got to get out of here....\n" +
                "Press Enter...");
            Console.ReadLine();
            Console.Clear();
            while (Program.john.health > 0)
            {
                Mechanics.battle();
                Console.Clear();
                Console.WriteLine();
            CChoice:
                Console.WriteLine("Since the door is blocked...you decide to venture further.....\n\n" +
                    "\n" +
                    "1 - Hallway \n" +
                    "2 - Courtyard \n" +
                    "3 - Stairwell  \n" +
                    "4 - MENU");
                Console.WriteLine();
                string choice1 = Console.ReadLine();
                if ( choice1 != "1" && choice1 != "2" && choice1 != "3"&& choice1 != "4")
                    goto CChoice;
                if (choice1 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You run into the hall, at least its quiet. \n" +
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

