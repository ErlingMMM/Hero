using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Services;

namespace DungeonMaster.HeroNamespace
{
    public class Barbarian : Hero
    {

        private const int StrengthLevelUp = 3;
        private const int DexterityLevelUp = 2;
        private const int IntelligenceLevelUp = 1;

        private Weapon? equippedWeapon;

        public Weapon? EquippedWeapon
        {
            get { return equippedWeapon; }
        }

        private Armor? equippedArmor;

        public Armor? EquippedArmor
        {
            get { return equippedArmor; }
        }



        public Barbarian(string name) : base(name)

        {

            LevelAttributes = new HeroAttribute(strength: 5, dexterity: 2, intelligence: 1);
            ValidWeaponTypes = "Hatchet,Mace,Sword";
            ValidArmorTypes = "Mail,Plate";
        }


        public override HeroAttribute LevelUp()
        {
            Level++;
            LevelAttributes.Increase(StrengthLevelUp, DexterityLevelUp, IntelligenceLevelUp);
            return LevelAttributes;
        }





        public override void Display()
        {
            int damage = Damage();
            HeroAttribute totalAttributes = TotalAttributes();

            string heroInfo = DisplayHeroService.DisplayHeroInfo(Name, "Barbarian", Level, totalAttributes, damage);
            Console.WriteLine(heroInfo);
        }



        public override void DisplayEquipment()
        {
            string equipmentInfo = DisplayEquipmentService.DisplayEquipment(Name, Level, Equipment);
            Console.WriteLine(equipmentInfo);
        }

        public override void EquipWeapon(Weapon weapon)
        {
            bool equipSuccess = EquipWeaponService.Equipping(weapon, ValidWeaponTypes, Level, Equipment);

            if (equipSuccess)
            {
                equippedWeapon = weapon;
            }
        }



        public override void EquipArmor(Armor armor)
        {
            string validArmorTypes = ValidArmorTypes ?? string.Empty;
            bool equipSuccess = EquipArmorService.Equipping(armor, validArmorTypes, Level, Equipment);

            if (equipSuccess)
            {
                equippedArmor = armor;
                TotalAttributes();
            }

        }




        public override int Damage()
        {
            HeroAttribute totalAttributes = TotalAttributes();

            return DamageCalculator.CalculateDamage(equippedWeapon, totalAttributes.Strength);


        }

    }
}
