using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    class Item
    {
        private string Name;
        private string Description;
        private string Sound = null;

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Item(string name, string description, int health)
        {
            Name = name;
            Description = description;
        }

        public void listen()
        {
            if (Sound == null)
            {
                Console.WriteLine($"The {Name} makes no sound.");
            }
            else
            {
                Console.WriteLine($"The {Name} {Sound}");
            }
        }
    }
}
