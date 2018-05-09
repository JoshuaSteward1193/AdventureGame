using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Room
    {
        public List<Journey> exits = new List<Journey>();
        public List<Interaction> actions = new List<Interaction>();
        string Description { get; set; }
        string Name { get; set; }

        int CommandAmt { get; set; }

        public Room(string n, string d)
        {
            Name = n;
            Description = d;
        }

        public string display()
        {
            StringBuilder output = new StringBuilder();
            //Prints relevant information to the console            
            CommandAmt = 0;
            output.Append(Description);
            
            //Add the description of each interaction
            foreach (Interaction x in actions)
            {
                if(x.Amount > 0)
                {
                    output.Append($"\n{x.Description}");
                }                
            }
            Console.WriteLine("");

            //Make a space
            output.Append("\n");

            //Add the command from each interaction to the list of commands
            foreach (Interaction x in actions)
            {
                if(x.Amount > 0)
                {
                    CommandAmt++;
                    output.Append($"\n{CommandAmt}. {x.Command}");                    
                }                
            }
            
            //Add the description of each journey
            foreach (Journey x in exits)
            {
                CommandAmt++;
                output.Append($"\n{CommandAmt}. {x.Description}");                
            }
            return output.ToString();
        }
        public void TakeExit(int value)
        {
            //Enacts the actions of the indicated journey
            //Input validation is done in the InputHandler.roomAction() method
            exits[value].enact();
        }
        public void AddExit(Journey x)
        {
            exits.Add(x);
        }
        public void AddInteraction(Interaction x)
        {
            actions.Add(x);
        }
        public void RemoveInteraction(int id)
        {
            actions.Remove(actions.SingleOrDefault(x => x.ID == id));
        }
        public void DoInteraction(int value)
        {
            //Enacts the actions of the indicated interactable
            //The input handler decides if input is asking for a journey or an interactable
            actions[value].enact();
        }
        public int GetCommandAmount()
        {
            return CommandAmt;
        }
    }
}
