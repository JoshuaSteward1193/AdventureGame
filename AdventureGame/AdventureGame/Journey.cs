using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class Journey
    {
        public int ID { get; set; }
        public Room destination;
        public String Description { get; set; } //The message the user sees before enacting the journey
        public String Action { get; set; }      //The message the user sees during the journey

        public Journey(Room r, string d, string a)
        {
            destination = r;
            Description = d;
            Action = a;
        }

        public void enact()
        {
            MessageBox.Show(Action);
            ProgramData.CurrentLocation = destination;
        }
    }
}
