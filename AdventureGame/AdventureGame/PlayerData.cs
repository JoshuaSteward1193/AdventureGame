using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class PlayerData
    {
        static string name;
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        } 
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

        public static void LoadData()
        {
            MaxHealth = 10;
            Health = 10;
        }
    }
}
