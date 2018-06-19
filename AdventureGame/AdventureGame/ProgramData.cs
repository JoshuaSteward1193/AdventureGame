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
        public static List<Weapon> Weapons = new List<Weapon>();

        public static Creature enemyCombatant;

        public static void LoadData()
        {
            //CREATE ROOMS
            Rooms.Add(new Room("Prison Cell", "You are in a small prison cell with four crumbling stone walls. The walls are covered with " +
                "slimy moss, and the floor is strewn with filthy straw. There seems to be no guards near your cell at all."));            
            Rooms.Add(new Room("Ancient Corridor", "You are standing in an ancient stone corridor. Guttering torches cast a dim light " +
                "over the walkway. At the far end of the corridor is another wooden door."));
            Rooms.Add(new Room("Ancient Corridor", "You are standing in an ancient stone corridor. Guttering torches cast a dim light " +
                "over the walkway. At the far end of the corridor is another wooden door. You notice a small door to your left, about halfway " +
                "down the corridor."));
            Rooms.Add(new Room("Forgotten Armory", "You are standing in an old armory full of ancient weapons."));
            Rooms.Add(new Room("Ancient Corridor", "You are standing in an ancient stone corridor. Guttering torches cast a dim light " +
                "over the walkway. There is a large wooden door before you, the exit of this corridor."));
            Rooms.Add(new Room("Old Courtyard", "You are standing in an old, abandoned courtyard."));

            //CREATE JOURNEYS            
            Rooms[1].AddExit(new Journey(Rooms[2], "Head towards the wooden door", "You softly creep down the corridor towards the exit."));
            Rooms[2].AddExit(new Journey(Rooms[3], "Open the small door", "The small door is not locked, and you are able to push it open. The " +
                "rusty hinges shriek as they open. You step inside a small, dark room."));
            Rooms[2].AddExit(new Journey(Rooms[4], "Head towards the wooden door", "You softly creep down the corridor towards the exit."));
            Rooms[4].AddExit(new Journey(Rooms[2], "Go back to the small side door", "You softly creep back to the small side door."));
            Rooms[4].AddExit(new Journey(Rooms[5], "Go through the wooden door", "You press against the wooden door, and it slowly swings open."));
            Rooms[3].AddExit(new Journey(Rooms[2], "Leave the ancient armory", "You step through the small doorway, back into the lighter " +
                "dimness of the corridor."));

            //CREATE INTERACTIONS
            Rooms[0].AddInteraction(new Interaction(1, "The door to the cell is made of old rotten wood. It looks like it is ready to fall apart.",
                "Try to break the door down.", 3, "The door suddenly gives out, and falls to the floor in a heap of rotten wood."));
            Rooms[3].AddInteraction(new Interaction(2, "There is a large chest in one corner of the room. It is mostly full of junk, " +
                "but you might find something useful inside of it.", "Look inside the chest", 2 ,"You don't think you'll find anything else in " +
                "the chest."));
            Rooms[3].AddInteraction(new Interaction(3, "There is an old longsword hanging on the wall.", "Take the old longsword"));

            //CREATE ITEMS
            Items.Add(new Item("Red Potion", "Red Potions", "A sparkling red liquid inside a crystal class flask.", 1));

            //CREATE EQUIPMENT
            //CREATE WEAPONS
            Weapons.Add(new Weapon("Fists", "Your bare hands, and nothing else.", "unarmed", 1, 1));
            Weapons.Add(new Weapon("Rusty Longsword", "An old sword that has clearly seen better days.", "longsword",
                10, 4));
            Weapons.Add(new Weapon("Pheasant Sword", "A find sword that once belonged to a common knight.", "longsword",
                14, 5));

            //LOAD VARIABLES
            CurrentLocation = Rooms[0];
        }
    }
}
