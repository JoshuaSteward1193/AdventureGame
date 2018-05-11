using System.Windows.Forms;

namespace AdventureGame
{
    class Item
    {
        private static int IDTracker { get; set; } = 1;

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
            ItemEffects(Effect);            
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
        }
    }
}
