using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class Item
    {
        private static int IDTracker { get; set; } = 1;

        public int NumInPlayerInv { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        private int Effect { get; set; }
        public bool Usable { get; set; }

        public Item(string name, string pName, string desc, int eff, bool use = true)
        {
            Name = name;
            PluralName = pName;
            Description = desc;
            Effect = eff;
            Usable = use;
            ID = IDTracker;
            IDTracker++;
        }
        public void Use()
        {
            if (NumInPlayerInv <= 0) {
                MessageBox.Show("You don't have any of that item left.");
            } else
            {
                ItemEffects(Effect);
            }
        }
        public void Pickup(int x = 1)
        {
            NumInPlayerInv += x;
            string nameToShow;
            if (x > 1)
            {
                nameToShow = PluralName;
            } else nameToShow = Name;
            MessageBox.Show($"You found {x} {nameToShow}.");
        }
        public void ItemEffects(int x)
        {
            switch (x)
            {
                case 1:
                    PlayerData.Health = PlayerData.MaxHealth;
                    MessageBox.Show("You feel in top condition!");
                    break;
                    
            }
            NumInPlayerInv--;
        }
    }
}
