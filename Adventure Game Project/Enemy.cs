using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game_Project
{
    public class Enemy
    {

        int[] items = { 1, 2, 3, 4, 5 };

        private int _health = 300;
        public int health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value <= 0)
                {
                    _health = 50;
                }
                else if (value >= 300)
                {
                    _health = 300;
                }
                else
                {
                    _health = value;
                }
            }
        }
        static Random rnd = new Random();
        public int _enemydmg = (20 - Enemy.rnd.Next(1, 20));
    }

}
