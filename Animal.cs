﻿namespace Ovningarna_3._3_3._4
{
    internal abstract class Animal
    {
        protected string namn = string.Empty;
        protected int vikt;
        protected int alder;
        public string Namn { get; set; }
        public int Vikt { get; set; }
        public int Alder { get; set; }

        public Animal(string namn, int vikt, int alder)
        {
            Namn = namn;
            Vikt = vikt;
            Alder = alder;  
        }
        public abstract void DoSound();
    }
}