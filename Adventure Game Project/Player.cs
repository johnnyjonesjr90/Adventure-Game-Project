using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Adventure_Game_Project
{
    public class Player
    {
        public int CYentry = 0;
        public string Name { get; set; }
        //public int SANITY = 0;
        
        public int lockpick = 0;
        public int boots = 0;
        public int dust = 0;
        public int knife = 0;
        public int _knife = 25;
        public int pistol = 0;
        public int bullets = 0;
        public int _bullets = 30;
        public int axe = 0;
        public int _axe = 25;

        //Items needed to progress 
        public int key01 = 0;
        public int key02 = 0; //Metal Key for courtyard door
        public int crowbar = 0;
        public int shard = 0; //end of game requirement
        public int blueKey = 0;
        public int redKey = 0;
        public int ladder = 0;

        public int Container001 = 1; //hallway container
        public int dagger = 0; //rusty daggar
        public int liquid = 0;//blue liquid
        
        public int cytents = 0;
        public int woodpuzzle1 = 0;
        public int woodpuzzleaccess = 0;
        private int _health = 100;
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
                    _health = 0;
                    Mechanics.gameOver();
                }
                else if (value >= 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
            }
        }


    }
}
