using Hero.Attributes;
using System.Text;

namespace Hero.Services
{
    public class DisplayHeroService
    {
        public string DisplayHeroInfo(string name, string heroClass, int level, HeroAttribute attributes)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Name: {name}");
            output.AppendLine($"Class: {heroClass}");
            output.AppendLine($"Level: {level}");
            output.AppendLine($"Strength: {attributes.Strength}");
            output.AppendLine($"Dexterity: {attributes.Dexterity}");
            output.AppendLine($"Intelligence: {attributes.Intelligence}");
            output.AppendLine();

            return output.ToString();
        }
    }
}
