using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable]
    public class Container: Item
    {
        private bool Opened = false;

        List<Item> items;

        public Container(string name, string description):base(name, description)
        {
            items = new List<Item>();
        }


        public Container(string name, string description, bool treasure) : base(name, description, treasure)
        {
            items = new List<Item>();
            Opened = false;
        }

        public void Open()
        {
            if (Opened == true)
            {
                Console.WriteLine($"{this.GetName()} is already open.");
            }
            else
            {
                Opened = true;
                Console.WriteLine("Opened.");
            }
        }

        public void Close()
        {
            if (Opened == false)
            {
                Console.WriteLine($"{this.GetName()} is already closed.");
            }
            else
            {
                Opened = false;
                Console.WriteLine("Closed.");
            }
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            foreach (var Item in items)
            {
                if (Item.GetName() == item.GetName())
                {

                }
            }
        }
    }
}
