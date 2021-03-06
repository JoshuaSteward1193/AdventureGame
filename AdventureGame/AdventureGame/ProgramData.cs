﻿using System;
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
        public static List<Skill> Skills = new List<Skill>();

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
            Rooms[5].AddInteraction(new Interaction(4, "There is a single goblin standing guard in the courtyard.", "Approach the goblin"));

            //CREATE SKILLS
            Skills.Add(new Skill("Weak Punch", "You aim a weak punch at the enemy", " aims a weak punch at you.", "unarmed", 1, 0.9));
            Skills.Add(new Skill("Solid Punch", "You make a solid strike at the enemy", " waits a moment, and then lunges forward and lashes out with " +
                "a solid punch.", "unarmed", 1, 0.8, 1.3));
            Skills.Add(new Skill("Sacrificial Strike", "You gather your final reserves of energy, and lunge at the enemy", " gathers its strength " +
                "and strikes at you with all of its might.", "unarmed", 1, 0.5, 2.0));
            Skills.Add(new Skill("Slice", "You swing at the enemy with your weapon", " swings at you with its sword.", "longsword", 1, 0.87));
            Skills.Add(new Skill("Hack", "You raise your weapon high and hack at the enemy", " raises its sword high and brings it down towards you",
                "longsword", 1, 0.80, 1.15));
            Skills.Add(new Skill("Overwhelm", "You roar in the face of your foe, and charge towards them as you pound at them with blow after blow.",
                " roars in defiance, and charges at you swinging its sword wildly.", "longsword", 1, 0.99, 3));

            //CREATE ITEMS
            Items.Add(new Item("Red Potion", "Red Potions", "A sparkling red liquid inside a clear crystal flask.", 1));

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
