using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zrok
{
    [Serializable]
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
            Room SouthOfHouse = new Room("South Of House", "You are facing the south side of a white house. There is no door here and all the windows are boarded.");
            WindowRoom BehindHouse = new WindowRoom("Behind House", "You are behind the white house. A path leads to the forest to the east. In one corner of the house there is a small window which is slightly ajar.");
            Room NorthOfHouse = new Room("North Of House", "You are facing the north side of a white house. There is no door here, and all the windows are boarded up. To the north a narrow path winds through thre trees.");
            Room ForestPath = new Room("Forest Path", "This is a path winding through a dimly lit forest. The path heads north-south here. One particularly large tree with some low branches stands at the edge of the path.");
            Room UpaTree = new Room("Up a Tree", "You are about 10 feet above the ground nestled among some large branches. The nearest branch above you is above your reach.");
            Room Clearing1 = new Room("Clearing", "You are in a clearing, with a forest surrounding you on all sides. A path leads south.");
            Room Clearing2 = new Room("Clearing", "You are in a small clearing in a well marked forest path that extends to the east and west.");
            Room Forest1 = new Room("Forest", "This is a forest, with trees in all directions. To the east there appears to be sunlight.");
            Room Forest2 = new Room("Forest", "This is a dimly lit forest, with large trees all around.");
            Room Forest3 = new Room("Forest", "This is a dimly lit forest, with large trees all around.");
            Room Forest4 = new Room("Forest", "The forest thins out, revealing impassable mountains ");
            Room CanyonView = new Room("Canyon View", "You are at the top of the Great Canyon on its west wall. From here there is a marvelous view of the canyon and parts of the Frigid river upstream. Across the canyon, the walls of the White Cliffs join the mighty ramparts of the Flathead mountains to the east. Following the Canyon upstream to the north, Aragain Falls may be seen complete with a rainbow. The might Frigid River flows out from a great dark cavern. To the west and south can be seen an immense forest stretching for miles around. A path leads northwest. It is possible to climb down into the canyon from here.");
            Room RockyLedge = new Room("Rocky Ledge", "You are on a ledge halfway up the wall of the river canyon. You can see from here yjay yje main flow from Argain falls twists with along a passage which it is impossible to for you to enter. Below you is the canyon bottom. Above you is more cliff, which appears climbable.");
            Room CanyonBottom = new Room("Canyon Bottom", "You are beneath the walls of the river canyon which may be climbable here. The lesser part of the runoff of Argain Falls flows by below. To the north is a narrow path.");
            Room EndOfRainbow = new Room("End of Rainbow", "You are on a small, rocky beach on the continuation of the Frigid River past the Falls. The beach is narrow due to the presence of the White Cliffs. the river canyon opens here and the sunlight shines in from above. A rainbow crosses over the falls the east and a narrow path continues to the southwest.");
            Room Kitchen = new Room("Kitchen", "You are in the kitchen of the white house. A table seems to have been used recently for the preparation of food. A passage leads to the west and a dark staircase can be seen leading upward. A dark chimney leads down and to the east is a small window which is {state}");
            Room LivingRoom = new Room("Living Room", "You are in the living room. There is a doorway to the east, a wooden door with strange gothic lettering to the west, which appears to be nailed shut, a trophy case, and a large oriental rug is in the center of the room.");
            Room Cellar = new Room("Attic","This is the attic. The only exit is a stairway leading down.");

            //underground
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


            //west of house exits and items
            WestOfHouse.AddExit(Direction.North, NorthOfHouse);
            WestOfHouse.AddExit(Direction.West, Forest1);
            WestOfHouse.AddExit(Direction.South, SouthOfHouse);

            
            Item leaflet = new Item("Leaflet", "'Welcome To Zork!'\n\n Zork is a game of adventure and danger, and low cunnin. In it you will explore some of the most amazing territory ever seen by mortals. No comuter should be without one! ");
            leaflet.AddSynonym("leaflet");
            leaflet.AddSynonym("Leaflet");
            leaflet.AddSynonym("paper");
            Container mailbox = new Container("mailbox", "mailbox", false, "It is firmly attached to the ground");
            mailbox.AddSynonym("box");
            mailbox.AddItem(leaflet);
            //string name, string description, bool takeable,  string negative
            mailbox.SetTakeable();
            WestOfHouse.AddItem(mailbox);



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
            BehindHouse.AddWindowExit(Direction.East, Kitchen);

            //clearing 1 exits
            Clearing1.AddExit(Direction.East, CanyonView);
            Clearing1.AddExit(Direction.West, BehindHouse);
            Clearing1.AddExit(Direction.South, Forest3);
            Clearing1.AddExit(Direction.North, Forest2);

            //canyon view exits
            CanyonView.AddExit(Direction.West, Forest3);
            CanyonView.AddExit(Direction.NorthWest, BehindHouse);
            CanyonView.AddExit(Direction.Down, RockyLedge);
            
            //rocky ledge exits
            RockyLedge.AddExit(Direction.Up, CanyonView);
            RockyLedge.AddExit(Direction.Down, CanyonBottom);

            //Canyon bottom exits
            CanyonBottom.AddExit(Direction.Up, RockyLedge);
            CanyonBottom.AddExit(Direction.North, EndOfRainbow);


            //forest 3 exits
            Forest3.AddExit(Direction.North, Clearing1);
            Forest3.AddExit(Direction.NorthWest, SouthOfHouse);
            Forest3.AddExit(Direction.West, Forest1);

            //forest1 exits
            Forest1.AddExit(Direction.North, Clearing1);
            Forest1.AddExit(Direction.East, ForestPath);
            Forest1.AddExit(Direction.South, Forest3);

            //forest path exits
            ForestPath.AddExit(Direction.South, SouthOfHouse);
            ForestPath.AddExit(Direction.North , Clearing2);//hmm
            ForestPath.AddExit(Direction.West , Forest1);
            ForestPath.AddExit(Direction.East , Forest2);
            ForestPath.AddExit(Direction.Up , UpaTree);


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
            //check room type of exit and current room
            //if current room or exit room is a windowroom
            //check Open type of room
            Room destination;
            WindowRoom destination2;

            if (room.GetExits().TryGetValue(direction, out destination))
            {
                if (destination.GetType() == typeof(WindowRoom))
                {
                    destination2 = (WindowRoom)destination;
                    if (destination2.GetOpen())
                    {
                        room = destination;
                    }
                }
                if (room.GetType() == typeof(WindowRoom))
                {
                    destination2 = (WindowRoom)room;
                    if (destination2.GetOpen())
                    {
                        room = destination;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("You cannot go that way");
            }
        }

        public bool TakeRoomItem(string Object)
        {
            return true;
        }

        public void TakeObject(string Object)
        {
            Item item1 = null;
            string dialogue = null;
            foreach (var item in room.GetItems())
            {
                if (item.IsSynonym(Object))
                {
                    if (item.GetTakeable())
                    {
                        bool succesful = this.Inventory.Add(item);
                        if (succesful)
                        {
                            room.RemoveItem(item.GetName());
                            dialogue = item.GetTakeableDialogue();
                        }
                    }
                    else
                    {
                        dialogue = item.GetTakeableDialogue();
                    }
                    
                }
                else
                {
                    if (item.GetType() == typeof(Container))
                    {
                        Container container2 = (Container)item;
                        if (container2.GetOpened())
                        {
                            Container container = (Container)item;
                            foreach (var containeritem in container.GetItems())
                            {
                                if (containeritem.IsSynonym(Object))
                                {
                                    if (containeritem.GetTakeable())
                                    {
                                        bool succesful = this.Inventory.Add(containeritem);
                                        if (succesful)
                                        {
                                            container.RemoveItem(containeritem.GetName());
                                            item1 = item;
                                            dialogue = containeritem.GetTakeableDialogue();
                                        }
                                    }
                                    else
                                    {
                                        dialogue = containeritem.GetTakeableDialogue();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (dialogue != null)
            {
                Console.WriteLine(dialogue);
            }
            else
            {
                Console.WriteLine("You don't see that");
            }
        }

        public void OpenObject(string Object)
        {
            if (Object == "Window")
            {
                if (room.GetType() == typeof(WindowRoom))
                {

                }
            }
            foreach (var item in room.GetItems())
            {
                if (item.GetType() == typeof(Container) && item.IsSynonym(Object))
                {
                    var newitem = (Container)item;
                    newitem.Open();
                    return;
                }
            }
        }

        public void CloseObject(string Object)
        {
            foreach (var item in room.GetItems())
            {
                if (item.GetType() == typeof(Container) && item.IsSynonym(Object))
                {
                    var newitem = (Container)item;
                    newitem.Close();
                }
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
