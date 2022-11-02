using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class Thief
    {
        //The thief is a dangerous man who may kill you and steal your belongings. He wanders around the dungeon with his brief case,
        //searching for things. He usually takes for pleasure rather than profit and sometimes discards things that he doesn't think
        //are of value. During encounters with him, he could pickpocket you.
        Inventory inventory;
        int Health;

        public Thief(int health, ref Player player)
        {
            inventory = new Inventory();
            Health = health;
        }


    }
}
