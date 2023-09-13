

namespace Hero.Equipment
{
    public class Armor : Item
    {

        public ArmorType ArmorType { get; }
        public int ArmorAttribute { get; }
        public Slot ArmorSlot { get; }


        public Armor(string name, int requiredLevel, string slot, ArmorType armorType, int armorAttribute) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }
    }
}







