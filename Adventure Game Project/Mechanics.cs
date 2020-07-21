using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game_Project
{
    class Mechanics
    {
        public static int bullets()
        {
            Random shots = new Random();
            int _shots = shots.Next(1,Program.john.bullets);
            Program.john.bullets -= _shots;
            return _shots;

        }
        public static (int, int) battle()
        {

            
            Random rnd2 = new Random();
            int encounter = (100 - rnd2.Next(1, 99));
            if (encounter >= 60)
            {
                
                    if (Program.john.pistol == 1 && Program.john.bullets > 0) 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You hear loud steps, you were barely able to pull out your pistol ...");
                    Console.ReadLine();
                    Console.Clear();
                    int hit = bullets();
                    Console.WriteLine($"You shot {hit} bullets..");
                    Program.demon.health -= (hit*Program.john._bullets);
                    int enemyhit = (hit * Program.john._bullets);
                    Console.WriteLine($"You did {enemyhit} damage.. You have {Program.john.bullets} bullets left. \n\n Press Enter...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("///// Enemy Health remaining: " + Program.demon.health + "\n\n Press Enter...");
                    Console.ReadLine();
                    if (Program.demon.health == 0)
                    {
                        Console.WriteLine("Youve killed one of the demon..... im sure there are more....");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    return (Program.john.health, Program.demon.health);
                }
                else if (Program.john.pistol >= 1 && Program.john.bullets <= 0)
                {
                    Console.WriteLine("You pull out your pistol but you dont have any more bullets......");
                    Console.WriteLine();
                        if (Program.john.axe == 1 || Program.john.knife == 1)
                    {

                        Console.WriteLine("You pull out your blade......");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You swing wildly and manage to connect a few hits....");
                        Random swings = new Random();
                        int _swings = swings.Next(1, 3);
                        Program.demon.health -= (25*_swings);
                        int hit2 = (25 * _swings);
                        Console.WriteLine($"You did {hit2} damage \n\n Press Enter...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You got hit during the scuffle...");
                        Program.john.health -= Program.demon._enemydmg;
                        Console.WriteLine("you were hit with " + Program.demon._enemydmg + " damage \n\n Press Enter...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("///// Health remaining: " + Program.john.health + "\n\n Press Enter...");
                        Console.WriteLine("///// Enemy Health remaining: " + Program.demon.health + "\n\n Press Enter...");
                        Console.ReadLine();
                        if (Program.demon.health == 0)
                        {
                            Console.WriteLine("Youve killed one of the demon..... im sure there are more....");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        return (Program.john.health, Program.demon.health);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You wish you had another weapon....");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("the demon roars and swings at you before disappearing..");
                    Console.ReadLine();
                    Console.Clear();
                    Program.john.health -= Program.demon._enemydmg;
                    Console.WriteLine("you were hit with " + Program.demon._enemydmg + " damage \n\n Press Enter...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("///// Health remaining: " + Program.john.health + "\n\n Press Enter...");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    return (Program.john.health, Program.demon.health);

                }
                else if (Program.john.pistol >= 0 )
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (Program.john.axe == 1 || Program.john.knife == 1)
                    {
                        Console.WriteLine("You turn to see a creature running towards you...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You pull out your blade......");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You swing wildly and manage to connect a few hits....");
                        Console.ReadLine();
                        Console.Clear();
                        Program.demon.health -= 25;
                        Console.WriteLine("You did 25 damage \n\n Press Enter...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You got hit during the scuffle...");
                        Program.john.health -= Program.demon._enemydmg;
                        Console.WriteLine("you were hit with " + Program.demon._enemydmg + " damage \n\n Press Enter...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("///// Health remaining: " + Program.john.health + "\n\n Press Enter...");
                        Console.WriteLine("///// Enemy Health remaining: " + Program.demon.health + "\n\n Press Enter...");
                        if (Program.demon.health == 0)
                        {
                            Console.WriteLine("Youve killed one of the demon..... im sure there are more....");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ReadLine();
                        return (Program.john.health, Program.demon.health);
                    }
                    Console.WriteLine("You hear loud steps, you were barely able to make it out of the way before \n the demon ran off but you were still hit.");
                    Console.WriteLine();
                    Program.john.health -= Program.demon._enemydmg;
                    Console.WriteLine("you were hit with " + Program.demon._enemydmg + " damage \n\n Press Enter...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("///// Health remaining: " + Program.john.health + "\n\n Press Enter...");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    return (Program.john.health,Program.demon.health);
                    
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                
                return (Program.john.health, Program.demon.health);


            }
            else
            {
                Console.WriteLine("Luckily....there are no demons around \n Press Enter....");
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
                return (Program.john.health, Program.demon.health);
                

            }
        }
        public static void gameOver()
        {
            if (Program.john.health == 0)
            {
                Console.WriteLine("You Have Died....");
                Console.ReadLine();
                
            }
            Console.WriteLine("You Have Died....");
            Console.ReadLine();
            Environment.Exit(0);
        }
        public static void gameOver1()
        {
            
                Console.WriteLine("Thank You for Playing my game!!");
                Console.ReadLine();
                Environment.Exit(0);

        }
    }
}
