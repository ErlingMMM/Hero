
using DungeonMaster.Equipment;
using DungeonMaster.Exceptions;

namespace DungeonMaster.Services
{
    public class EquipWeaponService
    {
        public static bool Equipping(Weapon weapon, string? validWeaponTypes, int level, Dictionary<Slot, Item?> equipment)
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
                Console.WriteLine(errorMessage);
                throw new InvalidWeaponException(errorMessage);
                
                }
            }
        
        }

    }

