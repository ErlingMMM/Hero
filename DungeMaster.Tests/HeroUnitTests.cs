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
            string expectedName = "Legolas";
            Hero legolas = new Archer(expectedName);
            Assert.Equal(expectedName, legolas.GetName());
        }

        [Fact]
        public void CreateHero_ShouldHaveCorrectLevel()
        {
            int expectedLevel = 1;
            Hero legolas = new Archer("Legolas");
            Assert.Equal(expectedLevel, legolas.Level);
        }

        [Fact]
        public void CreateHero_ShouldHaveCorrectStrength()
        {
            int expectedStrength = 1;
            Hero legolas = new Archer("Legolas");
            Assert.Equal(expectedStrength, legolas.GetLevelAttributes().Strength);
        }

        [Fact]
        public void LegolasIncreaseLevel_ShouldHaveCorrectIncreasedLevelAttributes()
        {
            int expectedLevel = 2;
            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedLevel, legolas.Level);
        }

        [Fact]
        public void LegolasIncreaseLevel_ShouldHaveCorrectIncreasedStrength()
        {
            int expectedStrength = 2;
            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedStrength, legolas.GetLevelAttributes().Strength);
        }

        [Fact]
        public void LegolasIncreaseLevel_ShouldHaveCorrectIncreasedDexterity()
        {
            int expectedDexterity = 12;
            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDexterity, legolas.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void LegolasIncreaseLevel_ShouldHaveCorrectIncreasedIntelligence()
        {
            int expectedIntelligence = 2;
            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedIntelligence, legolas.GetLevelAttributes().Intelligence);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectName()
        {
            string expectedName = "Oak Reflex Bow";
            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new(expectedName, 1, Slot.Weapon, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedName, oakReflexBow.Name);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectRequiredLevel()
        {
            int expectedRequiredLevel = 1;
            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", expectedRequiredLevel, Slot.Weapon, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedRequiredLevel, oakReflexBow.RequiredLevel);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectSlot()
        {
            Slot expectedSlot = Slot.Weapon;
            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, expectedSlot, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedSlot, oakReflexBow.WeaponSlot);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectWeaponType()
        {
            WeaponType expectedWeaponType = WeaponType.Bow;
            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, expectedWeaponType, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedWeaponType, oakReflexBow.WeaponType);
        }

        [Fact]
        public void CreatedWeapon_ShouldHaveCorrectDamage()
        {
            int expectedDamage = 10;
            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, expectedDamage);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedDamage, oakReflexBow.WeaponDamage);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectName()
        {
            string expectedName = "Leg Armor";
            Hero legolas = new Archer("Legolas");
            Armor legArmor = new(expectedName, 2, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedName, legArmor.Name);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectRequiredLevel()
        {
            int expectedRequiredLevel = 2;
            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", expectedRequiredLevel, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedRequiredLevel, legArmor.RequiredLevel);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectSlot()
        {
            Slot expectedSlot = Slot.Legs;
            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", 2, expectedSlot, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedSlot, legArmor.ArmorSlot);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectArmorType()
        {
            ArmorType expectedArmorType = ArmorType.Leather;
            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", 2, Slot.Legs, expectedArmorType, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedArmorType, legArmor.ArmorType);
        }

        [Fact]
        public void CreatedArmor_ShouldHaveCorrectArmorAttributes()
        {
            HeroAttribute expectedAttributes = new(10, 20, 30);
            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", 2, Slot.Legs, ArmorType.Leather, expectedAttributes);
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedAttributes, legArmor.ArmorAttribute);
        }
    }
}
