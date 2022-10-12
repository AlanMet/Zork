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

        private Room Setup(string filename)
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
                Room Clearing2 = new Room("Clearing", "");
                Room Forest1 = new Room("Forest", "");
                Room Forest2 = new Room("Forest", "");
                Room Forest3 = new Room("Forest", "");
                Room Forest4 = new Room("Forest", "");
                Room CanyonView = new Room("Canyon View", "");
                Room RockyLedge = new Room("Rocky Ledge", "");
                Room CanyonBottom = new Room("Canyon Bottom", "");
                Room EndOfRainbow = new Room("End of Rainbow", "");
                Room Kitchen = new Room("Kitchen", "");

                //west of house exits
                WestOfHouse.AddExit(Direction.North, NorthOfHouse);
                WestOfHouse.AddExit(Direction.West, Forest1);
                WestOfHouse.AddExit(Direction.South, SouthOfHouse);

                //north of house exits
                NorthOfHouse.AddExit(Direction.North, ForestPath);
                NorthOfHouse.AddExit(Direction.West, WestOfHouse);
                NorthOfHouse.AddExit(Direction.East, BehindHouse);

                //south of house exits
                SouthOfHouse.AddExit(Direction.West, WestOfHouse);
                SouthOfHouse.AddExit(Direction.East, BehindHouse);
                SouthOfHouse.AddExit(Direction.South, Forest3);

                //behind house exits
                BehindHouse.AddExit(Direction.North, NorthOfHouse);
                BehindHouse.AddExit(Direction.South, SouthOfHouse);
                BehindHouse.AddExit(Direction.East, Clearing1);

                //clearing 1 exits
                Clearing1.AddExit(Direction.East, CanyonView);
                Clearing1.AddExit(Direction.West, BehindHouse);
                Clearing1.AddExit(Direction.South, Forest3);
                Clearing1.AddExit(Direction.North, Forest2);

                //canyon view exits
                CanyonView.AddExit(Direction.South, Forest3);
                CanyonView.AddExit(Direction.NorthWest, BehindHouse);



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
