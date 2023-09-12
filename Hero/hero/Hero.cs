using Hero.Attributes;
using Hero.Equipment;
using System.Collections.Generic;

namespace Hero.hero
{
    public abstract class Hero
    {
        protected string Name;
        protected int Level;
        protected HeroAttribute LevelAttributes;
        public Dictionary<string, Item> Equipment;


        public abstract void LevelUp();
        public abstract void Display();
       

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute();
            Equipment = new Dictionary<string, Item>
            {
                { "Weapon", null }, 
                { "Head", null },
                { "Body", null },
                { "Legs", null }
            };

        }


    }
}
