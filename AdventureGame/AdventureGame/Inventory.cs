using System.Collections.Generic;
using System.Windows.Forms;

namespace AdventureGame
{
    class Inventory
    {
        public static List<Item> items = new List<Item>();

        private static int MaxSize { get; set; } = 5;
        
        public static void Add(Item item)
        {
            if(items.Count < MaxSize)
            {
                items.Add(item);
                MessageBox.Show($"You found a {item.Name}.");
            }
            else
            {
                MessageBox.Show("This Inventory is full");
            }
        }
        public static Item LookAt(int i)
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
        public static void Use(int i)
        {
            items[i].Use();
            items.RemoveAt(i);
        }
        
    }
}
