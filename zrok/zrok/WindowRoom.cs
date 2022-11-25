using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class WindowRoom: Room
    {
        private bool Open;


        public WindowRoom(string name, string description): base(name, description)
        {
        }

        public void OpenWindow()
        {
            Open = true;
        }

        public void CloseWindow()
        {
            Open = false;
        }

        public bool GetOpen()
        {
            return Open;
        }

        public void AddWindowExit(Direction direction, Room room)
        {
        }
    }
}
