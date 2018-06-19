using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    abstract class Creature
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        int maxHealth;
        public int MaxHealth {
            get
            {
                return maxHealth;
            }
            set
            {
                maxHealth = value;
                Health = maxHealth;
            }
        }
        public int Stamina { get; set; }
        private int maxStamina;
        public int MaxStamina
        {
            get
            {
                return maxStamina;
            }
            set
            {
                maxStamina = value;
                Stamina = maxStamina;
            }
        }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Toughness { get; set; }        
    }
}
