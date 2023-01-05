using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable()]
    public class TrophyCase: Item
    {
        private bool Opened = false;

        List<Item> items;

        public TrophyCase(string name, string description) : base(name, description)
        {
            items = new List<Item>();
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
                        for (int i = 0; i < items.Count - 1; i++)
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
                    Console.WriteLine("Opened.");
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

        public bool AddItem(Item item)
        {
            if (item.IsTreasure())
            {
                items.Add(item);
                Console.WriteLine("Done.");
                //hard code number of treasures
                if (items.Count == 11)
                {
                    Console.WriteLine("Congratulations, You have completed Zork I! Feel free to keep exploring!");
                }
                return true;
            }
            else
            {
                Console.WriteLine("You can't do that");
                return false;
            }
        }
        public bool IsOpen()
        {
            return Opened;
        }

        public void RemoveItem()
        {
            Console.WriteLine("You can't do that");
        }

        public bool GetOpened()
        {
            return Opened;
        }
    }
}
