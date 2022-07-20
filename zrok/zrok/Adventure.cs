using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    partial class Adventure
    {

        private Player player;

        public Adventure()
        {
            player = new Player(Setup(""));
            InitVocab();
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

        public Room GetRoom()
        {
            return room;
        }

        //commands
        //move
        //look
        //save
        //restore
        //restart
        //verbose
        //score
        //diagnostic
        //brief
        //superbrief
        //climb
        //g
        //enter
        //

        static Room Move(Direction direction, Room room)
        {
            Room destination;

            if (room.GetExits().TryGetValue(direction, out destination))
            {
                return destination;
            }
            else
            {
                Console.WriteLine("You cannot go that way");
                return null;
            }
        }
    }
}
