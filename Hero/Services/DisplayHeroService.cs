﻿using DungeonMaster.Attributes;
using System.Text;

namespace DungeonMaster.Services
{
    public class DisplayHeroService
    {
        public static string DisplayHeroInfo(string name, string heroClass, int level, HeroAttribute totalAttributes, int damage)
        {
            StringBuilder output = new();

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
