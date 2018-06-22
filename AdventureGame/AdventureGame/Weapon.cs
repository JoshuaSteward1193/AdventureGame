using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Weapon : Equipment
    {
        public int AttackValue { get; set; }
        public int Stability { get; set; }

        public Weapon(string n, string d, string t, int a, int b)
        {
            Name = n;
            Description = d;
            Type = t;
            AttackValue = a;
            Stability = b;
        }        
    }
}
