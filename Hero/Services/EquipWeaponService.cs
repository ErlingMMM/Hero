using System;
using System.Collections.Generic;
using System.Linq;
using Dungeon.Equipment;

namespace Dungeon.Services
{
    public class EquipWeaponService
    {
        public bool Equipping(Weapon weapon, string? validWeaponTypes, int level, Dictionary<Slot, Item?> equipment)
        {
            try
            {

                if (validWeaponTypes?.Split(',').Select(type => type.Trim()).Contains(weapon.WeaponType.ToString()) == true && level >= weapon.RequiredLevel)
                {
                    equipment[Slot.Weapon] = weapon;
                    Console.WriteLine($"Equipped: {weapon.Name}");
                    return true;
                }
                else
                {
                    string errorMessage = "Cannot equip this weapon.";

                    if (level < weapon.RequiredLevel)
                    {
                        errorMessage += $" Required level: {weapon.RequiredLevel}";
                    }
                    else if (!validWeaponTypes?.Split(',').Select(type => type.Trim()).Contains(weapon.WeaponType.ToString()) == true)
                    {
                        errorMessage += $" Invalid weapon type: {weapon.WeaponType}";
                    }

                    throw new InvalidWeaponException(errorMessage);
                }
            }
            catch (InvalidWeaponException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

    }
}
