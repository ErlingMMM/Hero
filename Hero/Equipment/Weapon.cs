


namespace Dungeon.Equipment
{
    public class Weapon : Item
    {

      
        public WeaponType WeaponType { get; }
        public int WeaponDamage { get; }
        public Slot WeaponSlot { get; }

        public Weapon(string name, int requiredLevel, Slot slot, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            WeaponSlot = slot;
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
        }
    }
}


