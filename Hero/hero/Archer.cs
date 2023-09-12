using Hero.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hero.hero
{
    public class Archer : Hero
    {

        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(strength: 1, dexterity: 7, intelligence: 1);

        }


        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: Archer");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Strength: {LevelAttributes.Strength}");
            Console.WriteLine($"Dexterity: {LevelAttributes.Dexterity}");
            Console.WriteLine($"Intelligence: {LevelAttributes.Intelligence}");
        }
    }
}