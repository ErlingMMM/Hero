using Hero.Equipment;
using Hero.hero;
using System;

class Program
{
    static void Main()
    {
        Archer archer = new Archer("Robin Hood");
        Weapon commonBow = new Weapon("Common Bow", 1, "Weapon", WeaponType.Bow);

        archer.Equipment["Weapon"] = commonBow; 

        archer.LevelUp();

        archer.Display();
        archer.DisplayEquipment(); 
    }
}
