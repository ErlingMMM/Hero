using Hero.Attributes;

namespace Hero.Services
{
    public class LevelUpService
    {
        public void LevelUp(HeroAttribute attributes, int strengthIncrease, int dexterityIncrease, int intelligenceIncrease)
        {
            int levelStrength = attributes.Strength + strengthIncrease;
            int levelDexterity = attributes.Dexterity + dexterityIncrease;
            int levelIntelligence = attributes.Intelligence + intelligenceIncrease;

            attributes.Strength = levelStrength;
            attributes.Dexterity = levelDexterity;
            attributes.Intelligence = levelIntelligence;
        }
    }
}
