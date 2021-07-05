using System;

namespace oop_practice
{
    public class Human
    {
        public string Name { get; set; }
        public int Strength; 
        public int Intelligence;
        public int Dexterity;
        private int health;

        //getter to access health
        public int Health
        {
            get{ return health; }
        }

        //constructor
        public Human(string humanName)
        {
            Name = humanName;
            Strength = 3;
            Dexterity = 3;
            Intelligence = 3;
            health = 100;
        }
        //default constructor
        public Human(string humanName, int strength, int dexterity, int intelligence, int h)
        {
            Name = humanName;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            health = h;
        }

        public void Attack(Human target)
        {
            Console.WriteLine($"{this.Name} is attacking {target.Name}");
            int attackPower = 5 * this.Strength;
            target.health -= attackPower;
            Console.WriteLine($"{target.Name}'s health was reduced by {attackPower}. It is now {target.health}");

        }
    }
}