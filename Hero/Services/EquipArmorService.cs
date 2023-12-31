﻿
using DungeonMaster.Equipment;
using DungeonMaster.Exceptions;


namespace DungeonMaster.Services
{
    public class EquipArmorService
    {
        public static bool Equipping(Armor armor, string validArmorTypes, int level, Dictionary<Slot, Item?> equipment)
        {
          
                if (validArmorTypes.Split(',').Select(type => type.Trim()).Contains(armor.ArmorType.ToString()) && level >= armor.RequiredLevel)
                {
                    Slot armorSlot = armor.ArmorSlot;
                    if (Enum.IsDefined(typeof(Slot), armorSlot))
                    {
                        equipment[armorSlot] = armor;
                     
                    }
                    else
                    {
                        Console.WriteLine("Invalid armor slot.");
                    }
                    Console.WriteLine($"Equipped: {armor.Name}");
                    return true;
                }
                else
                {
                    string errorMessage = "Cannot equip this armor.";

                    if (level < armor.RequiredLevel)
                    {
                        errorMessage += $" Required level: {armor.RequiredLevel}";
                    }
                    else if (!validArmorTypes.Split(',').Select(type => type.Trim()).Contains(armor.ArmorType.ToString()))
                    {
                        errorMessage += $" Invalid armor type: {armor.ArmorType}";
                    }
                Console.WriteLine(errorMessage);  
                throw new InvalidArmorException(errorMessage);
                }
            }
      
        }
    }






