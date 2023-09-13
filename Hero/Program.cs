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
        Armor headArmor = new Armor("Head Armor", 1, Slot.Head.ToString(), ArmorType.Mail, 10);
        Armor bodyArmor = new Armor("Body Armor", 1, Slot.Body.ToString(), ArmorType.Plate, 20);
        Armor legArmor = new Armor("Leg Armor", 1, Slot.Legs.ToString(), ArmorType.Leather, 15);



        archer.EquipWeapon(commonBow);
        archer.EquipArmor(headArmor);
        archer.EquipArmor(bodyArmor);
        archer.EquipArmor(legArmor);
       

        archer.LevelUp();
        int damage = archer.Damage();
        Console.WriteLine($"Archer's damage: {damage}");
        archer.Display();
        archer.DisplayEquipment();
    }
}
