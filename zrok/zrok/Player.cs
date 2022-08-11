using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    class Player
    {
        private Room room;
        private Inventory Inventory;

        public Player()
        {
            room = Setup("");
            Inventory = new Inventory();
        }

        public Room GetRoom()
        {
            return room;
        }

        public Room SetupFromFile(string filename)
        {
            //create map using file
            return null;
        }

        public Room Setup(string filename)
        {
            Room room;
            if (filename != "")
            {
                return room = SetupFromFile(filename);
            }
            else
            {
                Room main = new Room("Main", "This is the main room.");
                Room eastWing = new Room("East Wing", "This is the east wing.") { };

                main.AddExit(Direction.East, eastWing);
                eastWing.AddExit(Direction.West, main);

                return main;
            }
        }

        public void Move(Direction direction)
        {
            Room destination;

            if (room.GetExits().TryGetValue(direction, out destination))
            {
                room = destination;
            }
            else
            {
                Console.WriteLine("You cannot go that way");
            }
        }

        public void TakeObject(string Object)
        {

        }
    }
}
