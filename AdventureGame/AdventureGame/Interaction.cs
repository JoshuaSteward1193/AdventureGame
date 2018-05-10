using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class Interaction
    {
        private static int IDTracker { get; set; } = 1;

        public int ID { get; set; }
        int EffectNum { get; set; }
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                if(amount <= 0)
                {
                    ProgramData.CurrentLocation.RemoveInteraction(ID);
                }
            }
        }
        public string Description { get; set; }
        public string Command { get; set; }
        public string DepletionText { get; set; }

        public Interaction(int effect, string desc, string comm, int amt = 1, string deplete = "")
        {
            EffectNum = effect;
            Amount = amt;
            Description = desc;
            Command = comm;
            DepletionText = deplete;
            ID = IDTracker;
            IDTracker++;
        }
        public void enact()
        {
            ActionTable(EffectNum);
        }
        private void ActionTable(int x)
        {
            Random rand = new Random();
            switch (x)
            {
                case 1:
                    MessageBox.Show("You pick up the strange doll. It is small, and smells of smoke. Its black glass " +
                        "eyes stare soullessly back at you.");
                    Amount--;
                    break;
                case 2:
                    int i = rand.Next(0, 10);
                    if(i < 7)
                    {
                        MessageBox.Show("You search but find nothing.");
                    } else
                    {
                        ProgramData.Items[0].Pickup();
                        Amount--;
                    }
                    break;
            }
            if(Amount == 0 && DepletionText != "")
            {
                MessageBox.Show(DepletionText);
            }
        }

    }
}
