using Dungeon.Attributes;
using System.Text;

namespace Dungeon.Services
{
    public class DisplayHeroService
    {
        public string DisplayHeroInfo(string name, string heroClass, int level, HeroAttribute totalAttributes, int damage)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Name: {name}");
            output.AppendLine($"Class: {heroClass}");
            output.AppendLine($"Level: {level}");
            output.AppendLine($"Total Strength: {totalAttributes.Strength}");
            output.AppendLine($"Total Dexterity: {totalAttributes.Dexterity}");
            output.AppendLine($"Total Intelligence: {totalAttributes.Intelligence}");
            output.AppendLine($"Damage: {damage}");
            output.AppendLine();

            return output.ToString();
        }
    }
}
