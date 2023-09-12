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
        protected List<Weapon> EquippedWeapons; 
       

        public abstract void LevelUp();
        public abstract void Display();
        public abstract void EquipWeapon(Weapon weapon); 
       

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute();
            EquippedWeapons = new List<Weapon>();
           
        }
    }
}
