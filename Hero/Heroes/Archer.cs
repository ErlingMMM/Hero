using Dungeon.Attributes;
using Dungeon.Equipment;
using Dungeon.Services;

namespace Dungeon.hero
{
    public class Archer : Hero
    {
        private readonly DisplayHeroService displayHeroService = new DisplayHeroService();
        private readonly DisplayEquipmentService displayEquipmentService = new DisplayEquipmentService();
        private readonly EquipWeaponService equipWeaponService = new EquipWeaponService();
        private readonly EquipArmorService equipArmorService = new EquipArmorService();

        private const int StrengthLevelUp = 1;
        private const int DexterityLevelUp = 5;
        private const int IntelligenceLevelUp = 1;

        private Weapon equippedWeapon;
       


        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(strength: 1, dexterity: 7, intelligence: 1);
            ValidWeaponTypes = "Bow";
            ValidArmorTypes = " Leather, Mail";
        }


        public override HeroAttribute LevelUp()
        {
            Level++;
            LevelAttributes.Increase(StrengthLevelUp, DexterityLevelUp, IntelligenceLevelUp);
            return LevelAttributes;
        }

        public override HeroAttribute TotalAttributes(int StrengthIncrease, int DexterityIncrease, int IntelligenceIncrease)
        {
            LevelAttributes.Increase(StrengthIncrease, DexterityIncrease, IntelligenceIncrease);
            return LevelAttributes;
        }

        // Take LevelAttributes -> loop thought equipment, get each armor, get their bonus attribute, add it to levelattribute


        public override void Display()
        {
            int damage = Damage();

            string heroInfo = displayHeroService.DisplayHeroInfo(Name, "Archer", Level, LevelAttributes, damage);
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
             equipArmorService.Equipping(armor, ValidArmorTypes, Level, Equipment);
        }
        


        public override int Damage()
        {
            return DamageCalculator.CalculateDamage(equippedWeapon, LevelAttributes.Dexterity);

        }
    }
}
