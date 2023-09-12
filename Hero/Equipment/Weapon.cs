

using Hero.Attributes;
using System.Xml.Linq;
using static Hero.Equipment.Weapon;

namespace Hero.Equipment
{
    public class Weapon : Item
    {

      
        public WeaponType WeaponType { get; }
        public Weapon(string name, int requiredLevel, string slot, WeaponType weaponType) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            WeaponType = weaponType;
           
        }
    }
}


