using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    class Item
    {
        private ItemType Type;
        private string Name;
        private string Description;
        private int Health;

        public Item(string name, string description, int health)
        {
            Name = name;
            Description = description;
            Health = health;

            if (health < 0)
            {
                Type = ItemType.Weapon;
            }
            else
            {
                Type = ItemType.Food;
            }
        }

        public Item(string name, string description, int health, ItemType type)
        {
            Name = name;
            Description = description;
            Health = health;
            Type = type;
        }
    }
}
