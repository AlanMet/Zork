using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable()]
    public class Lamp: Item
    {
        bool lit;

        public Lamp(string name, string description): base(name, description)
        {
            lit = false;
        }

        public void Light()
        {
            lit = true;
            Console.WriteLine($"The {this.GetName()} is now on.");
        }

        public void UnLight()
        {
            lit = false;
            Console.WriteLine($"The {this.GetName()} is now off.");
        }


        public bool GetLit()
        {
            return lit;
        }


    }
}
