using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class Room
    {
        private string Name;
        private string Description;
        private Dictionary<Direction, Room> Exits;

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Exits = new Dictionary<Direction, Room>();
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
        }
    }
}
