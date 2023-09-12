using Hero.Attributes;
using Hero.Equipment;
using System;
using System.Collections.Generic;

namespace Hero.hero
{

    public abstract class Hero
    {
        protected string Name;
        protected int Level;
        protected HeroAttribute LevelAttributes;
        public Dictionary<Slot, Item> Equipment;
        public Slot Slot { get; }

        public abstract void LevelUp();
        public abstract void Display();

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute();
            Equipment = new Dictionary<Slot, Item>
            {
                { Slot.Weapon, null },
                { Slot.Head, null },
                { Slot.Body, null },
                { Slot.Legs, null }
            };
        }
    }
}
