using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class WindowRoom: Room
    {
        bool Open;
        List<Direction> WindowDirections;

        public WindowRoom(string name, string description, Direction direction) : base(name, description)
        {
            this.WindowDirections.Add(direction);
        }

        public void OpenWindow()
        {
            Open = true;
        }

        public void CloseWindow()
        {
            Open = false;
        }

    }
}
