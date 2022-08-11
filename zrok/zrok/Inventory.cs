using System;
using System.Collections.Generic;
using System.Linq;
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



    }
}
