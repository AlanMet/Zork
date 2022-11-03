using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    internal class Lantern: Item
    {
        private bool Working;
        private bool On;

        public Lantern(string name, string description, bool working): base (name, description)
        {
            Working = working;
        }

        public void Switch(bool state)
        {
            if (Working)
            {
                if (state)
                {
                    TurnOn();
                }
                else
                {
                    TurnOff();
                }
            }
        }

        public void TurnOn()
        {
            if (On)
            {
                Console.WriteLine(this.GetName() + " is already on");
            }
            else
            {
                On = true;
                Console.WriteLine(this.GetName() + " is now on");
            }
        }

        public void TurnOff()
        {
            if (On)
            {
                On = true;
                Console.WriteLine(this.GetName() + " is now on");
            }
            else
            {
                Console.WriteLine(this.GetName() + " is already off");
            }
        }
    }
}
