using Hero.Attributes;
using Hero.Equipment;
using Hero.Services;

namespace Hero.hero
{
    public class Archer : Hero
    {
        private readonly DisplayService displayService = new DisplayService();
        private readonly DisplayEquipmentService displayEquipmentService = new DisplayEquipmentService();
        private readonly LevelUpService levelUpService = new LevelUpService();
        private readonly EquipWeaponService equipService = new EquipWeaponService();

        private const int ArcherStrengthIncrease = 1;
        private const int ArcherDexterityIncrease = 5;
        private const int ArcherIntelligenceIncrease = 1;

        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(strength: 1, dexterity: 7, intelligence: 1);
            ValidWeaponTypes = "Bow";
        }

        public override void LevelUp()
        {
            Level++;
            levelUpService.LevelUp(LevelAttributes, ArcherStrengthIncrease, ArcherDexterityIncrease, ArcherIntelligenceIncrease);
        }

        public override void Display()
        {
            displayService.DisplayHeroInfo(Name, "Archer", Level, LevelAttributes);
        }

        public override void DisplayEquipment()
        {
            string equipmentInfo = displayEquipmentService.DisplayEquipment(Name, Level, Equipment);
            Console.WriteLine(equipmentInfo);
        }

        public override void EquipWeapon(Weapon weapon)
        {
            bool equipSuccess = equipService.Equipping(weapon, ValidWeaponTypes, Level, Equipment);
        }

        public override void Damage()
        {

        }
    }
}
