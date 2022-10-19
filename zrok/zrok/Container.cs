using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zrok
{
    public class Container: Item
    {
        private bool Opened;

        List<Item> items;

        public Container(string name, string description):base(name, description)
        {
            items = new List<Item>();
            Opened = false;
        }

        public void Open()
        {
            Opened = true;
        }

        public void Close()
        {
            Opened = false;
        }
    }
}
