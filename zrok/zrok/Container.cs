using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        //string name, string description, bool takeable,  string negative
        public Container(string name, string description, bool takeable, string negative) : base(name, description, takeable, negative)
        {
            items = new List<Item>();
            Opened = false;
        }

        public List<Item> GetItems()
        {
            return items;
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
                if (items.Count > 0)
                {
                    Console.Write($"You open the {this.GetName()} revealing");
                    if (items.Count > 1)
                    {
                        for (int i = 0; i < items.Count-1; i++)
                        {
                            Console.Write(", ");
                            Console.Write(items[i]);
                        }
                    }
                    else
                    {
                        Console.Write(", ");
                        Console.Write(items[0].GetName());
                    }
                    

                }
                else
                {
                    Console.WriteLine($"{this.GetName()} is empty");
                }
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

        public Item RemoveItem(string Object)
        {
            Item item;
            foreach (var x in items)
            {
                if (Object == x.GetName())
                {
                    item = x;
                    foreach (var Item in items)
                    {
                        if (Item.GetName() == item.GetName())
                        {
                            return item;
                        }
                    }
                    Console.WriteLine("that item doesn't exist");
                    return null;
                }
            }
            return null;
        }

        public bool GetOpened()
        {
            return Opened;
        }
    }
}
