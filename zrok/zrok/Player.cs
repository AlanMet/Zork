using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class Player
    {
        private Room room;
        private Inventory Inventory;

        public Player()
        {
            room = Setup();
            Inventory = new Inventory();
        }

        public Room GetRoom()
        {
            return room;
        }

        public Inventory GetInventory()
        {
            return Inventory;
        }

        private Room Setup()
        {
            //above ground
            Room WestOfHouse = new Room("West of House", "You are standing in an open field west of a white house, with a boarded front door.");
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

            //underground
            Room Cellar= new Room("Cellar", "");
            Room EastOfChasmRoom = new Room("East of Chasm", "");
            Room Gallery= new Room("", "");
            Room Studio= new Room("", "");
            Room StrangePassage= new Room("", "");
            Room CyclopsRoom= new Room("", "");
            Room TreasureRoom= new Room("", "");
            Room TrollRoom= new Room("", "");
            Room EastWestPassage= new Room("", "");
            Room RoundRoom= new Room("", "");
            Room NarrowPassage= new Room("", "");
            Room SouthMirrorRoom= new Room("", "");
            Room WindingPassage= new Room("", "");
            Room Cave= new Room("", "");//above entrance to hades
            Room EntranceToHades = new Room("", "");

            Room LandOfTheDead = new Room("", "");
            Room GratingRoom = new Room("", "");
            Room Altar = new Room("", "");
            Room Temple = new Room("", "");
            Room EgyptianRoom = new Room("", "");
            Room TorchRoom = new Room("", "");
            Room DomeRoom = new Room("", "");
            Room EngravingsCave = new Room("", "");
            Room LoudRoom = new Room("", "");
            Room DampCave = new Room("", "");
            Room NorthWhiteCliffsBeach = new Room("", "");
            Room SouthWhiteCliffsBeach = new Room("", "");
            Room NorthSouthPassage = new Room("", "");
            Room Chasm = new Room("", "");
            Room DeepCanyon = new Room("", "");
            Room Dam = new Room("", "");
            Room DamLobby = new Room("", "");
            Room MaintenanceRoom = new Room("", "");
            Room DamBase = new Room("", "");
            Room FrigidRiver1 = new Room("", "");
            Room FrigidRiver2 = new Room("", "");
            Room FrigidRiver3 = new Room("", "");
            Room FrigidRiver4 = new Room("", "");
            Room FrigidRiver5 = new Room("", "");
            Room SandyCave = new Room("", "");
            Room SandyBeach = new Room("", "");
            Room Shore = new Room("", "");
            Room AragainFalls = new Room("", "");
            Room OnTheRainbow = new Room("", "");
            Room ReservoirSouth = new Room("", "");
            Room StreamView = new Room("", "");
            Room Stream = new Room("", "");
            Room Reservoir = new Room("", "");
            Room ReservoirNorth = new Room("", "");
            Room AtlantisRoom = new Room("", "");
            Room Cave1 = new Room("", ""); //above atlantis room
            Room TwistingPassage = new Room("", "");
            Room NorthMirrorRoom = new Room("", "");
            Room ColdPassage = new Room("", "");
            Room SlideRoom = new Room("", "");
            Room MineEntrance = new Room("", "");
            Room SqueakyRoom = new Room("", "");
            Room BatRoom = new Room("", "");
            Room ShaftRoom = new Room("", "");
            Room SmellyRoom = new Room("", "");
            Room GasRoom = new Room("", "");
            Room CoalMine1 = new Room("", "");
            Room CoalMine2 = new Room("", "");
            Room CoalMine3 = new Room("", "");
            Room CoalMine4 = new Room("", "");
            Room LadderTop = new Room("", "");
            Room LadderBottom = new Room("", "");
            Room DeadEnd = new Room("", "");
            Room TimberRoom = new Room("", "");
            Room DraftyRoom = new Room("", "");
            Room MachineRoom = new Room("", "");


            //Maze
            Room Maze1 = new Room("", "");
            Room Maze2 = new Room("", "");
            Room Maze3 = new Room("", "");
            Room Maze4 = new Room("", "");
            Room Maze5 = new Room("", "");
            Room Maze6 = new Room("", "");
            Room Maze7 = new Room("", "");
            Room Maze8 = new Room("", "");
            Room Maze9 = new Room("", "");
            Room Maze10 = new Room("", "");
            Room Maze11 = new Room("", "");
            Room Maze12 = new Room("", "");
            Room Maze13 = new Room("", "");
            Room Maze14 = new Room("", "");
            Room Maze15 = new Room("", "");

            Room DeadEnd1 = new Room("", "");//ne maze4
            Room DeadEnd2 = new Room("", "");//e maze5
            Room DeadEnd3 = new Room("", "");//se maze8
            Room DeadEnd4 = new Room("", "");//up maze12


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


            //Maze1 exits
            Maze1.AddExit(Direction.North, Maze1);
            Maze1.AddExit(Direction.East, TrollRoom);
            Maze1.AddExit(Direction.South, Maze2);
            Maze1.AddExit(Direction.West, Maze4);

            //Maze2 exits
            Maze2.AddExit(Direction.South, Maze1);
            Maze2.AddExit(Direction.Down, Maze4);
            Maze2.AddExit(Direction.East, Maze3);

            //Maze3 exits
            Maze3.AddExit(Direction.West, Maze2);
            Maze3.AddExit(Direction.Up, Maze5);
            Maze3.AddExit(Direction.North, Maze4);

            //Maze4 exits
            Maze4.AddExit(Direction.North, Maze1);
            Maze4.AddExit(Direction.East, DeadEnd1);
            Maze4.AddExit(Direction.West, Maze2);

            //Maze5 exits
            Maze5.AddExit(Direction.North, Maze3);
            Maze5.AddExit(Direction.East, DeadEnd2);
            Maze5.AddExit(Direction.SouthWest, Maze6);

            //Maze6 exits
            Maze6.AddExit(Direction.West, Maze6);
            Maze6.AddExit(Direction.Up, Maze9);
            Maze6.AddExit(Direction.Down, Maze5);
            Maze6.AddExit(Direction.East, Maze7);

            //Maze7 exits
            Maze7.AddExit(Direction.West, Maze6);
            Maze7.AddExit(Direction.South, Maze15);
            Maze7.AddExit(Direction.East, Maze8);
            Maze7.AddExit(Direction.Up, Maze14);
            Maze7.AddExit(Direction.Down, DeadEnd1);

            //Maze8 exits
            Maze8.AddExit(Direction.NorthEast, Maze7);
            Maze8.AddExit(Direction.West, Maze8);
            Maze8.AddExit(Direction.SouthEast, DeadEnd3);

            //Maze9 Exits
            Maze9.AddExit(Direction.North, Maze6);
            Maze9.AddExit(Direction.NorthWest, Maze9);
            Maze9.AddExit(Direction.South, Maze13);
            Maze9.AddExit(Direction.West, Maze12);
            Maze9.AddExit(Direction.East, Maze10);
            Maze9.AddExit(Direction.Down, Maze11);

            //Maze10 exits
            Maze10.AddExit(Direction.West, Maze13);
            Maze10.AddExit(Direction.East, Maze9);
            Maze10.AddExit(Direction.SouthWest, Maze11);

            //Maze11 exits
            Maze11.AddExit(Direction.NorthEast, GratingRoom);
            Maze11.AddExit(Direction.NorthWest, Maze13);
            Maze11.AddExit(Direction.SouthWest, Maze12);
            Maze11.AddExit(Direction.Down, Maze10);

            //Maze 12 exits
            Maze12.AddExit(Direction.Up, Maze9);
            Maze12.AddExit(Direction.Down, Maze5);
            Maze12.AddExit(Direction.SouthWest, Maze11);
            Maze12.AddExit(Direction.East, Maze13);
            Maze12.AddExit(Direction.North, DeadEnd4);

            //Maze 13 exits
            Maze13.AddExit(Direction.Down, Maze12);
            Maze13.AddExit(Direction.West, Maze11);
            Maze13.AddExit(Direction.South, Maze10);
            Maze13.AddExit(Direction.East, Maze9);

            //Maze 14 exits
            Maze14.AddExit(Direction.West, Maze15);
            Maze14.AddExit(Direction.NorthEast, Maze14);
            Maze14.AddExit(Direction.North, Maze7);
            Maze14.AddExit(Direction.South, Maze7);

            //Maze 15 exits
            Maze15.AddExit(Direction.West, Maze14);
            Maze15.AddExit(Direction.South, Maze7);
            Maze15.AddExit(Direction.SouthEast, CyclopsRoom);

            //Deadend1 exits
            DeadEnd1.AddExit(Direction.South, Maze4);

            //Deadend2 exits
            DeadEnd2.AddExit(Direction.West, Maze5);

            //Deadend3 exits
            DeadEnd3.AddExit(Direction.North, Maze8);

            //Deadend4 exits
            DeadEnd4.AddExit(Direction.South, Maze12);


            return WestOfHouse;
        }

        public void ShowInventory()
        {
            Inventory.Show();
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
            Item item = this.room.RemoveItem(Object);

            bool confirmed = this.Inventory.Add(item);
            if (confirmed)
            {
                Console.WriteLine("Taken");
            }
            else
            {
                Console.WriteLine("You are holding too many items");
            }

        }

        public void TakeAll()
        {
            int count = 0;
            foreach (Item value in room.GetItems())
            {
                Item item = this.room.RemoveItem(value.GetName());

                bool confirmed = this.Inventory.Add(item);
                if (confirmed)
                {
                    count++;
                    Console.WriteLine($"Taken {value.GetName()}");
                }
                else
                {
                    Console.WriteLine("You are holding too many items");
                    Console.WriteLine($"Took {count} items");
                    return;
                }
            }
        }

        public void DropObject(string Object)
        {
            this.room.AddItem(this.Inventory.Remove(Object));
            Console.WriteLine("Dropped");
        }

        public void LookAt(string Object)
        {
            if (Object == room.GetName() || Object == "room") 
            {
                room.Describe();
            }
            else
            {
                List<Item> items = room.GetItems();
                foreach (var item in items)
                {
                    if (item.GetName() == Object)
                    {
                        Console.WriteLine(item.GetDescription());
                        return;
                    }
                }
                Console.WriteLine("That item is not in this room");
            }
        }
    }
}
