using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Services;

namespace DungeonMaster.hero
{
    public class Archer : Hero
    {
        private readonly DisplayHeroService displayHeroService = new();
        private readonly DisplayEquipmentService displayEquipmentService = new();
       



        private const int StrengthLevelUp = 1;
        private const int DexterityLevelUp = 5;
        private const int IntelligenceLevelUp = 1;

        private Weapon? equippedWeapon;

        public Weapon? EquippedWeapon
        {
            get { return equippedWeapon; }
        }




        public Archer(string name) : base(name)

        {
           
            LevelAttributes = new HeroAttribute(strength: 1, dexterity: 7, intelligence: 1);
            ValidWeaponTypes = "Bow";
            ValidArmorTypes = " Leather,Mail";
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

            string heroInfo = DisplayHeroService.DisplayHeroInfo(Name, "Archer", Level, totalAttributes, damage);
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
            EquipArmorService.Equipping(armor, validArmorTypes, Level, Equipment);
            TotalAttributes();
        }





        public override int Damage()
        {
            return DamageCalculator.CalculateDamage(equippedWeapon, LevelAttributes.Dexterity);


        }

    }
}
