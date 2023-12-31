﻿using DungeonMaster.Attributes;
using DungeonMaster.Equipment;


namespace DungeonMaster.HeroNamespace
{
    public abstract class Hero
    {
        protected string Name;
        protected HeroAttribute LevelAttributes;
        protected string? ValidWeaponTypes { get; set; }
        protected string? ValidArmorTypes { get; set; }


        public int Level;
        public Dictionary<Slot, Item?> Equipment;
        public Slot Slot { get; }
        public string GetName()
        {
            return Name;
        }

        public HeroAttribute GetLevelAttributes()
        {
            return LevelAttributes;
        }

        public abstract HeroAttribute LevelUp();
        public abstract void Display();
        public abstract void DisplayEquipment();
        public abstract int Damage();
        public abstract void EquipWeapon(Weapon weapon);
        public abstract void EquipArmor(Armor armor);

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute(1, 1, 1);
            Equipment = new Dictionary<Slot, Item?>
            {
                { Slot.Weapon, null },
                { Slot.Head, null },
                { Slot.Body, null },
                { Slot.Legs, null }
            };
        }

        public HeroAttribute TotalAttributes()
        {
            int strengthBonus = 0;
            int dexterityBonus = 0;
            int intelligenceBonus = 0;

            foreach (var kvp in Equipment)
            {
                if (kvp.Key != Slot.Weapon && kvp.Value is Armor armor)
                {
                    strengthBonus += armor.ArmorAttribute.Strength;
                    dexterityBonus += armor.ArmorAttribute.Dexterity;
                    intelligenceBonus += armor.ArmorAttribute.Intelligence;
                }
            }

            var total = new HeroAttribute(
                LevelAttributes.Strength + strengthBonus,
                LevelAttributes.Dexterity + dexterityBonus,
                LevelAttributes.Intelligence + intelligenceBonus);

            return total;
        }
    }
}
