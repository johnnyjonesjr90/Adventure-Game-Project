using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Adventure_Game_Project
{
    class StartMenu
    {
        public static void SMenu()
        {
            int choice1 = 0;
            while (choice1 == 0)
            {

                string photo = "" +
                    "..........0000000000.................00000000000...............\n" +
                    "...................00.....................00...................\n" +
                    "...................00.....................00...................\n" +
                    "...................00.....................00...................\n" +
                    "...................00.....................00...................\n" +
                    "............000000000.....................00...................\n" +
                    "...................00.....................00...................\n" +
                    "...................00.....................00...................\n" +
                    "...................00..............00.....00...................\n" +
                    "...................00..............00.....00...................\n" +
                    "..........0000000000.................000000....................\n";


                foreach (var character in photo)
                {
                    Console.Write(character);
                    Thread.Sleep(5);
                }
                Console.WriteLine();
                Console.WriteLine();
                string credits = "Created by Johnny Jones Jr (3J) 2020";
                foreach (var character in credits)
                {
                    Console.Write(character);
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                Console.WriteLine("1 - Continue to game \n" +
                    "2 - Quit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        choice1 += 1;
                        break;
                    case 2:
                        Mechanics.gameOver1();
                        break;



                }
            }
        }
    }
}
