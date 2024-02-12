using System;
using System.Xml.Linq;

namespace BossFight
{
    internal class GameCharacter
    {
        //Class variables
        private string _name;
        private int _health;
        private int _strength;
        private int _stamina;
        private int _initStamina;

        //Encapsulation (fields)
        public string Name { get { return _name; } set { _name = value; } }
        public int Health { get { return _health; } set { _health = value; } }
        public int Strength { get { return _strength; } set { _strength = value; } }
        public int Stamina { get { return _stamina; } set { _stamina = value; } }
        public int InitStamina { get { return _initStamina; } set { _initStamina = value; } }

        //Random Class Object for randomizing
        readonly Random random = new();

        //Constructor of the Hero with specs
        public GameCharacter(string aName, int aHealth, int aStamina, int aStrength)
        {
            _name = aName;
            _health = aHealth;
            _stamina = aStamina;
            _initStamina = aStamina;
            _strength = aStrength;
        }
        //Constructor of the Boss or any other character with specs without the aStrength argument passed, the Strength value is initially 20, but that value will be randomized
        public GameCharacter(string aName, int aHealth, int aStamina)
        {
            _name = aName;
            _health = aHealth;
            _stamina = aStamina;
            _initStamina = aStamina;
            _strength = 20;
        }

        public void WriteSpecsOfGameCharacter()
        {
            Console.WriteLine($"The {Name} has {Health} health {Strength} strength and {Stamina} stamina points.");
        }

       public int Attack()
        {
            //The bosses strength is fluctuating between 0-30 points/attack
            if (Name == "Boss" || Name == "boss")
            {
                Stamina -= 10;
                Strength = random.Next(0, 31);
                return Strength;
            }
            else
            {
                Stamina -= 10;
                return Strength;
            }
        }

        public void Recharge()
        {
            Stamina = InitStamina;
            Console.WriteLine($"The {Name} recharge itself for the next attack!");
        }
    }
}