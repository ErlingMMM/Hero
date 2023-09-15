using Dungeon.Attributes;
using Dungeon.Equipment;
using Dungeon.hero;


class Program
{
    static void Main()
    {
        

        Archer archer = new Archer("Robin Hood");
        Weapon commonBow = new Weapon("Common Bow", 1, Slot.Weapon, WeaponType.Bow, 10);
      



        archer.EquipWeapon(commonBow);
       
       

        archer.LevelUp();
        int damage = archer.Damage();
        Console.WriteLine($"Archer's damage: {damage}");
        archer.Display();
        archer.DisplayEquipment();

        Console.WriteLine("-------------------------------------------------------");



        //  README ADD!!!!!






        Armor headArmor = new Armor("Head Armor", 1, Slot.Head, ArmorType.Mail, new Dungeon.Attributes.HeroAttribute(10, 20, 30));
        Armor headArmor2 = new Armor("Head Armor2", 1, Slot.Head, ArmorType.Mail, new Dungeon.Attributes.HeroAttribute(10, 20, 30));
        Armor clothArmor = new Armor("Head Armor", 1, Slot.Head, ArmorType.Cloth, new Dungeon.Attributes.HeroAttribute(10, 20, 30));
        Armor legArmor = new Armor("Leg Armor", 1, Slot.Legs, ArmorType.Leather, new Dungeon.Attributes.HeroAttribute(10, 20, 30));


        archer.EquipArmor(headArmor);
        archer.EquipArmor(headArmor2);
        archer.EquipArmor(clothArmor);
        archer.EquipArmor(legArmor);

       

        archer.Display(); 
        archer.DisplayEquipment();
    }
}
