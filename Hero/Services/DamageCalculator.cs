using DungeonMaster.Equipment;

public class DamageCalculator
{
    public static int CalculateDamage(Weapon? equippedWeapon, int choosenLevelAttribute)
    {
        double damageWeapon = equippedWeapon?.WeaponDamage ?? 1;
        double damage = damageWeapon * (1 + (choosenLevelAttribute / 100.0));
        return (int)damage;
    }
}
