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
                //above ground
                Room WestOfHouse = new Room("West of House", "west of house");
                Room SouthOfHouse = new Room("South Of House", "");
                Room BehindHouse = new Room("Behind House", "");
                Room NorthOfHouse = new Room("North Of House", "");
                Room ForestPath = new Room("Forest Path", "");
                Room UpaTree = new Room("Up a Tree", "");
                Room Clearing1 = new Room("Clearing", "");
                Room Clearing2 = new Room("", "");
                Room Forest1 = new Room("", "");
                Room Forest2 = new Room("", "");
                Room Forest3 = new Room("", "");
                Room Forest4 = new Room("", "");
                Room CanyonView = new Room("Canyon View", "");
                Room RockyLedge = new Room("", "");
                Room CanyonBottom = new Room("", "");
                Room EndOfRainbow = new Room("", "");

                WestOfHouse.AddExit(Direction.North, NorthOfHouse);


                return WestOfHouse;
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
