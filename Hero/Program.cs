using Hero.Equipment;
using Hero.hero;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Archer archer = new Archer("Robin Hood");
        Weapon commonBow = new Weapon("Common Bow", 1, "Weapon", WeaponType.Bow);
       

        archer.Equipment[Slot.Weapon] = commonBow;
        Console.WriteLine(archer.ValidWeaponTypes);

        if (archer.ValidWeaponTypes.Split(',').Contains("Bow"))
        {
            Console.WriteLine("hei");
        }





        archer.LevelUp();

        archer.Display();
        archer.DisplayEquipment();
    }
}
