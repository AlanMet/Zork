using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
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
            TrapDoorRoom Clearing1 = new TrapDoorRoom("Clearing", "You are in a clearing, with a forest surrounding you on all sides. A path leads south. There is a pile of leaves on the ground.");
            Room Clearing2 = new Room("Clearing", "You are in a small clearing in a well marked forest path that extends to the east and west.");
            Room Forest1 = new Room("Forest", "This is a forest, with trees in all directions. To the east there appears to be sunlight.");
            Room Forest2 = new Room("Forest", "This is a dimly lit forest, with large trees all around.");
            Room Forest3 = new Room("Forest", "This is a dimly lit forest, with large trees all around.");
            Room Forest4 = new Room("Forest", "The forest thins out, revealing impassable mountains ");
            Room CanyonView = new Room("Canyon View", "You are at the top of the Great Canyon on its west wall. From here there is a marvelous view of the canyon and parts of the Frigid river upstream. Across the canyon, the walls of the White Cliffs join the mighty ramparts of the Flathead mountains to the east. Following the Canyon upstream to the north, Aragain Falls may be seen complete with a rainbow. The might Frigid River flows out from a great dark cavern. To the west and south can be seen an immense forest stretching for miles around. A path leads northwest. It is possible to climb down into the canyon from here.");
            Room RockyLedge = new Room("Rocky Ledge", "You are on a ledge halfway up the wall of the river canyon. You can see from here yjay yje main flow from Argain falls twists with along a passage which it is impossible to for you to enter. Below you is the canyon bottom. Above you is more cliff, which appears climbable.");
            Room CanyonBottom = new Room("Canyon Bottom", "You are beneath the walls of the river canyon which may be climbable here. The lesser part of the runoff of Argain Falls flows by below. To the north is a narrow path.");
            Room EndOfRainbow = new Room("End of Rainbow", "You are on a small, rocky beach on the continuation of the Frigid River past the Falls. The beach is narrow due to the presence of the White Cliffs. the river canyon opens here and the sunlight shines in from above. A rainbow crosses over the falls the east and a narrow path continues to the southwest.");
            Room Kitchen = new Room("Kitchen", $"You are in the kitchen of the white house. A table seems to have been used recently for the preparation of food. A passage leads to the west and a dark staircase can be seen leading upward. A dark chimney leads down and to the east is a small window which is open");
            TrapDoorRoom LivingRoom = new TrapDoorRoom("Living Room", "You are in the living room. There is a doorway to the east, a wooden door with strange gothic lettering to the west, which appears to be nailed shut, a trophy case, and a large oriental rug is in the center of the room.");
            Room Attic = new Room("Attic","This is the attic. The only exit is a stairway leading down.");
            Room Cellar = new Room("Cellar", "You are in a dark and damp cellar with a narrow passageway leading north, and a crawlway to the south. On the west is the bottom of a steep metal ramp which is unclimbable. The trap door crashes shut, and you hear someone barring it.");
            

            //underground
            Room EastOfChasmRoom = new Room("East of Chasm", "You are on the east edge of a chasm, the bottom of which cannot be seen. A narrow passage goes north, and the path you are on continues to the east.");
            Room Gallery = new Room("Gallery", "This is an art gallery. Most of the paintings have been stolen by vandals with exceptional taste. The vandals left through either the north or west exits.\r\n\r\nFortunately, there is still one chance for you to be a vandal, for on the far wall is a painting of unparalleled beauty.\r\n\r\n ");
            Room Studio= new Room("Studio", "This appears to have been an artist's studio. The walls and floors are splattered with paints of 69 different colors. Strangely enough, nothing of value is hanging here. At the south end of the room is an open door (also covered with paint). A dark and narrow chimney leads up from a fireplace; although you might be able to get up it, it seems unlikely you could get back down.\r\n\r\nLoosely attached to a wall is a small piece of paper.\r\n\r\n ");
            Room StrangePassage= new Room("Strange Passge", "This is a long passage. To the west is one entrance. On the east there is an old wooden door, with a large opening in it (about cyclops sized).");
            Room CyclopsRoom= new Room("Cyclops room", "This room has an exit on the northwest, and a staircase leading up. There is a painting of a cyclops on the wall.");
            Room TreasureRoom= new Room("Treasure Room", "This is a large room, whose east wall is solid granite. A number of discarded bags, which crumble at your touch, are scattered about on the floor. There is an exit down a staircase. You see a silver chalice on the ground.");
            Room TrollRoom= new Room("Troll room", "You see an image of a troll on the wall, it does nothing.");
            Room EastWestPassage= new Room("East-West Passage", "");
            Room RoundRoom= new Room("Round Room", "This is a circular stone room with passages in all directions. Several of them have unfortunately been blocked by cave-ins.");
            Room NarrowPassage= new Room("Narrow Passage", "");
            Room SouthMirrorRoom= new Room("South Mirror Room", "Mirror Room\r\n\r\nYou are in a large square room with tall ceilings. On the south wall is an enormous mirror which fills the entire wall. There are exits on the other three sides of the room.");
            Room WindingPassage= new Room("Winding Passage", "");
            Room Cave= new Room("Cave", "");//above entrance to hades
            Room EntranceToHades = new Room("Entrance to Hades", "");

            Room LandOfTheDead = new Room("Land Of The Dead", "You see a crystal skull on the ground.");
            Room GratingRoom = new Room("Grating Room", "");
            Room Altar = new Room("Altar", "");
            Room Temple = new Room("Temple", "");
            Room EgyptianRoom = new Room("Egyptian Room", "You see a gold coffin on the ground.");
            Room TorchRoom = new Room("Torch Room", "");
            Room DomeRoom = new Room("Dome Room", "");
            Room EngravingsCave = new Room("Engravings Cave", "");
            Room LoudRoom = new Room("Loud Room", "You see a platinum bar on the ground.");
            Room DampCave = new Room("Damp Cave", "");
            Room NorthWhiteCliffsBeach = new Room("North White Cliffs Beach", "");
            Room SouthWhiteCliffsBeach = new Room("South White Cliffs Beach", "");
            Room NorthSouthPassage = new Room("North South Passage", "");
            Room Chasm = new Room("Chasm", "");
            Room DeepCanyon = new Room("Deep Canyon", "");
            Room Dam = new Room("Dam", "");
            Room DamLobby = new Room("Dam Lobby", "");
            Room MaintenanceRoom = new Room("Maintenance Room", "");
            Room DamBase = new Room("Dam Base", "");
            Room FrigidRiver1 = new Room("Frigid River", "");
            Room FrigidRiver2 = new Room("Frigid River", "");
            Room FrigidRiver3 = new Room("Fridgid River", "");
            Room FrigidRiver4 = new Room("Frigid River", "");
            Room FrigidRiver5 = new Room("Fridgid River", "");
            Room SandyCave = new Room("Sandy Cave", "");
            Room SandyBeach = new Room("Sandy Beach", "");
            Room Shore = new Room("Shore", "");
            Room AragainFalls = new Room("Argain Falls", "");
            Room OnTheRainbow = new Room("On The Rainbow", "");
            Room ReservoirSouth = new Room("Southern Reservoir", "");
            Room StreamView = new Room("Stream View", "");
            Room Stream = new Room("Stream", "");
            Room Reservoir = new Room("Reservoir", "You see a trunk of jewels on the ground.");
            Room ReservoirNorth = new Room("North Reservoir", "");
            Room AtlantisRoom = new Room("Atlantis Room", "You see a crystal trident on the ground");
            Room Cave1 = new Room("Cave 1", ""); //above atlantis room
            Room TwistingPassage = new Room("Twisting passage", "");
            Room NorthMirrorRoom = new Room("North Mirror Room", "");
            Room ColdPassage = new Room("Cold Passage", "");
            Room SlideRoom = new Room("Slide Room", "");
            Room MineEntrance = new Room("Mine Entrance", "");
            Room SqueakyRoom = new Room("Squeeky Room", "");
            Room BatRoom = new Room("Bat Room", "You see a jade figurine on the ground");
            Room ShaftRoom = new Room("Shaft Room", "");
            Room SmellyRoom = new Room("Smelly Room", "");
            Room GasRoom = new Room("Gas Room", "You see a sapphire bracelet on the ground.");
            Room CoalMine1 = new Room("Coal Mine", "");
            Room CoalMine2 = new Room("Coal Mine", "");
            Room CoalMine3 = new Room("Coal Mine", "");
            Room CoalMine4 = new Room("Coal Mine", "");
            Room LadderTop = new Room("Coal Mine", "");
            Room LadderBottom = new Room("Bottom Of A ladder", "");
            Room DeadEnd = new Room("Dead End", "");
            Room TimberRoom = new Room("Timber Room", "");
            Room DraftyRoom = new Room("Drafty Room", "");
            Room MachineRoom = new Room("Machine Room", "");


            //Maze
            Room Maze1 = new Room("Maze", "You are in a maze.");
            Room Maze2 = new Room("Maze", "You are in a maze.");
            Room Maze3 = new Room("Maze", "You are in a maze.");
            Room Maze4 = new Room("Maze", "You are in a maze.");
            Room Maze5 = new Room("Maze", "You are in a maze. You see a bag of coins on the ground.");
            Room Maze6 = new Room("Maze", "You are in a maze.");
            Room Maze7 = new Room("Maze", "You are in a maze.");
            Room Maze8 = new Room("Maze", "You are in a maze.");
            Room Maze9 = new Room("Maze", "You are in a maze.");
            Room Maze10 = new Room("Maze", "You are in a maze.");
            Room Maze11 = new Room("Maze", "You are in a maze.");
            Room Maze12 = new Room("Maze", "You are in a maze.");
            Room Maze13 = new Room("Maze", "You are in a maze.");
            Room Maze14 = new Room("Maze", "You are in a maze.");
            Room Maze15 = new Room("Maze", "You are in a maze.");

            Room DeadEnd1 = new Room("Dead End", "You are in a dead end.");//ne maze4
            Room DeadEnd2 = new Room("Dead End", "You are in a dead end.");//e maze5
            Room DeadEnd3 = new Room("Dead End", "You are in a dead end.");//se maze8
            Room DeadEnd4 = new Room("Dead End", "ou are in a dead end.");//up maze12

            Room DeadEnd5 = new Room("Dead End", "ou are in a dead end.");//south ladder


            //west of house exits and items
            WestOfHouse.AddExit(Direction.North, NorthOfHouse);
            WestOfHouse.AddExit(Direction.West, Forest1);
            WestOfHouse.AddExit(Direction.South, SouthOfHouse);

            
            Item leaflet = new Item("Leaflet", "'Welcome To Zork!'\n\n Zork is a game of adventure and danger, and low cunnin. In it you will explore some of the most amazing territory ever seen by mortals. No comuter should be without one! ");
            leaflet.AddSynonym("leaflet");
            leaflet.AddSynonym("paper");
            Container mailbox = new Container("mailbox", "mailbox", false, "It is firmly attached to the ground");
            mailbox.AddSynonym("box");
            mailbox.AddItem(leaflet);
            //string name, string description, bool takeable,  string negative
            mailbox.SetTakeable(false);
            WestOfHouse.AddItem(mailbox);

            //forest patgh exits
            ForestPath.AddExit(Direction.Up, UpaTree);
            ForestPath.AddExit(Direction.North, Clearing1);
            ForestPath.AddExit(Direction.West, Forest1);
            ForestPath.AddExit(Direction.South, NorthOfHouse);
            ForestPath.AddExit(Direction.East, Forest2);

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
            BehindHouse.AddExit(Direction.West, Kitchen);

            //kitchen exits
            Kitchen.AddExit(Direction.West, LivingRoom);
            Kitchen.AddExit(Direction.East, BehindHouse);
            Kitchen.AddExit(Direction.Up, Attic);

            //living room exits
            LivingRoom.AddExit(Direction.Down, Cellar);
            LivingRoom.AddExit(Direction.East, Kitchen);

            //living room items
            Lamp BrassLantern = new Lamp("Brass Lantern", "");
            BrassLantern.AddSynonym("lantern");
            BrassLantern.AddSynonym("lamp");
            LivingRoom.AddItem(BrassLantern);

            Item ElvishSword = new Item("Elvish Sword", "");
            ElvishSword.AddSynonym("sword");
            LivingRoom.AddItem(ElvishSword);

            TrophyCase trophyCase = new TrophyCase("Trophy Case", "");
            trophyCase.AddSynonym("case");
            trophyCase.AddSynonym("trophycase");
            trophyCase.SetTakeable(false);
            LivingRoom.AddItem(trophyCase);

            //cellar exits
            Cellar.AddExit(Direction.South, EastOfChasmRoom);
            Cellar.AddExit(Direction.Up, StrangePassage);
            Cellar.AddExit(Direction.North, TrollRoom);

            StrangePassage.AddExit(Direction.Up, CyclopsRoom);

            //eastofchasmroom exits
            EastOfChasmRoom.AddExit(Direction.North, Cellar);
            EastOfChasmRoom.AddExit(Direction.East, Gallery);

            CyclopsRoom.AddExit(Direction.Down, TreasureRoom);
            CyclopsRoom.AddExit(Direction.NorthWest, Maze15);

            GratingRoom.AddExit(Direction.Up, Clearing1);
            GratingRoom.AddExit(Direction.SouthWest, Maze1);

            EastWestPassage.AddExit(Direction.West, TrollRoom);
            EastWestPassage.AddExit(Direction.North, Chasm);
            EastWestPassage.AddExit(Direction.East, RoundRoom);

            RoundRoom.AddExit(Direction.South, NarrowPassage);
            RoundRoom.AddExit(Direction.SouthEast, EngravingsCave);
            RoundRoom.AddExit(Direction.North, NorthSouthPassage);
            RoundRoom.AddExit(Direction.East, LoudRoom);
            RoundRoom.AddExit(Direction.West, EastWestPassage);

            NarrowPassage.AddExit(Direction.North, RoundRoom);
            NarrowPassage.AddExit(Direction.South, SouthMirrorRoom);

            SouthMirrorRoom.AddExit(Direction.North, NarrowPassage);
            SouthMirrorRoom.AddExit(Direction.West, WindingPassage);
            SouthMirrorRoom.AddExit(Direction.East, Cave);

            Cave.AddExit(Direction.North, SouthMirrorRoom);
            Cave.AddExit(Direction.West, WindingPassage);
            Cave.AddExit(Direction.Down, EntranceToHades);

            EntranceToHades.AddExit(Direction.Up, Cave);
            EntranceToHades.AddExit(Direction.South, LandOfTheDead);

            LandOfTheDead.AddExit(Direction.North, EntranceToHades);

            EngravingsCave.AddExit(Direction.East, DomeRoom);
            EngravingsCave.AddExit(Direction.NorthWest, RoundRoom);

            DomeRoom.AddExit(Direction.Down, TorchRoom);
            DomeRoom.AddExit(Direction.West, EngravingsCave);

            TorchRoom.AddExit(Direction.South, Temple);

            Temple.AddExit(Direction.North, TorchRoom);
            Temple.AddExit(Direction.East, EgyptianRoom);
            Temple.AddExit(Direction.South, Altar);

            Altar.AddExit(Direction.North, Temple);
            Altar.AddExit(Direction.Down, Cave);

            EgyptianRoom.AddExit(Direction.West, Temple);

            Chasm.AddExit(Direction.SouthWest, EastWestPassage);
            Chasm.AddExit(Direction.South, NorthSouthPassage);
            Chasm.AddExit(Direction.NorthWest, ReservoirSouth);

            DeepCanyon.AddExit(Direction.Down, LoudRoom);
            DeepCanyon.AddExit(Direction.SouthWest, NorthSouthPassage);
            DeepCanyon.AddExit(Direction.NorthWest, ReservoirNorth);

            NorthSouthPassage.AddExit(Direction.South, RoundRoom);
            NorthSouthPassage.AddExit(Direction.North, Chasm);
            NorthSouthPassage.AddExit(Direction.NorthEast, DeepCanyon);

            ReservoirSouth.AddExit(Direction.North, Reservoir);
            ReservoirSouth.AddExit(Direction.SouthWest, Chasm);
            ReservoirSouth.AddExit(Direction.SouthEast, DeepCanyon);
            ReservoirSouth.AddExit(Direction.West, StreamView);

            StreamView.AddExit(Direction.North, Stream);
            StreamView.AddExit(Direction.East, ReservoirSouth);

            Stream.AddExit(Direction.South, StreamView);
            Stream.AddExit(Direction.East, Reservoir);

            Reservoir.AddExit(Direction.North, ReservoirNorth);
            Reservoir.AddExit(Direction.South, ReservoirSouth);
            Reservoir.AddExit(Direction.West, Stream);

            ReservoirNorth.AddExit(Direction.North, AtlantisRoom);
            ReservoirNorth.AddExit(Direction.South, Reservoir);

            AtlantisRoom.AddExit(Direction.Up, Cave1);
            AtlantisRoom.AddExit(Direction.South, ReservoirNorth);

            Cave1.AddExit(Direction.South, AtlantisRoom);
            Cave1.AddExit(Direction.North, NorthMirrorRoom);
            Cave1.AddExit(Direction.West, TwistingPassage);

            TwistingPassage.AddExit(Direction.North, NorthMirrorRoom);
            TwistingPassage.AddExit(Direction.East, Cave);

            NorthMirrorRoom.AddExit(Direction.West, TwistingPassage);
            NorthMirrorRoom.AddExit(Direction.East, Cave1);
            NorthMirrorRoom.AddExit(Direction.North, ColdPassage);

            ColdPassage.AddExit(Direction.West, SlideRoom);
            ColdPassage.AddExit(Direction.South, NorthMirrorRoom);

            SlideRoom.AddExit(Direction.Down, Cellar);
            SlideRoom.AddExit(Direction.East, ColdPassage);
            SlideRoom.AddExit(Direction.North, MineEntrance);

            MineEntrance.AddExit(Direction.West, SqueakyRoom);
            MineEntrance.AddExit(Direction.South, SlideRoom);

            SqueakyRoom.AddExit(Direction.North, BatRoom);
            SqueakyRoom.AddExit(Direction.East, MineEntrance);

            BatRoom.AddExit(Direction.South, SqueakyRoom);
            BatRoom.AddExit(Direction.East, ShaftRoom);

            ShaftRoom.AddExit(Direction.North, SmellyRoom);
            ShaftRoom.AddExit(Direction.West, BatRoom);

            SmellyRoom.AddExit(Direction.South, ShaftRoom);
            SmellyRoom.AddExit(Direction.Down, GasRoom);

            GasRoom.AddExit(Direction.Up, SmellyRoom);
            GasRoom.AddExit(Direction.East, CoalMine1);

            CoalMine1.AddExit(Direction.East, CoalMine1);
            CoalMine1.AddExit(Direction.North, GasRoom);
            CoalMine1.AddExit(Direction.NorthEast, CoalMine2);

            CoalMine2.AddExit(Direction.South, CoalMine1);
            CoalMine2.AddExit(Direction.North, CoalMine2);
            CoalMine2.AddExit(Direction.East, CoalMine3);

            CoalMine3.AddExit(Direction.West, CoalMine2);
            CoalMine3.AddExit(Direction.SouthWest, CoalMine4);
            CoalMine3.AddExit(Direction.South, CoalMine3);

            CoalMine4.AddExit(Direction.North, CoalMine3);
            CoalMine4.AddExit(Direction.West, CoalMine4);
            CoalMine4.AddExit(Direction.Down, LadderBottom);

            LadderBottom.AddExit(Direction.South, DeadEnd5);
            LadderBottom.AddExit(Direction.West, TimberRoom);

            TimberRoom.AddExit(Direction.East, LadderBottom);
            TimberRoom.AddExit(Direction.West, DraftyRoom);

            DraftyRoom.AddExit(Direction.East, TimberRoom);
            DraftyRoom.AddExit(Direction.South, MachineRoom);

            MachineRoom.AddExit(Direction.North, DraftyRoom);

            DeadEnd5.AddExit(Direction.North, LadderBottom);

            //damp cave exits
            DampCave.AddExit(Direction.West, LoudRoom);
            DampCave.AddExit(Direction.East, NorthWhiteCliffsBeach);

            //white cliffs beach
            NorthWhiteCliffsBeach.AddExit(Direction.West, DampCave);
            NorthWhiteCliffsBeach.AddExit(Direction.South, SouthWhiteCliffsBeach);

            //white cliffs beach 
            SouthWhiteCliffsBeach.AddExit(Direction.North, NorthWhiteCliffsBeach);


            //attic exits
            Attic.AddExit(Direction.Down, Kitchen);

            //attic items
            Item Rope = new Item("Rope", "");
            Rope.AddSynonym("rope");
            Rope.SetTakeable(true);
            Attic.AddItem(Rope);

            Item Knife = new Item("nasty-looking knife", "");
            Knife.AddSynonym("knife");
            Knife.SetTakeable(true);
            Attic.AddItem(Knife);

            //studio exits
            Studio.AddExit(Direction.South, Gallery);
            Studio.AddExit(Direction.Up, Kitchen);

            //clearing1
            Clearing1.AddExit(Direction.West, Forest1);
            Clearing1.AddExit(Direction.East, Forest2);
            Clearing1.AddExit(Direction.South, ForestPath);
            Clearing1.AddExit(Direction.Down, GratingRoom);

            //clearing 2 exits
            Clearing2.AddExit(Direction.East, CanyonView);
            Clearing2.AddExit(Direction.West, BehindHouse);
            Clearing2.AddExit(Direction.South, Forest3);
            Clearing2.AddExit(Direction.North, Forest2);

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
            EndOfRainbow.AddExit(Direction.South, CanyonBottom);

            //winding passage rooms
            WindingPassage.AddExit(Direction.North, SouthMirrorRoom);
            WindingPassage.AddExit(Direction.East, Cave);

            //forest 3 exits
            Forest3.AddExit(Direction.North, Clearing1);
            Forest3.AddExit(Direction.NorthWest, SouthOfHouse);
            Forest3.AddExit(Direction.West, Forest1);

            //forest 4
            Forest4.AddExit(Direction.North, Forest2);
            Forest4.AddExit(Direction.South, Forest2);
            Forest2.AddExit(Direction.West, Forest2);

            //forest 2 exits
            Forest2.AddExit(Direction.South, Clearing1);
            Forest2.AddExit(Direction.East, Forest4);

            //forest1 exits
            Forest1.AddExit(Direction.North, Clearing1);
            Forest1.AddExit(Direction.East, ForestPath);
            Forest1.AddExit(Direction.South, Forest3);

            TrollRoom.AddExit(Direction.South, Cellar);
            TrollRoom.AddExit(Direction.West, Maze1);
            TrollRoom.AddExit(Direction.East, EastWestPassage);

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


            //treasure rooms
            UpaTree.AddExit(Direction.Down, ForestPath);
            Item JewelEncrustedEgg = new Item("Jewel-encrusted egg", "");
            JewelEncrustedEgg.SetTrasure(true);
            JewelEncrustedEgg.SetTakeable(true);
            JewelEncrustedEgg.AddSynonym("egg");
            UpaTree.AddItem(JewelEncrustedEgg);

            Gallery.AddExit(Direction.West, EastOfChasmRoom);
            Gallery.AddExit(Direction.North, Studio);
            Item Painting = new Item("Painting", "A painting of unparalleled beauty");
            Painting.AddSynonym("painting");
            Painting.SetTrasure(true);
            Painting.SetTakeable(true);
            Gallery.AddItem(Painting);

            GasRoom.AddExit(Direction.Down, SmellyRoom);
            Item SapphireBracelet = new Item("Sapphire Bracelet", "");
            SapphireBracelet.AddSynonym("bracelet");
            SapphireBracelet.SetTrasure(true);
            SapphireBracelet.SetTakeable(true);
            GasRoom.AddItem(SapphireBracelet);

            Item JadeFigurine = new Item("Jade Figurine", "");
            JadeFigurine.AddSynonym("figurine");
            JadeFigurine.SetTrasure(true);
            JadeFigurine.SetTakeable(true);
            BatRoom.AddItem(JadeFigurine);

            Item CrystalTrident = new Item("Crystal Trident", "");
            CrystalTrident.AddSynonym("trident");
            CrystalTrident.SetTrasure(true);
            CrystalTrident.SetTakeable(true);
            AtlantisRoom.AddItem(CrystalTrident);

            Item TrunkOfJewels = new Item("Trunk of Jewels", "");
            TrunkOfJewels.AddSynonym("jewels");
            TrunkOfJewels.SetTrasure(true);
            TrunkOfJewels.SetTakeable(true);
            Reservoir.AddItem(TrunkOfJewels);

            LoudRoom.AddExit(Direction.Up, DeepCanyon);
            LoudRoom.AddExit(Direction.West, RoundRoom);
            LoudRoom.AddExit(Direction.East, DampCave);
            Item PlatinumBar = new Item("Platinum Bar", "");
            PlatinumBar.AddSynonym("bar");
            PlatinumBar.SetTrasure(true);
            PlatinumBar.SetTakeable(true);
            LoudRoom.AddItem(PlatinumBar);

            Item BafOfCoins = new Item("Bag Of Coins", "");
            BafOfCoins.SetTrasure(true);
            BafOfCoins.SetTakeable(true);
            BafOfCoins.AddSynonym("Bag");
            BafOfCoins.AddSynonym("Coins");
            Maze5.AddItem(BafOfCoins);

            Item CrystalSkull = new Item("Crystal Skull", "");
            CrystalSkull.AddSynonym("skull");
            CrystalSkull.SetTrasure(true);
            CrystalSkull.SetTakeable(true);
            LandOfTheDead.AddItem(CrystalSkull);

            Item GoldCoffin = new Item("Gold Coffin", "");
            GoldCoffin.SetTrasure(true);
            GoldCoffin.SetTakeable(true);
            GoldCoffin.AddSynonym("Coffin");
            EgyptianRoom.AddItem(GoldCoffin);

            //setting dark rooms
            Attic.SetDark(true);
            Cellar.SetDark(true);
            EastOfChasmRoom.SetDark(true);
            Gallery.SetDark(true);
            Studio.SetDark(true);
            TrollRoom.SetDark(true);
            StrangePassage.SetDark(true);
            CyclopsRoom.SetDark(true);
            TreasureRoom.SetDark(true);
            EastWestPassage.SetDark(true);
            RoundRoom.SetDark(true);
            NarrowPassage.SetDark(true);
            NorthMirrorRoom.SetDark(true);
            SouthMirrorRoom.SetDark(true);
            WindingPassage.SetDark(true);
            Cave.SetDark(true);
            EntranceToHades.SetDark(true);
            LandOfTheDead.SetDark(true);
            Altar.SetDark(true);
            Temple.SetDark(true);
            EgyptianRoom.SetDark(true);
            TorchRoom.SetDark(true);
            EngravingsCave.SetDark(true);
            DomeRoom.SetDark(true);
            LoudRoom.SetDark(true);
            DampCave.SetDark(true);
            NorthSouthPassage.SetDark(true);
            Chasm.SetDark(true);
            DeepCanyon.SetDark(true);
            GratingRoom.SetDark(true);
            Cave.SetDark(true);
            Cave1.SetDark(true);
            TwistingPassage.SetDark(true);
            ColdPassage.SetDark(true);
            SlideRoom.SetDark(true);
            MineEntrance.SetDark(true);
            SqueakyRoom.SetDark(true);
            BatRoom.SetDark(true);
            ShaftRoom.SetDark(true);
            SmellyRoom.SetDark(true);
            GasRoom.SetDark(true);
            CoalMine1.SetDark(true);
            CoalMine2.SetDark(true);
            CoalMine3.SetDark(true);
            CoalMine4.SetDark(true);
            LadderBottom.SetDark(true);
            TimberRoom.SetDark(true);
            DeadEnd5.SetDark(true);
            TimberRoom.SetDark(true);
            DraftyRoom.SetDark(true);
            MachineRoom.SetDark(true);

            Maze1.SetDark(true);
            Maze2.SetDark(true);
            Maze3.SetDark(true);
            Maze4.SetDark(true);
            Maze5.SetDark(true);
            Maze6.SetDark(true);
            Maze7.SetDark(true);
            Maze8.SetDark(true);
            Maze9.SetDark(true);
            Maze10.SetDark(true);
            Maze11.SetDark(true);
            Maze12.SetDark(true);
            Maze13.SetDark(true);
            Maze14.SetDark(true);
            Maze15.SetDark(true);

            DeadEnd.SetDark(true);
            DeadEnd2.SetDark(true);
            DeadEnd3.SetDark(true);
            DeadEnd4.SetDark(true);

            return WestOfHouse;
        }

        public void ShowInventory()
        {
            Inventory.Show();
        }

        public bool GetLampStatus()
        {
            //check all items in inv
            //if lamp return status
            //only 1 type of lamp item so no need to check name
            Lamp currentitem;
            foreach (var item in Inventory.GetItems())
            {
                if (item.GetType() == typeof(Lamp))
                {
                    currentitem = (Lamp)item;
                    return currentitem.GetLit();
                }
            }
            return false;
        }

        public void TurnOn()
        {
            //check all inv items
            //if lamp, turn on
            Lamp currentitem;
            foreach (var item in Inventory.GetItems())
            {
                if (item.GetType() == typeof(Lamp))
                {
                    currentitem = (Lamp)item;
                    currentitem.Light();
                    return;
                }
            }
            Console.WriteLine("You do not have that");
            return;
        }

        public void TurnOff()
        {
            // check all inv items
            //if lamp, turn off
            Lamp currentitem;
            foreach (var item in Inventory.GetItems())
            {
                if (item.GetType() == typeof(Lamp))
                {
                    currentitem = (Lamp)item;
                    currentitem.UnLight();
                    return;
                }
            }
            Console.WriteLine("You do not have that");
            return;
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
                //hard coding exits that are fine
                if (this.room.GetName() == "South Of House")
                {
                    room = destination;
                    return;
                }
                if (this.room.GetName() == "Clearing")
                {
                    room = destination;
                    return;
                }
                if (this.room.GetName() == "North Of House")
                {
                    room = destination;
                    return;
                }
                if (destination.GetName() == "Clearing")
                {
                    room = destination;
                    return;
                }
                //if the destination room is a window room, check status
                else if (destination.GetType() == typeof(WindowRoom))
                {
                    destination2 = (WindowRoom)destination;
                    if (destination2.GetOpen())
                    {
                        room = destination;
                    }
                    else
                    {
                        Console.WriteLine("You can't go that way.");
                    }
                }
                //if the current room is a windowroom check status
                else if (room.GetType() == typeof(WindowRoom))
                {
                    destination2 = (WindowRoom)room;
                    if (destination2.GetOpen())
                    {
                        room = destination;
                    }
                    else
                    {
                        Console.WriteLine("You can't go that way.");
                    }
                }
                else if (room.GetType() == typeof(TrapDoorRoom))
                {
                    //Console.WriteLine(direction);
                    TrapDoorRoom thisroom = (TrapDoorRoom)room;
                    if (thisroom.GetOpen() && direction.ToString() == "Down")
                    {
                        room = destination;
                    }
                    else
                    {
                        Console.WriteLine("You can't go that way.");
                    }
                }
                else
                {
                    room = destination;
                }
            }
            else
            {
                Console.WriteLine("You can't go that way");
            }
        }

        public bool TakeRoomItem(string Object)
        {
            return true;
        }

        public void TakeObject(string Object)
        {
            if (Object == "all")
            {
                TakeAll();
                return;
            }
            Item item1 = null;
            string dialogue = null;
            //check all items in room
            foreach (var item in room.GetItems().ToList())
            {
                if (item.IsSynonym(Object))
                {
                    //if you can take the item
                    if (item.GetTakeable())
                    {
                        //if the item was added to the inventory
                        bool succesful = this.Inventory.Add(item);
                        if (succesful)
                        {
                            //remove from room
                            room.RemoveItem(item.GetName());
                            //set the dialogue
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
                    //if it's a container
                    if (item.GetType() == typeof(Container))
                    {
                        Container container2 = (Container)item;
                        //check opened
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
            
            //if the current room is a window room, open it
            //if any of the exits is a windowroom, open it
            if (Object == "window")
            {
                WindowRoom currentroom;
                if (room.GetType() == typeof(WindowRoom))
                {
                    currentroom = (WindowRoom)this.room;
                    if (currentroom.GetOpen())
                    {
                        Console.WriteLine("That is already open.");
                        return;
                    }
                    else
                    {
                        currentroom.OpenWindow();
                        Console.WriteLine("Opened.");
                        return;
                    }
                    
                }
                else
                {
                    foreach (var room in this.room.GetExits())
                    {
                        if (room.GetType() == typeof(WindowRoom))
                        {
                            currentroom = (WindowRoom)this.room;
                            if (currentroom.GetOpen())
                            {
                                Console.WriteLine("That is already open");
                                return;
                            }
                            else
                            {
                                currentroom.OpenWindow();
                                Console.WriteLine("Opened.");
                                return;
                            }
                        }
                    }
                }
                Console.WriteLine("You don't see that here");
            }

            if (Object == "trapdoor")
            {
                TrapDoorRoom currentroom;
                if (room.GetType() == typeof(TrapDoorRoom))
                {
                    currentroom = (TrapDoorRoom)this.room;
                    if (currentroom.GetOpen())
                    {
                        Console.WriteLine("That is already open.");
                        return;
                    }
                    else
                    {
                        if (currentroom.GetMove())
                        {
                            currentroom.Open();
                            Console.WriteLine("Opened.");
                            return;
                        }
                    }

                }
                else
                {
                    foreach (var room in this.room.GetExits())
                    {
                        if (room.GetType() == typeof(WindowRoom))
                        {
                            currentroom = (TrapDoorRoom)this.room;
                            if (currentroom.GetOpen())
                            {
                                Console.WriteLine("That is already open");
                                return;
                            }
                            else
                            {
                                currentroom.Open();
                                Console.WriteLine("Opened.");
                                return;
                            }
                        }
                    }
                }
                Console.WriteLine("You don't see that here");
            }

            foreach (var item in room.GetItems())
            {
                if (item.GetType() == typeof(Container) && item.IsSynonym(Object))
                {
                    var newitem = (Container)item;
                    newitem.Open();
                    return;
                }
                else if (item.GetType() == typeof(TrophyCase) && item.IsSynonym(Object))
                {
                    var newitem = (TrophyCase)item;
                    newitem.Open();
                    return;
                }
            }
        }

        public void PutObInContainer(string Object, string Container)
        {
            Item currentitem = null;
            Container currentcontainer;
            TrophyCase TrophyCase;
            foreach (var item in Inventory.GetItems().ToList())
            {
                if (item.IsSynonym(Object))
                {
                    currentitem = item;
                }
            }
            if (currentitem == null)
            {
                Console.WriteLine("You don't have that");
                return;
            }
            foreach (var item in room.GetItems())
            {
                if (item.GetType() == typeof(TrophyCase) && item.IsSynonym(Container))
                {
                    TrophyCase = (TrophyCase)item;
                    if (TrophyCase.IsOpen())
                    {
                        bool result = TrophyCase.AddItem(currentitem);
                        if (result)
                        {
                            Inventory.Remove(Object);
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"The {TrophyCase.GetName()} is closed");
                    }
                }
                else if (item.GetType() == typeof(Container) && item.IsSynonym(Container))
                {
                    currentcontainer = (Container)item;
                    if (currentcontainer.GetOpened())
                    {
                        Inventory.Remove(Object);
                        currentcontainer.AddItem(item);
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"The {currentcontainer.GetName()} is closed");
                    }
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
                else if (item.GetType() == typeof(TrophyCase) && item.IsSynonym(Object))
                {
                    var newitem = (TrophyCase)item;
                    newitem.Close();
                }
            }
        }

        public void TakeAll()
        {
            int count = 0;
            foreach (Item value in room.GetItems())
            {
                if (value.GetTakeable())
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
        }

        public void DropObject(string Object)
        {
            Item item = this.Inventory.Remove(Object);
            this.room.AddItem(item);
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
                        if (item.GetDescription() == "")
                        {
                            Console.WriteLine($"I see nothing special about this {item.GetName()}");
                        }
                        else
                        {
                            Console.WriteLine(item.GetDescription());
                        }
                        return;
                    }
                }
                Console.WriteLine("That item is not in this room");
            }
        }
    }
}
