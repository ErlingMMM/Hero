using HeroNamespace.Attributes;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace HeroNamespace.Services
{
    public class DisplayHeroService
    {
        public string DisplayHeroInfo(string name, string heroClass, int level, HeroAttribute attributes, int damage)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Name: {name}");
            output.AppendLine($"Class: {heroClass}");
            output.AppendLine($"Level: {level}");
            output.AppendLine($"Total Strength: {attributes.Strength}");
            output.AppendLine($"Total Dexterity: {attributes.Dexterity}");
            output.AppendLine($"Total Intelligence: {attributes.Intelligence}");
            output.AppendLine($"Damage: {damage}");
            output.AppendLine();

            return output.ToString();
        }
    }
}
