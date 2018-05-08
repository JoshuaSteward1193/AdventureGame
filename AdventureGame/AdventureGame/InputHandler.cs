using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class InputHandler
    {
        public static void roomAction(int value)
        {
            int countI = ProgramData.CurrentLocation.actions.Count;
            int countE = ProgramData.CurrentLocation.exits.Count;

            if (value > 0 && value <= countI)
            {
                ProgramData.CurrentLocation.DoInteraction(value - 1);
            }
            else if (value > countI && value <= countE + countI)
            {
                ProgramData.CurrentLocation.TakeExit(value - 1 - countI);
            }
            else
            {
                MessageBox.Show("The entered number does not match an applicible command.");
            }
        }        
    }
}
