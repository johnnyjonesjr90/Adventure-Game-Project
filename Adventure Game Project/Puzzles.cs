using System;
using System.Collections.Generic;
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
            Console.WriteLine("The safe in now inaccessable...");
            Console.ReadLine();
            Console.Clear();
            Program.john.woodpuzzleaccess += 1;
            
        }
        public static void Redpuzzle()
        {
            if (Program.john.woodpuzzleaccess == 0)
            {
                int i = 10;

                while (i != 0)
                {

                    


                }

            }
        }
    }
}
