

using DungeonMaster.Attributes;

namespace DungeonMaster.Equipment
{
    public class Armor : Item
    {

        public ArmorType ArmorType { get; }
        public HeroAttribute ArmorAttribute { get; }
        public Slot ArmorSlot { get; }


        public Armor(string name, int requiredLevel, Slot slot, ArmorType armorType, HeroAttribute armorAttribute) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            ArmorSlot = slot;
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }
    }
}







