using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ovningarna_3._3_3._4
{
    internal class Horse : Animal
    {
        bool rida;
        public Horse(string namn, int vikt, int alder, bool rida = true) : base(namn, vikt, alder) => this.rida = rida;
        public  override void DoSound() 
        {
            Console.WriteLine("Gnägg!");
        }
        public bool Rida() => rida;
    }
}
