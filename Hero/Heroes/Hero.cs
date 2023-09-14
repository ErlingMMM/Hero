using Dungeon.Attributes;
using Dungeon.Equipment;


namespace Dungeon.hero
{

    public abstract class Hero
    {
        protected string Name;
        protected HeroAttribute LevelAttributes;
        protected string ValidWeaponTypes { get; set; }
        protected string ValidArmorTypes { get; set; }



        public int Level;
        public Dictionary<Slot, Item> Equipment;
        public Slot Slot { get; }


        public abstract HeroAttribute LevelUp();
        public abstract HeroAttribute  TotalAttributes(int StrengthIncrease, int DexterityIncrease, int IntelligenceIncrease);
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
