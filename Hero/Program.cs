using Dungeon.Equipment;
using Dungeon.hero;


class Program
{
    static void Main()
    {
        

        Archer archer = new Archer("Robin Hood");
        Weapon commonBow = new Weapon("Common Bow", 1, "Weapon", WeaponType.Bow, 10);
      



        archer.EquipWeapon(commonBow);
       
       

        archer.LevelUp();
        int damage = archer.Damage();
        Console.WriteLine($"Archer's damage: {damage}");
        archer.Display();
        archer.DisplayEquipment();

        Console.WriteLine("-------------------------------------------------------");



        //  README ADD!!!!!






       var headIncrease = archer.TotalAttributes(2, 3, 4);
        var bodyIncrease = archer.TotalAttributes(1, 2, 3);
        var legIncrease = archer.TotalAttributes(1, 1, 1);
        //Armor headArmor = new Armor("Head Armor", 1, Slot.Head.ToString(), ArmorType.Mail, new HeroNamespace.Attributes.HeroAttribute(10,20,30));
        Armor headArmor = new Armor("Head Armor", 1, Slot.Head.ToString(), ArmorType.Mail, headIncrease);
        Armor bodyArmor = new Armor("Body Armor", 1, Slot.Body.ToString(), ArmorType.Plate, bodyIncrease);
        Armor legArmor = new Armor("Leg Armor", 1, Slot.Legs.ToString(), ArmorType.Leather, legIncrease);

        archer.EquipArmor(headArmor);
        archer.EquipArmor(bodyArmor);
        archer.EquipArmor(legArmor);
        //for loop 
        //var total = archer.TotalAttributes();

        archer.Display(); 
        archer.DisplayEquipment();
    }
}
