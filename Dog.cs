using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningarna_3._3_3._4
{
    internal class Dog: Animal
    {
        bool klappa;
        public Dog(string namn, int vikt, int alder, bool klappa = true) : base(namn, vikt, alder) => this.klappa = klappa;
        public override void DoSound()
        {
            Console.WriteLine("Vov!");
        }
        public bool Klappa() => klappa;
    }
}
