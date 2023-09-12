using Hero.Attributes;

namespace Hero.Services
{
    public class DisplayService
    {
        public void DisplayHeroInfo(string name, string heroClass, int level, HeroAttribute attributes)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {heroClass}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Strength: {attributes.Strength}");
            Console.WriteLine($"Dexterity: {attributes.Dexterity}");
            Console.WriteLine($"Intelligence: {attributes.Intelligence}");
            
            
        }
    }
}
