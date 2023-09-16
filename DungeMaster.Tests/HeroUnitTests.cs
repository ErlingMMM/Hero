using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.hero;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework.Internal;

namespace DungenMaster.Tests
{
    public class HeroUnitTests
    {
        [Fact]
        public void CreateHero_ShouldHaveCorrectNameLevelAndAttributes()
        {
            string expectedName = "Test Hero";
            int expectedLevel = 1;
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;


            Hero archer = new Archer(expectedName);


            Assert.Equal(expectedName, archer.GetName());
            Assert.Equal(expectedLevel, archer.Level);
            Assert.Equal(expectedStrength, archer.GetLevelAttributes().Strength);
            Assert.Equal(expectedDexterity, archer.GetLevelAttributes().Dexterity);
            Assert.Equal(expectedIntelligence, archer.GetLevelAttributes().Intelligence);

        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedLevelAttributes()
        {
            int expectedLevel = 2;
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;


            Hero archer = new Archer("Test Hero");
            archer.LevelUp();

            Assert.Equal(expectedLevel, archer.Level);
            Assert.Equal(expectedStrength, archer.GetLevelAttributes().Strength);
            Assert.Equal(expectedDexterity, archer.GetLevelAttributes().Dexterity);
            Assert.Equal(expectedIntelligence, archer.GetLevelAttributes().Intelligence);

        }



        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectNameRequiredLevelSlotWeaponTypeAndDamage()
        {
            string expectedName = "Common Bow";
            int expectedRequiredLevel = 1;
            Slot expectedSlot = Slot.Weapon;
            WeaponType expectedWeaponType = WeaponType.Bow;
            int expectedDamage = 10;



            Hero archer = new Archer("Robin Hood");
            Weapon commonBow = new(expectedName, expectedRequiredLevel, expectedSlot, expectedWeaponType, expectedDamage);
            //Item commonBow = new Weapon("Common Bow", 1, Slot.Weapon, WeaponType.Bow, 10);

            archer.EquipWeapon(commonBow);

            Assert.Equal(expectedName, commonBow.Name);
            Assert.Equal(expectedRequiredLevel, commonBow.RequiredLevel);
            Assert.Equal(expectedSlot, commonBow.WeaponSlot);
            Assert.Equal(expectedWeaponType, commonBow.WeaponType);
            Assert.Equal(expectedDamage, commonBow.WeaponDamage);
        }

        //• When Armor is created, it needs to have the correct name, required level, slot, armor type, and armor attributes
        [Fact]
        public void CreatedArmor_ShouldHaveCorrectNameRequiredLevelSlotArmorTypeAndArmorAttributes()
        {
            string expectedName = "Leg Armor";
            int expectedRequiredLevel = 2;
            Slot expectedSlot = Slot.Legs;
            ArmorType expectedArmorType = ArmorType.Leather;
            HeroAttribute expectedAttributes = new(10, 20, 30);



            Hero archer = new Archer("Robin Hood");
            Armor legArmor = new(expectedName, expectedRequiredLevel, expectedSlot, expectedArmorType, expectedAttributes);


            archer.EquipArmor(legArmor);


            Assert.Equal(expectedName, legArmor.Name);
            Assert.Equal(expectedRequiredLevel, legArmor.RequiredLevel);
            Assert.Equal(expectedSlot, legArmor.ArmorSlot);
            Assert.Equal(expectedArmorType, legArmor.ArmorType);
            Assert.Equal(expectedAttributes, legArmor.ArmorAttribute);
        }
    }
}

