using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class ProgramData
    {
        public static Room CurrentLocation { get; set; }

        public static List<Room> Rooms = new List<Room>();
        public static List<Item> Items = new List<Item>();

        public static void LoadData()
        {
            //CREATE ROOMS
            Rooms.Add(new Room("Bedroom", "This is a simple bedroom with a bed, dresser, and a wardrobe."));            
            Rooms.Add(new Room("Hallway", "You are standing in the hallway outside the bedroom. There is not much here."));
            Rooms.Add(new Room("Library", "A well-stocked personal library with hundreds of volumes to choose from. A window " +
                "lets in the bright sunlight."));
            
            //CREATE JOURNEYS
            Rooms[0].AddExit(new Journey(Rooms[1], "Leave the bedroom", "You open the bedroom door and exit the room, " +
                "shutting the door behind you."));
            Rooms[1].AddExit(new Journey(Rooms[0], "Enter the bedroom", "You open the bedroom door and enter the room, " +
                "closing the door behind you."));
            Rooms[1].AddExit(new Journey(Rooms[2], "Enter the library", "You walk down the hallway, your feet padding softly on " +
                "the thick carpet. You open the heavy door to the library, and cross the threshold."));

            //CREATE INTERACTIONS
            Rooms[0].AddInteraction(new Interaction(1, "There is a strange doll here.", "Pickup the strange doll"));
            Rooms[2].AddInteraction(new Interaction(2, "There is a large chest in one corner of the room. It is mostly full of junk, " +
                "but you might find something useful inside of it.", "Look inside the chest", 1 ,"You don't think you'll find anything else in " +
                "the chest."));

            //CREATE ITEMS
            Items.Add(new Item("Red Potion", "Red Potions", "A sparkling red liquid inside a crystal class flask.", 1));

            //LOAD VARIABLES
            CurrentLocation = Rooms[0];
        }
    }
}
