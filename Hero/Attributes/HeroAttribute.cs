using DungeonMaster.Attributes;

namespace DungeonMaster.Attributes
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }


        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void Increase(int strengthIncrease, int dexterityIncrease, int intelligenceIncrease)
        {
            Strength += strengthIncrease;
            Dexterity += dexterityIncrease;
            Intelligence += intelligenceIncrease;
        }
    }
}
