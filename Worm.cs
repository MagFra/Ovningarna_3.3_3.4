using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningarna_3._3_3._4
{
    internal class Worm: Animal
    {
        bool isPoisonous;
        public Worm(string namn, int vikt, int alder, bool isPoisonous = false) : base(namn, vikt, alder) => this.isPoisonous = isPoisonous;
        public override void DoSound()
        {
            Console.WriteLine("Väs!");
        }
        public bool IsPoisonous() => isPoisonous;
    }
}