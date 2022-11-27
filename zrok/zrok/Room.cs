using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable]
    public class Room
    {
        private string Name;
        private string Description;
        private bool Underground = false;
        private bool Dark = false;
        private bool Entered = false;
        private Dictionary<Direction, Room> Exits;
        private List<Item> items;

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Exits = new Dictionary<Direction, Room>();
            items = new List<Item>();
        }

        public void AddExit(Direction direction, Room room)
        {
            this.Exits.Add(direction, room);
        }

        public Dictionary<Direction, Room> GetExits()
        {
            return Exits;
        }

        public string GetName()
        {
            return Name;  
        }

        public string GetDescription()
        {
            return Description;
        }

        public void Describe()
        {
            Console.WriteLine($"{this.Name}, \n{this.Description}");
            Console.WriteLine("You see:");
            foreach (var item in items)
            {
                Console.WriteLine(item.GetName());
            }
        }

        public void SimpleDescribe()
        {
            Console.WriteLine($"{this.Name}");
        }

        public void SetDark(bool choice)
        {
            Dark = choice;
        }

        public bool GetDark()
        {
            return Dark;
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public void AddItem(Item Object)
        {
            items.Add(Object);
        }

        public Item RemoveItem(String Object) 
        {
            bool found = false;
            Item founditem = null;
            foreach (var item in items)
            {
                if (item.GetName() == Object)
                {
                    found = true;
                    founditem = item;
                }
            }
            if (found)
            {
                items.Remove(founditem);
                return founditem;
            }
            else
            {
                return founditem;
            }
        }

        public bool IsUnderground()
        {
            return Underground;
        }

        public void entered()
        {
            Entered = true;
        }

        public bool GetEntered()
        {
            return Entered;
        }
    }
}
