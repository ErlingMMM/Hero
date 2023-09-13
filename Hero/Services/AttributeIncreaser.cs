using Hero.Attributes;

namespace Hero.Services
{
    public class AttributeIncreaser
    {
        public HeroAttribute IncreaseAttributes(HeroAttribute attributes, int strengthIncrease, int dexterityIncrease, int intelligenceIncrease)
        {
            attributes.Strength += strengthIncrease;
            attributes.Dexterity += dexterityIncrease;
            attributes.Intelligence += intelligenceIncrease;

            return attributes; 
        }
    }

}
