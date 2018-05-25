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
        public static Equipment PrimaryWeapon { get; set; }
        public static Equipment SecondaryWeapon { get; set; }

        public static List<Equipment> EquipmentList = new List<Equipment>();

        public static void LoadData()
        {
            MaxHealth = 10;
            Health = 10;
            EquipmentList.Add(ProgramData.Weapons[0]);
            PrimaryWeapon = EquipmentList[0];
        }
        public static void PickupEquipment(Equipment e)
        {
            EquipmentList.Add(e);
        }
    }
}
