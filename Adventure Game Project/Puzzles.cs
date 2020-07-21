using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace Adventure_Game_Project
{
    class Puzzles
    {
        
        public static void WoodPuzzle()
        {
            if (Program.john.woodpuzzleaccess == 0)
            {
                int i =3;

                while (i != 0)
                {
                    
                    string safe = $"PLEASE ENTER THE CORRECT CODE TO ACCESS SAFE...YOU HAVE {i} CHANCES";
                    foreach (var character in safe)
                    {
                        Console.Write(character);
                        Thread.Sleep(10);
                    }
                    Console.WriteLine();
                    string safe2 =
                        "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                        "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                        "dsadsbjldsWsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                        "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfOsaferiefdsfdbsjfgdusOhjdsq\n" +
                        "dsadsbDldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefDsfdbsjfgdusfhOdsq\n" +
                        "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                        "dsadsOjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiRfdsfdbsjfgdusfhjdsq\n" +
                        "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n";
                    foreach (var character in safe2)
                    {
                        Console.Write(character);
                        Thread.Sleep(5);
                    }
                    Console.WriteLine("PLEASE ENTER THE CODE");
                    string code =Console.ReadLine();
                    if (code == "WOOD DOOR") 
                    { 
                        Console.WriteLine("You found some bandages...");
                        Program.john.health += 20;
                        Console.WriteLine($"Health: {Program.john.health}");
                        Console.ReadLine();
                        Console.Clear();
                        i = 0;
                        break;
                    }


                }

            }
            Console.WriteLine("The safe iS now inaccessable...");
            Console.ReadLine();
            Console.Clear();
            Program.john.woodpuzzleaccess += 1;
            Locations.courtYard();
            
        }
        public static void Redpuzzle()
        {
            try
            {
                if (Program.john.woodpuzzleaccess2 == 0)
                {
                    int i = 100;

                    while (i != 0)
                    {
                        try
                        {
                            Console.WriteLine(" 7  ||  63  ||  47 ");
                            Console.WriteLine("===================");
                            Console.WriteLine(" 17 ||  A   ||  10 ");
                            Console.WriteLine("===================");
                            Console.WriteLine(" 40 ||  9   ||  49 ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Solve for A");
                            Console.WriteLine();
                            Console.WriteLine("Enter 999 to Exit");
                            int answer = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (answer == 7)
                            {
                                Console.WriteLine("The lock opens and inside you find a shard wrapped inside... ");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("1 Shard added to your inventory");
                                Program.john.shard += 1;
                                Locations.stairWell();
                            }
                            else if (answer == 999)
                            {
                                Locations.stairWell();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Incorrect format");
                            Console.ReadLine();
                        }

                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
                Console.ReadLine();
            }
        }
        public static void Bluepuzzle()
        {
            try
            {
                if (Program.john.woodpuzzleaccess3 == 0)
                {
                    int i = 100;

                    while (i != 0)
                    {
                        try
                        {

                            string safe = $"PLEASE ENTER THE CORRECT CODE TO ACCESS SAFE...YOU HAVE {i} CHANCES\n PRESS 1 TO EXIT";
                            foreach (var character in safe)
                            {
                                Console.Write(character);
                                Thread.Sleep(10);
                            }
                            Console.WriteLine();
                            string safe2 =
                                "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                                "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                                "dsadsbjldsosfddsBjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgLusfhjdsq\n" +
                                "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhftsaferiefdsfdbsjfgdusrhjdsq\n" +
                                "dsadsbgldUdsfddshjdkhudsfdhjsfdsjjhfEsaferiefcsfdbsjfgdDsfhxdsq\n" +
                                "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n" +
                                "dsadsqOldsdsfddshjdkhudsfdhjsfdsjjhfOsaferiRfdsfdbsjfgdusfhjdsq\n" +
                                "dsadsbjldsdsfddshjdkhudsfdhjsfdsjjhfjsaferiefdsfdbsjfgdusfhjdsq\n";
                            foreach (var character in safe2)
                            {
                                Console.Write(character);
                                Thread.Sleep(5);
                            }
                            Console.WriteLine("PLEASE ENTER THE CODE");
                            string code = Console.ReadLine();
                            if (code == "BLUE DOOR")
                            {
                                Console.WriteLine("You found some bandages.. and another shard");
                                Program.john.health += 20;
                                Program.john.shard += 1;
                                Console.WriteLine($"Health: {Program.john.health}");
                                Console.ReadLine();
                                Console.Clear();
                                i = 0;
                                break;
                            }
                            else if (code == "1")
                            {
                                Locations.stairWell();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Incorrect format");
                            Console.ReadLine();
                        }

                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
                Console.ReadLine();
            }
            Console.WriteLine("The safe in now inaccessable...");
            Console.ReadLine();
            Console.Clear();
            Program.john.woodpuzzleaccess3 += 1;
            Locations.stairWell();
        }
        public static void Boxpuzzle()
        {
            try
            {
                if (Program.john.woodpuzzleaccess2 == 0)
                {
                    int i = 100;

                    while (i != 0)
                    {
                        try
                        {

                            string safe = "xob eht kcolnu dna elzzup eht evlos";
                            foreach (var character in safe)
                            {
                                Console.Write(character);
                                Thread.Sleep(20);
                            }
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine("Type the code and press enter...");

                            string answer = Console.ReadLine();
                            Console.Clear();
                            if (answer == "solve the puzzle and unlock the box")
                            {
                                Console.WriteLine("The lock opens and inside you find a key inside... ");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("small key added to your inventory");
                                Program.john.key02 += 1;
                                Program.john.Container002 = 0;
                                i = 0;
                                Console.ReadLine();
                                Console.Clear();
                                Locations.foyer();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Incorrect format");
                            Console.ReadLine();
                        }
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
                Console.ReadLine();
            }
        }
    }
}
