using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game_Project
{
    public class Access
    {
        
        public static void INventory()
        {
            Console.Clear();
            bool bullets = Program.john.bullets > 0;
            bool pistol = Program.john.pistol > 0;
            bool lockpick = Program.john.lockpick > 0;
            bool knife = Program.john.knife > 0;
            bool key = Program.john.key01 > 0;
            bool key2 = Program.john.key02 > 0;
            bool blueky = Program.john.blueKey > 0;
            bool redky = Program.john.redKey > 0;
            bool axe = Program.john.axe > 0;
            bool dagger = Program.john.dagger > 0;
            bool liquid = Program.john.liquid > 0;
            bool shard = Program.john.shard > 0;
            bool crowbar = Program.john.crowbar > 0;
            Console.WriteLine($" health: {Program.john.health} % ");
            Console.WriteLine();
            if (bullets==true) Console.WriteLine($"Bullets - {Program.john.bullets}");
            if (pistol==true) Console.WriteLine($"Pistol - {Program.john.pistol}");
            if(lockpick==true)Console.WriteLine($"lockpick - {Program.john.lockpick}");
            if (knife== true) Console.WriteLine($"Knife - {Program.john.knife}");
            if(key == true) Console.WriteLine($"Metal key - {Program.john.key01}");
            if (key2 == true) Console.WriteLine($"Small Key- {Program.john.key02}");
            if (blueky == true) Console.WriteLine($"Small Blue key- {Program.john.blueKey}");
            if (redky == true) Console.WriteLine($"Small Red key- {Program.john.redKey}");
            if (axe == true) Console.WriteLine($"Axe  - {Program.john.axe}");
            if (dagger == true) Console.WriteLine($"Daggar - {Program.john.dagger}");
            if (liquid == true) Console.WriteLine($"Blue Liquid - {Program.john.liquid}");
            if (shard == true) Console.WriteLine($"Strange Shard- {Program.john.shard}");
            if (crowbar == true) Console.WriteLine($"Crowbar- {Program.john.crowbar}");
            Console.ReadLine();
        }
    }
}
