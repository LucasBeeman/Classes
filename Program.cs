using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class myCharacter
    {
        public string name;
        public int health;
        public int mana;
        public int armor;
        public int level;
        public string playerClass;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] myClasses = playerClasses();
            myCharacter mage = new myCharacter();
            mage.name = "Joe";
            mage.health = 100;
            mage.mana = 100;
            mage.armor = 25;
            mage.level = 1;
            mage.playerClass = myClasses[0];
            Console.WriteLine($"Name : {mage.name}\nHealth: {mage.health}\nMana: {mage.mana}\nArmor: {mage.armor}\nLevel: {mage.level}\nClass: {mage.playerClass}");
            Console.WriteLine($"\n\"Do you know {mage.name}?\"\n\"Whoes {mage.name}?\"\n\"{mage.name}mama!\"");
            Console.ReadKey();
        }
        public static string[] playerClasses()
        {
            string[] myClasses = { "mage", "barbarian", "wizard" };
            return myClasses;
        }
    }
}
