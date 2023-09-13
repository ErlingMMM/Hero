using Hero.Attributes;
using Hero.Equipment;
using Hero.Services;

namespace Hero.hero
{
    public class Archer : Hero
    {
        private readonly DisplayHeroService displayHeroService = new DisplayHeroService();
        private readonly DisplayEquipmentService displayEquipmentService = new DisplayEquipmentService();
        private readonly LevelUpService levelUpService = new LevelUpService();
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

        public override void LevelUp()
        {
            Level++;
            levelUpService.LevelUp(LevelAttributes, ArcherStrengthIncrease, ArcherDexterityIncrease, ArcherIntelligenceIncrease);
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
            double damageWeapon = 1;
            if (equippedWeapon != null)
            {
                damageWeapon = equippedWeapon.WeaponDamage;
            }

            double damage = damageWeapon * (1 + (LevelAttributes.Dexterity / 100.0));

            return (int)damage;
        }
    }
}
