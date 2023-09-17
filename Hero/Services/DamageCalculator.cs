using DungeonMaster.Equipment;

public class DamageCalculator
{
    public static int CalculateDamage(Weapon? equippedWeapon, int damagingAttribute)
    {
        double damageWeapon = equippedWeapon?.WeaponDamage ?? 1;
        double damage = damageWeapon * (1 + (damagingAttribute / 100.0));
        return (int)damage;
    }
}
