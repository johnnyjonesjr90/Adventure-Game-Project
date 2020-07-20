using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Adventure_Game_Project
{
    class Locations
    {

        
        public static void foyer()
        {

        }
        public static void courtYard()
        {
            
            Mechanics.battle();        
            Console.Clear();
            if(Program.john.CYentry == 0) 
            {
                Console.WriteLine("You look around..... this area is huge, probably the size of two football fields. You cant really see\n" +
                "past the tall grass in places but you see theres a fire somewhere to the right. And theres some sort of glow on the left.");
            }
            Courtyardstart:
            Console.WriteLine("You creep into the tall grass by the door...");            
            Console.WriteLine();
            Console.WriteLine("1 - Head towards the glow... \n" +
                "2 - Head towards the smoke on the right \n" +
                "3 - Head straight \n" +
                "4 - Go back to the Foyer\n" +
                "5 - Menu");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                 
                Console.WriteLine("you start to creep towards the glow... you see a smaller dog-like demon sleeping\n" +
                        "about 50 yards from the source of the light.");
                 Console.WriteLine("Turn back?\n" +
                "1 - Yes \n" +
                "2 - No");
                 int choice1 = Convert.ToInt32(Console.ReadLine());
                 Console.Clear();
                    if (choice1 == 1)
                    {
                        Console.WriteLine("You decide its best not to take the chance");
                        Console.ReadLine();
                        Console.Clear();
                        goto Courtyardstart;
                    }
                    else
                    {
                        Console.WriteLine("You walk toward the light, it seems to be a hole in the wall with a ethernal glow coming from it...\n " +
                            "You sneak past that sleeping.....thing, and make your way towards the hole... once you get to it, it looks like you \ncan step into it.. ");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Walk into it?\n" +
                            "1 - Go back\n" +
                            "2 - Step inside");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (choice2 == 1)
                        {
                            Console.WriteLine("You decide its best not to take the chance");
                            Console.ReadLine();
                            Console.Clear();
                            goto Courtyardstart;
                        }
                        if (choice2 == 2)
                        {
                            Console.WriteLine("You slowly move your hand towards the light, it feels kind of like silk.... but then it starts to pull \n" +
                                "you inside and next thing you know you youre falling, fast, and the light starts to fade to deep darkness. ");
                            Console.ReadLine();
                            Console.Clear();
                            if (Program.john.liquid == -1)
                            {
                                Console.WriteLine("The bottle in your pocket starts to glow brigher and you take it out and the lid pops off and spills on you \n" +
                                    "You black out........");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("You wake up to find yourself back in the foyer...");
                                Console.ReadLine();
                                Console.Clear();
                                foyer();
                            }
                            else
                            {
                                Console.WriteLine("You fall and fall and slowly you lose conciousness...");
                                Console.ReadLine();
                                Console.Clear();
                                Mechanics.gameOver();
                            }

                        }
                        break;
                    }


                case "2":
                    while (Program.john.cytents == 0)
                    {
                        Console.WriteLine("You shuffle through the tall grass not wanting to get noticed by another one of those monsters when you hear voices." +
                            "\n You see a few cultists standing around a small fire... there are a few tents past them... you may be able to sneak by them.... \n" +
                            "or you can take care of them.... ");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("1 - Kill them\n" +
                            "2 - Sneak around\n" +
                            "3 - Go back");
                        int kill = Convert.ToInt32(Console.ReadLine());
                        if (kill == 1)//ATTACK THE CULTIST
                        {

                            Console.WriteLine("You position yourself so you, can grab one of the cultists when all but one walked away... the one remaining \n" +
                                "is seated on a small chair deep into reading a book...you slowly creep up directly behind it... \n" +
                                "1 - Choke him\n" +
                                "2 - Go back");
                            int kill2 = Convert.ToInt32(Console.ReadLine());
                            if (kill2 == 1)
                            {
                                Console.WriteLine("~~~ Im not a killer am I?..... A theif but not a killer....right~~~~~~");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("The cultist puts down his book and stretches his arms... you crouch to not be seen but you dont know what he is \n" +
                                    "going to do....");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("1 - Kill him\n" +
                                    "2 - Kill him\n3 - Kill him\n4 - Kill him\n5 - Kill him\n6 - Kill him\n7 - I cant do this.....\n");
                                int kill3 = Convert.ToInt32(Console.ReadLine());
                                if (kill3 == 7)//YOU DIE
                                {
                                    Console.WriteLine("The cultist finished his stretch and you slowly back into the brush when you back into something hard\n" +
                                        "you adjust to avoid the tree but you realize this wasnt a tree...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("By the time you realize what you ran into, you look down to see a spear sticking out of your chest...");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Mechanics.gameOver();
                                }
                                else //FIND SHARD
                                {
                                    Console.WriteLine("You grab the cultist in a headlock and cover his mounth. Youve never done this before and youre tired.\n" +
                                        "The cultist is scratching at your eyes and you bite down hard on his finger. You try and drag him back to the brush\n" +
                                        "when you trip and fall on your back. When you fall you bite his fingers off and you begin to choke... ");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("You try to catch your breath but the fingers arent moving. You pull harder and harder until you feel his \n" +
                                        "neck pop and he goes limp. You get up and try to voimt as quietly as possible.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("After hiding the body you slowly make your way to the tents...... you rummage around and find a few containers \n" +
                                        "with some bullets and a weird crystal in it.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Program.john.bullets = 2;
                                    Console.WriteLine("2 bullets added to your inventory");
                                    Program.john.shard = 1;
                                    Console.WriteLine("1 bullets added to your inventory");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("With the coast clear you head back to the front door");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Program.john.cytents += 1;
                                    goto Courtyardstart;
                                }

                            }
                            else //YOU LEAVE
                            {
                                Console.WriteLine("You decide its best not to take the chance");
                                Console.ReadLine();
                                Console.Clear();
                                goto Courtyardstart;
                            }
                        }
                        else if (kill == 2)//SNEAK
                        {
                            Console.WriteLine("You see the group of cultist... you decide to sneak around them. as you are walking you kick a can .. it rattles\n" +
                                "across the ground....");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("You duck and watch the group as they casually turn and one walks over to investigate.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("The one investigating walks within a few steps of you while the others slowly start to walk away talking amongst themselves.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("1 - Kill him\n" +
                             "2 - hold your breath and wait...");
                            int kill4 = Convert.ToInt32(Console.ReadLine());
                            if (kill4 == 1)//KILL HIM
                            {
                                Console.WriteLine("You grab the cultist in a headlock and cover his mounth. Youve never done this before and youre tired.\n" +
                                            "The cultist is scratching at your eyes and you bite down hard on his finger. You try and drag him back to the brush\n" +
                                            "when you trip and fall on your back. When you fall you bite his fingers off and you begin to choke... ");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("You try to catch your breath but the fingers arent moving. You pull harder and harder until you feel his \n" +
                                    "neck pop and he goes limp. You try and get the finger out of your mounth but its deep... you start to get light=headed\n" +
                                    "you black out....");
                                Console.ReadLine();
                                Console.Clear();
                                Mechanics.gameOver();

                            }
                            else
                            {
                                Console.WriteLine("You wait and the rest of the group calls him over to their conversation.... you were able to make your way to the \n" +
                                    "tents... You rummage through their stuff and quietly run off.. you check your pockets when you get a safe distance away to find....");
                                Console.ReadLine();
                                Console.Clear();
                                Program.john.bullets = 2;
                                Console.WriteLine("2 bullets added to your inventory");
                                Program.john.shard = 1;
                                Console.WriteLine("1 Shard added to your inventory");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("With the coast clear you head back to the front door");
                                Console.ReadLine();
                                Console.Clear();
                                Program.john.cytents += 1;
                                goto Courtyardstart;
                            }
                        }
                        else if (kill == 3)
                        {
                            Console.WriteLine("You decide its best not to take the chance");
                            Console.ReadLine();
                            Console.Clear();
                            goto Courtyardstart;
                        } //YOU BACK OFF
                        
                    }
                    break;
                case "3":
                    Console.WriteLine("You head accross the open field staying hidden in the tall grass");
                    Console.ReadLine();
                    Console.Clear();
                    Doors:
                    Console.WriteLine("You see two doors..." +
                        "\n 1 - Large metal door\n" +
                        "2 - Wooden door" +
                        "3 - Go back");
                    int doorchoice = Convert.ToInt32(Console.ReadLine());
                    if (doorchoice == 1)
                    {
                        if(Program.john.key01 == 1)
                        {
                            Console.WriteLine("You put the key in and open the door enough to slide in. As soon as you enter you close and lock the door.\n " +
                                "You take a second to rest since the room looks safe.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("The room has a lot of shelves it looks like it was a storage room... you see a few things on the shelf n front \n" +
                                "of you. As soon as you grab what you want you hear a shuffle in the back of the room. but it sounds like it could have been a rat.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Pistol added to your inventory\n" +
                                "2 Bullets added to your inventory\n" +
                                "");
                            Program.john.pistol += 1;
                            Program.john.bullets += 2;
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Keep looking through the shelves?\n1 - See if you can find anything else \n2 - Not worth running into something back there");
                            int lookaround = Convert.ToInt32(Console.ReadLine());
                            if (lookaround == 2)
                            {
                                Console.WriteLine("You unlock the door and sneak back to the front door of the courtyard.");
                                Console.ReadLine();
                                Console.Clear();
                                goto Courtyardstart;
                            }else if(lookaround == 1)
                            {
                                Console.WriteLine("You start to grab some food and scarf it down when you knock over a shelf with shovels on it....");
                                Console.ReadLine();
                                Console.Clear();
                                Mechanics.battle();
                                Console.WriteLine("When you catch your breath you find some bandages and a crowbar on a shelf. Both are welcome sights.");
                                Console.ReadLine();
                                Console.Clear();
                                Program.john.crowbar += 1;
                                Program.john.health += 20;
                                Console.WriteLine("Crowbar added to your inventory");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"You health recovered by 20 Health:{Program.john.health}");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("You unlock the door and sneak back to the front door of the courtyard.");
                                Console.ReadLine();
                                Console.Clear();
                                goto Courtyardstart;
                            }
                        }
                        else
                        {
                            Console.WriteLine("It looks like it takes a large key");
                            Console.ReadLine();
                            Console.Clear();
                            goto Doors;

                        }
                    }
                    else if (doorchoice ==2)
                    {
                        if (Program.john.key02 == 1)
                        {
                            Console.WriteLine("You open the door to see a safe with a weird comination on it..\n As a seasoned theif you cant let the opportuniy" +
                                "pass you by...");
                            Console.ReadLine();
                            Console.Clear();
                            Puzzles.WoodPuzzle();
                            Console.WriteLine("You sneak out the door and sneak back to the front door of the courtyard.");
                            Console.ReadLine();
                            Console.Clear();
                            goto Courtyardstart;

                        }
                        else
                        {
                            Console.WriteLine("It looks like it takes a key");
                            Console.ReadLine();
                            Console.Clear();
                            goto Doors;

                        }
                    }
                    else
                    {
                        goto Courtyardstart;
                    }
                    goto Courtyardstart;
                case "4":
                    Console.WriteLine("You turn and head back to the Foyer...");
                    Console.ReadLine();
                    Console.Clear();
                    Locations.foyer();
                    break;
                case "5":
                    Menu.MENU();
                    goto Courtyardstart;






            }

        }
        public static void hallWay()
        {

            Mechanics.battle();
            Console.Clear();
        hallwaychoice:
            Console.Clear();
            Console.WriteLine("You look around and see a few interesting things...");
            Console.WriteLine();
            Console.WriteLine("1 - Cieling opening \n" +
                "2 - Floor latch \n" +
                "3 - Container \n" +
                "4 - Continue down hallway\n" +
                "5 - Go back to Foyer\n" +
                "6 - Menu");
            string hallwaychoice = Console.ReadLine();
            switch (hallwaychoice)
            {
                case "1":
                    Console.WriteLine("you walk up to a wide hole in the ceiling, it seems to be pretty high, a ladder could reach it...");
                    Console.ReadLine();
                    Console.Clear();
                    if (Program.john.ladder == 1)
                    {
                        hallway_cieling();
                    }
                    else
                    {
                        Console.WriteLine("You need a ladder or something.....");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    goto hallwaychoice;
                    

                case "2":
                    Console.WriteLine("You see a small trapped door hidden by a thick layer of dust... ");
                    Console.ReadLine();
                    if (Program.john.crowbar == 1)
                    {
                        Console.WriteLine("You shove the edge of the crowbar into the gap in the door, your hands hurt from everything \n" +
                            "that youve been through but you bust it open to find nothing but a small bottle on the ground.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Pick up the bottle?\n" +
                            "1 - Yes\n" +
                            "2 - No");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1) { Console.WriteLine("Blue liquid added to your inventory");
                            Program.john.liquid += 1;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        hallway_trapdoor();
                    }
                    else
                    {
                        Console.WriteLine("You need a crowbar or something to break this open");
                        Console.ReadLine();
                    }
                    
                    
                    goto hallwaychoice;
                    
                case "3":
                    Console.WriteLine("You spot a box tucked in the corner... ");
                    Console.ReadLine();
                    if (Program.john.Container001 == 1)
                    {
                        Console.WriteLine("You open the box... it has a lot of dust but there is a heavy metal key inside.");
                        Console.ReadLine();
                        Console.Clear();
                        Program.john.key01 = 1;
                        Console.WriteLine("Metal Key added to your inventory");
                        Program.john.Container001 -= 1;
                        Console.ReadLine();
                        Console.Clear();
                    }else{
                        Console.WriteLine("The box is empty");
                        Console.ReadLine();
                        Console.Clear();                        
                    }
                    goto hallwaychoice;

                case "4":
                    Console.WriteLine("You creep down the hallway and see a hallway with stairs at the end... ");
                    Console.ReadLine();
                    stairWell();
                    break;
                case "5":
                    Console.WriteLine("You turn back to the Foyer");
                    Console.ReadLine();
                    Console.Clear();
                    Locations.foyer();
                    break;
                case "6":
                    Menu.MENU();
                    break;
            }

        }
        public static void hallway_cieling()
        {
            Console.WriteLine("You climb the ladder and see there is an opening...");
            Console.ReadLine();
            Console.WriteLine("You crawl into the space and rest a bit.... you take a second to think about Jake... \n " +
                "you wonder what world are you living in and that someone must have slipped you some heavy drugs...\n" +
                "While you were in thought you notice a long item wrapped in a rag. You really dont want to see whats \n" +
                "inside but since youre living a horror movie what the hell...\n You unwrap it and it seems to be an old knife, you put in in your pocket \n" +
                "if you make it out at lease you can get some cash for this....");
            Program.john.dagger += 1;
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Rusty Dagger added to your inventory");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("As you get down the ladder breaks and you luckily land on your feet..");
            Console.ReadLine();
            Console.Clear();
            hallWay();
            
        }

        public static void hallway_trapdoor()
        {
            Console.WriteLine("Under construction");
            Console.ReadLine();
        }
        public static void stairWell()
        {

            
            Console.Clear();
        stairwaychoice:
            Console.Clear();
            Console.WriteLine("You look around and see a few interesting things...");
            Console.WriteLine();
            Console.WriteLine("1 - Go Upstairs \n" +
                "2 - Red Door \n" +
                "3 - Go down hallway\n" +
                "4 - Go to Foyer\n" +
                "5 - Blue Door" +
                "6 - Menu");
            string stairchoice = Console.ReadLine();
            switch (stairchoice)
            {
                //Upstairs
                case "1":
                    Console.WriteLine("You look upstairs... it seems to be clear ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You take a few steps and see that there are a few steps missing. You could jump over it or try to smimmey along the railing..\n" +
                        "But that looks really loose\n" +
                        "1- Try and Jump...\n" +
                        "2- Use the railing to get accross...");
                    string stairchoice2 = Console.ReadLine();
                    switch (stairchoice2)
                    {
                        case "1":
                            Console.WriteLine(" You jump and miss the other side by a foot...");
                            Program.john.health -= 15;
                            Console.WriteLine("///// Health remaining: " + Program.john.health + "\n\n Press Enter...");
                            Console.ReadLine();
                            goto stairwaychoice;
                        case "2":
                            Console.WriteLine("You grab the railing and slowly shuffle accross the hole... after a few minutes you make it to the other side..");
                            Console.ReadLine();
                            if (Program.john.shard == 3)
                            {
                                Console.WriteLine("Final fight");
                                Console.ReadLine();
                                Console.Clear();
                                Locations.stairway_RedRoom();
                            }
                            else
                            {
                                Console.WriteLine("The door is locked but it doesnt have a handle, it has what can only be described as four growths on it. One of the growths has \n" +
                                    "some sort of glass shard in in...");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("You turn and make your way back downstairs.");
                                goto stairwaychoice;
                            }
                            break;
                    }

                    goto stairwaychoice;
                    
                //Red Door
                case "2":
                    if (Program.john.blueKey == 1)
                    {
                        Console.WriteLine("You open up the door and ");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("");

                    }
                    else
                    {
                        Console.WriteLine("The door is locked...");
                        Console.ReadLine();
                        goto stairwaychoice;
                    }                    
                    goto stairwaychoice;                    
                
                    
                //Hallway
                case "3":
                    Console.WriteLine("You turn around and head towards that long hallway");
                    Console.ReadLine();
                    Console.Clear();
                       hallWay();
                    break;
                //Foyer
                case "4":
                    Console.WriteLine("UNDER CONSTRUCTION");
                    Console.ReadLine();
                    foyer();
                    break;
                //Blue door
                case "5":
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "6":
                    Menu.MENU();
                    break;
            }

        }
        public static void stairway_RedRoom()
        {
            
            
        }
    }
       
    }

