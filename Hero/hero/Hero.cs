using Hero.Attributes;
using Hero.Equipment;


namespace Hero.hero
{

    public abstract class Hero
    {
        protected string Name;
        protected HeroAttribute LevelAttributes;
        protected string ValidWeaponTypes { get; set; }


        public int Level;
        //public string ValidWeaponTypes;
        public Dictionary<Slot, Item> Equipment;
        public Slot Slot { get; }

        public abstract void LevelUp();
        public abstract void Display();
        public abstract void DisplayEquipment();
        public abstract void EquipWeapon(Weapon weapon);

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
