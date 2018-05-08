using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class PlayerData
    {
        public static string Name { get; set; }
        private static int health;
        public static int Health {
            get
            {
                return health;
            }
            set
            {
                health = value;
                if(health > MaxHealth)
                {
                    health = MaxHealth;
                }
            }
        }
        public static int MaxHealth { get; set; }
    }
}
