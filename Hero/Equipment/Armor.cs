

namespace Hero.Equipment
{
    public class Armor : Item
    {

        public ArmorType ArmorType { get; }
        public Armor(string name, int requiredLevel, string slot, ArmorType armorType) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            ArmorType = armorType;

        }
    }
}







