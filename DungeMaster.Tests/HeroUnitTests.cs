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
        public void CreateHero_ShouldHaveCorrectName()
        {
            string expectedName = "Test Hero";
            Hero archer = new Archer(expectedName);
            Assert.Equal(expectedName, archer.GetName());
        }

        [Fact]
        public void CreateHero_ShouldHaveCorrectLevel()
        {
            int expectedLevel = 1;
            Hero archer = new Archer("Test Hero");
            Assert.Equal(expectedLevel, archer.Level);
        }

        [Fact]
        public void CreateHero_ShouldHaveCorrectStrength()
        {
            int expectedStrength = 1;
            Hero archer = new Archer("Test Hero");
            Assert.Equal(expectedStrength, archer.GetLevelAttributes().Strength);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedLevelAttributes()
        {
            int expectedLevel = 2;
            Hero archer = new Archer("Test Hero");
            archer.LevelUp();
            Assert.Equal(expectedLevel, archer.Level);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedStrength()
        {
            int expectedStrength = 2;
            Hero archer = new Archer("Test Hero");
            archer.LevelUp();
            Assert.Equal(expectedStrength, archer.GetLevelAttributes().Strength);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedDexterity()
        {
            int expectedDexterity = 12;
            Hero archer = new Archer("Test Hero");
            archer.LevelUp();
            Assert.Equal(expectedDexterity, archer.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedIntelligence()
        {
            int expectedIntelligence = 2;
            Hero archer = new Archer("Test Hero");
            archer.LevelUp();
            Assert.Equal(expectedIntelligence, archer.GetLevelAttributes().Intelligence);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectName()
        {
            string expectedName = "Common Bow";
            Hero archer = new Archer("Robin Hood");
            Weapon commonBow = new(expectedName, 1, Slot.Weapon, WeaponType.Bow, 10);
            archer.EquipWeapon(commonBow);
            Assert.Equal(expectedName, commonBow.Name);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectRequiredLevel()
        {
            int expectedRequiredLevel = 1;
            Hero archer = new Archer("Robin Hood");
            Weapon commonBow = new("Common Bow", expectedRequiredLevel, Slot.Weapon, WeaponType.Bow, 10);
            archer.EquipWeapon(commonBow);
            Assert.Equal(expectedRequiredLevel, commonBow.RequiredLevel);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectSlot()
        {
            Slot expectedSlot = Slot.Weapon;
            Hero archer = new Archer("Robin Hood");
            Weapon commonBow = new("Common Bow", 1, expectedSlot, WeaponType.Bow, 10);
            archer.EquipWeapon(commonBow);
            Assert.Equal(expectedSlot, commonBow.WeaponSlot);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectWeaponType()
        {
            WeaponType expectedWeaponType = WeaponType.Bow;
            Hero archer = new Archer("Robin Hood");
            Weapon commonBow = new("Common Bow", 1, Slot.Weapon, expectedWeaponType, 10);
            archer.EquipWeapon(commonBow);
            Assert.Equal(expectedWeaponType, commonBow.WeaponType);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectDamage()
        {
            int expectedDamage = 10;
            Hero archer = new Archer("Robin Hood");
            Weapon commonBow = new("Common Bow", 1, Slot.Weapon, WeaponType.Bow, expectedDamage);
            archer.EquipWeapon(commonBow);
            Assert.Equal(expectedDamage, commonBow.WeaponDamage);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectName()
        {
            string expectedName = "Leg Armor";
            Hero archer = new Archer("Robin Hood");
            Armor legArmor = new(expectedName, 2, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            archer.EquipArmor(legArmor);
            Assert.Equal(expectedName, legArmor.Name);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectRequiredLevel()
        {
            int expectedRequiredLevel = 2;
            Hero archer = new Archer("Robin Hood");
            Armor legArmor = new("Leg Armor", expectedRequiredLevel, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            archer.EquipArmor(legArmor);
            Assert.Equal(expectedRequiredLevel, legArmor.RequiredLevel);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectSlot()
        {
            Slot expectedSlot = Slot.Legs;
            Hero archer = new Archer("Robin Hood");
            Armor legArmor = new("Leg Armor", 2, expectedSlot, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            archer.EquipArmor(legArmor);
            Assert.Equal(expectedSlot, legArmor.ArmorSlot);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectArmorType()
        {
            ArmorType expectedArmorType = ArmorType.Leather;
            Hero archer = new Archer("Robin Hood");
            Armor legArmor = new("Leg Armor", 2, Slot.Legs, expectedArmorType, new HeroAttribute(10, 20, 30));
            archer.EquipArmor(legArmor);
            Assert.Equal(expectedArmorType, legArmor.ArmorType);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectArmorAttributes()
        {
            HeroAttribute expectedAttributes = new(10, 20, 30);
            Hero archer = new Archer("Robin Hood");
            Armor legArmor = new("Leg Armor", 2, Slot.Legs, ArmorType.Leather, expectedAttributes);
            archer.EquipArmor(legArmor);
            Assert.Equal(expectedAttributes, legArmor.ArmorAttribute);
        }
    }


}

