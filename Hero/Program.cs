using Hero.Equipment;
using Hero.hero;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Archer archer = new Archer("Robin Hood");
        Weapon commonBow = new Weapon("Common Bow", 1, "Weapon", WeaponType.Bow, 10);

        archer.EquipWeapon(commonBow);
        archer.LevelUp();
        archer.Display();
        archer.DisplayEquipment();
    }
}
