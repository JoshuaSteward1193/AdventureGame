using System.Collections.Generic;
using System.Windows.Forms;

namespace AdventureGame
{
    class Inventory
    {
        List<Item> items = new List<Item>();

        private int MaxSize { get; set; }

        public Inventory(int max = 0)
        {
            MaxSize = max;
        }
        public void Add(Item item)
        {
            if(items.Count < MaxSize)
            {
                items.Add(item);
            }
            else
            {
                MessageBox.Show("This Inventory is full");
            }
        }
        public Item LookAt(int i)
        {
            if(i >= 0 && i < items.Count)
            {
                return items[i];
            }
            else
            {
                return null;
            }
        }
        
    }
}
