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
        public Horse(string namn, int vikt, int alder) : base(namn, vikt, alder) { }
        public  override void DoSound() 
        {
            Console.WriteLine("Gnägg!");
        }
    }
}
