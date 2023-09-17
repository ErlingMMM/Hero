using System;

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

        //For testing if two instances of the same class are equal. 
        public override bool Equals(object? obj)
        {
            return obj is HeroAttribute other &&
                   Strength == other.Strength &&
                   Dexterity == other.Dexterity &&
                   Intelligence == other.Intelligence;
        }

        // Overrides the default hash code to make sure the Equals method is consistent.
        public override int GetHashCode()
        {
            return HashCode.Combine(Strength, Dexterity, Intelligence);
        }

    }
}
