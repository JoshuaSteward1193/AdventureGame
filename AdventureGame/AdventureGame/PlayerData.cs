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
        private static int stamina;
        public static int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
                if(Stamina > MaxStamina)
                {
                    stamina = MaxStamina;
                }
            }
        }
        public static int MaxStamina { get; set; }

        public static int Strength { get; set; }
        public static int Speed { get; set; }
        public static int Toughness { get; set; }

        public static Equipment PrimaryWeapon { get; set; }
        public static Equipment SecondaryWeapon { get; set; }

        public static List<Equipment> EquipmentList = new List<Equipment>();

        public static void LoadData()
        {
            MaxHealth = 10;
            Health = 10;
            MaxStamina = 10;
            Stamina = 10;
            Strength = 5;
            Speed = 5;
            Toughness = 5;
            EquipmentList.Add(ProgramData.Weapons[0]);
            PrimaryWeapon = EquipmentList[0];
        }
        public static void PickupEquipment(Equipment e)
        {
            EquipmentList.Add(e);
        }
    }
}
