


namespace Hero.Equipment
{
    public class Weapon : Item
    {

      
        public WeaponType WeaponType { get; }
        public int WeaponDamage { get; }
        public Weapon(string name, int requiredLevel, string slot, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }
}


