using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.hero;


class Program
{
    static void Main()
    {
        

        Hero archer = new Archer("Robin Hood");
        Weapon commonBow = new("Common Bow", 1, Slot.Weapon, WeaponType.Bow, 10);
        //Item commonBow = new Weapon("Common Bow", 1, Slot.Weapon, WeaponType.Bow, 10);
      



        archer.EquipWeapon(commonBow);
       
       

        archer.LevelUp();
        int damage = archer.Damage();
        Console.WriteLine($"Archer's damage: {damage}");
        archer.Display();
        archer.DisplayEquipment();

        Console.WriteLine("-------------------------------------------------------");



        //  README ADD!!!!!






        Armor headArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(10, 20, 30));
        Armor headArmor2 = new("Head Armor2", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(10, 20, 30));
        Armor clothArmor = new("Head Armor", 1, Slot.Head, ArmorType.Cloth, new HeroAttribute(10, 20, 30));
        Armor legArmor = new("Leg Armor", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));


        archer.EquipArmor(headArmor);
        archer.EquipArmor(headArmor2);
        archer.EquipArmor(clothArmor);
        archer.EquipArmor(legArmor);

       

        archer.Display(); 
        archer.DisplayEquipment();
    }
}
