using Hero.Attributes;
using Hero.Equipment;
using Hero.Services;

namespace Hero.hero
{
    public class Archer : Hero
    {
        private readonly DisplayHeroService displayHeroService = new DisplayHeroService();
        private readonly DisplayEquipmentService displayEquipmentService = new DisplayEquipmentService();
        private readonly AttributeIncreaser increaseAttributes = new AttributeIncreaser();
        private readonly EquipWeaponService equipWeaponService = new EquipWeaponService();
        private readonly EquipArmorService equipArmorService = new EquipArmorService();

        private const int ArcherStrengthIncrease = 1;
        private const int ArcherDexterityIncrease = 5;
        private const int ArcherIntelligenceIncrease = 1;

        private Weapon equippedWeapon;
        private Armor equippedArmor;
       


        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(strength: 1, dexterity: 7, intelligence: 1);
            ValidWeaponTypes = "Bow";
            ValidArmorTypes = " Leather, Mail";
        }

        public override HeroAttribute LevelUp()
        {
            Level++;
            return increaseAttributes.IncreaseAttributes(LevelAttributes, ArcherStrengthIncrease, ArcherDexterityIncrease, ArcherIntelligenceIncrease);
        }


        public override HeroAttribute TotalAttributes(int StrengthIncrease, int DexterityIncrease, int IntelligenceIncrease)
        {
            return increaseAttributes.IncreaseAttributes(LevelAttributes, StrengthIncrease, DexterityIncrease, IntelligenceIncrease);
        }


        public override void Display()
        {
            string heroInfo = displayHeroService.DisplayHeroInfo(Name, "Archer", Level, LevelAttributes);
            Console.WriteLine(heroInfo);
        }


        public override void DisplayEquipment()
        {
            string equipmentInfo = displayEquipmentService.DisplayEquipment(Name, Level, Equipment);
            Console.WriteLine(equipmentInfo);
        }

        public override void EquipWeapon(Weapon weapon)
        {
            bool equipSuccess = equipWeaponService.Equipping(weapon, ValidWeaponTypes, Level, Equipment);

            if (equipSuccess)
            {
                equippedWeapon = weapon;
            }
        }

        public override void EquipArmor(Armor armor)
        {
            bool equipSuccess = equipArmorService.Equipping(armor, ValidArmorTypes, Level, Equipment);

            if (equipSuccess)
            {
                equippedArmor = armor;
            }
        }
        


        public override int Damage()
        {
            return DamageCalculator.CalculateDamage(equippedWeapon, LevelAttributes.Dexterity);

        }
    }
}
