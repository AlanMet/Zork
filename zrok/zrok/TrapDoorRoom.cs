using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class TrapDoorRoom: Room
    {
        bool Moved, Opened;

        public TrapDoorRoom(string name, string description): base(name, description)
        {
            Moved = false;
            Opened = false;
        }

        public bool GetMove()
        {
            return Moved;
        }

        public bool GetOpen()
        {
            return Opened;
        }

        public void Move()
        {
            Moved = true;
        }

        public void Open()
        {
            Opened = true;
        }

    }
}
