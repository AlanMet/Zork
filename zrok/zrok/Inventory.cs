using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    class Inventory
    {
        int maxitems = 8;
        List<Item> items;

        public void Add(Item item)
        {
            if (items.Count >= maxitems)
            {
                Random random = new Random();
                if (random.Next(0,100)>=80)
                {
                    items.Add(item);
                }
            }
            else
            {
                items.Add(item);
            }
        }

        public Item Remove(string name)
        {
            foreach (Item item in items)
            {
                if (item.GetName() == name)
                {
                    return item;
                }
            }
            Console.WriteLine("You don't have that item on you");
            return null;
        }

        public bool find(string name)
        {
            foreach (var item in items)
            {
                if (item.GetName() == name)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetSize()
        {
            return items.Count;
        }


    }
}
