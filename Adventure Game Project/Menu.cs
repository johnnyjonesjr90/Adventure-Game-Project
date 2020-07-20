using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Adventure_Game_Project
{
    public class Menu
    {
        public static void MENU()
        {
            int choice1 = 0;
            while (choice1 == 0)
            {
                Console.Clear();
                Console.WriteLine("1 - Continue \n" +
                    "\n" +
                    "2 - View Inventory \n" +
                    "\n" +
                    "3 - Quit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        choice1 += 1;
                        break;
                    case 2:
                        Access.INventory();
                        break;
                    case 3:
                        Mechanics.gameOver();
                        break;
                }
            }
        }

    }
}
