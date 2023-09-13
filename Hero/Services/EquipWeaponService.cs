using Hero.Equipment;


namespace Hero.Services
{
    public class EquipWeaponService
    {
        public bool Equipping(Weapon weapon, string validWeaponTypes, int level, Dictionary<Slot, Item> equipment)
        {
            if (validWeaponTypes.Split(',').Select(type => type.Trim()).Contains(weapon.WeaponType.ToString()) && level >= weapon.RequiredLevel)
            {
                equipment[Slot.Weapon] = weapon;
                Console.WriteLine($"Equipped: {weapon.Name}");
                return true; 
            }
            else
            {
                Console.WriteLine("Cannot equip this weapon.");
                return false; 
            }
        }
    }
}
