using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovningarna_3._3_3._4
{
    internal class Hedgehog : Animal
    {
        int nrOfSpikes;
        public Hedgehog(string namn, int vikt, int alder, int nrOfSpikes = 10000) : base(namn, vikt, alder) => this.nrOfSpikes = nrOfSpikes;
        public override void DoSound()
        {
            Console.WriteLine("Fräs!");
        }
        public int NrOfSpikes() => nrOfSpikes;
    }
}
