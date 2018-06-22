using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class CreatureGoblin : Creature
    {
        public CreatureGoblin(String name, int level, string t = "")
        {
            Type = "Goblin";
            WeaponType = "unarmed";
            MaxHealth = 5 * level;
            MaxStamina = 4 * level;
            Strength = 2 * level;
            Speed = 3 * level;
            Toughness = 3 * level;
            Level = level;
            Description = "A small green creature, it is strong and quick for its size.";
            Name = name;
            Title = t;
        }
    }
}
