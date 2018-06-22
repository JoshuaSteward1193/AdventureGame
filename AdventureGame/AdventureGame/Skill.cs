using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Skill
    {
        public string Name { get; set; }
        public string PlayerUseDesc { get; set; }
        public string EnemyUseDesc { get; set; }
        public string Type { get; set; }
        public int UseID { get; set; }
        public double Multiplier { get; set; }
        public double HitChance { get; set; }
        
        public Skill(string name, string playerD, string enemyD, string type, int id, double hit, double multi = 1.0)
        {
            Name = name;
            PlayerUseDesc = playerD;
            EnemyUseDesc = enemyD;
            Type = type;
            UseID = id;
            HitChance = hit;
            Multiplier = multi;
        }
    }


}
