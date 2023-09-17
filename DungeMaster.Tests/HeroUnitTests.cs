using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.HeroNamespace;
using DungeonMaster.Exceptions;





namespace DungeonMaster.Tests
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
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedLevelAttributes()
        {
            int expectedLevel = 2;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedLevel, legolas.Level);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedStrength()
        {
            int expectedStrength = 2;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedStrength, legolas.GetLevelAttributes().Strength);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedDexterity()
        {
            int expectedDexterity = 12;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDexterity, legolas.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedIntelligence()
        {
            int expectedIntelligence = 2;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedIntelligence, legolas.GetLevelAttributes().Intelligence);
        }


        [Fact]
        public void LevelUp_ShouldIncreaseStrengthCorrectly()
        {
            int expectedDefaultStrength = 1;
            int expectedLevelUpStrengthIncrease = 1;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDefaultStrength + expectedLevelUpStrengthIncrease, legolas.GetLevelAttributes().Strength);
        }

        [Fact]
        public void LevelUp_ShouldIncreaseDexterityCorrectly()
        {
            int expectedDefaultDexterity = 7;
            int expectedLevelUpDexterityIncrease = 5;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDefaultDexterity + expectedLevelUpDexterityIncrease, legolas.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void LevelUp_ShouldIncreaseIntelligenceCorrectly()
        {
            int expectedDefaultIntelligence = 1;
            int expectedLevelUpIntelligenceIncrease = 1;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDefaultIntelligence + expectedLevelUpIntelligenceIncrease, legolas.GetLevelAttributes().Intelligence);
        }



        [Fact]
        public void HeroAttribute_ShouldIncrementStrengthCorrectly()
        {
            int expectedStrength = 1 + 2;

            HeroAttribute attributes = new(1, 0, 0);
            attributes.Increase(2, 0, 0);
            Assert.Equal(expectedStrength, attributes.Strength);
        }

        [Fact]
        public void HeroAttribute_ShouldIncrementDexterityCorrectly()
        {
            int expectedDexterity = 1 + 2;

            HeroAttribute attributes = new(0, 1, 0);
            attributes.Increase(0, 2, 0);
            Assert.Equal(expectedDexterity, attributes.Dexterity);
        }

        [Fact]
        public void HeroAttribute_ShouldIncrementIntelligenceCorrectly()
        {
            int expectedIntelligence = 1 + 2;

            HeroAttribute attributes = new(0, 0, 1);
            attributes.Increase(0, 0, 2);
            Assert.Equal(expectedIntelligence, attributes.Intelligence);
        }




        [Fact]
        public void EquippedWeapon_ShouldHaveCorrectName()
        {
            string expectedName = "Oak Reflex Bow";

            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new(expectedName, 1, Slot.Weapon, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedName, oakReflexBow.Name);
        }

        [Fact]
        public void EquippedWeapon_ShouldHaveCorrectRequiredLevel()
        {
            int expectedRequiredLevel = 1;

            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", expectedRequiredLevel, Slot.Weapon, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedRequiredLevel, oakReflexBow.RequiredLevel);
        }

        [Fact]
        public void EquippedWeapon_ShouldHaveCorrectSlot()
        {
            Slot expectedSlot = Slot.Weapon;

            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, expectedSlot, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedSlot, oakReflexBow.WeaponSlot);
        }

        [Fact]
        public void EquippedWeapon_ShouldHaveCorrectWeaponType()
        {
            WeaponType expectedWeaponType = WeaponType.Bow;

            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, expectedWeaponType, 10);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedWeaponType, oakReflexBow.WeaponType);
        }

        [Fact]
        public void EquippedWeapon_ShouldHaveCorrectDamage()
        {
            int expectedDamage = 10;

            Hero legolas = new Archer("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, expectedDamage);
            legolas.EquipWeapon(oakReflexBow);
            Assert.Equal(expectedDamage, oakReflexBow.WeaponDamage);
        }

        [Fact]
        public void EquippedArmor_ShouldHaveCorrectName()
        {
            string expectedName = "Leg Armor";

            Hero legolas = new Archer("Legolas");
            Armor legArmor = new(expectedName, 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedName, legArmor.Name);
        }

        [Fact]
        public void EquippedArmor_ShouldHaveCorrectRequiredLevel()
        {
            int expectedRequiredLevel = 2;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Armor legArmor = new("Leg Armor", expectedRequiredLevel, Slot.Legs, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedRequiredLevel, legArmor.RequiredLevel);
        }

        [Fact]
        public void EquippedArmor_ShouldHaveCorrectSlot()
        {
            Slot expectedSlot = Slot.Legs;

            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", 1, expectedSlot, ArmorType.Leather, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedSlot, legArmor.ArmorSlot);
        }

        [Fact]
        public void EquippedArmor_ShouldHaveCorrectArmorType()
        {
            ArmorType expectedArmorType = ArmorType.Leather;

            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", 1, Slot.Legs, expectedArmorType, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedArmorType, legArmor.ArmorType);
        }

        [Fact]
        public void EquippedArmor_ShouldHaveCorrectArmorAttributes()
        {
            HeroAttribute expectedAttributes = new(10, 20, 30);

            Hero legolas = new Archer("Legolas");
            Armor legArmor = new("Leg Armor", 1, Slot.Legs, ArmorType.Leather, expectedAttributes);
            legolas.EquipArmor(legArmor);
            Assert.Equal(expectedAttributes, legArmor.ArmorAttribute);
        }


        [Fact]

        public void Heroes_ShouldBeAbleToEquipWeapon()
        {
            Archer legolas = new("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, 10);
            legolas.EquipWeapon(oakReflexBow);

            Weapon? expectedEquippedWeapon = legolas.EquippedWeapon;

            Assert.NotNull(expectedEquippedWeapon);
        }

        [Fact]
        public void HeroWeaponEquip_ShouldThrowInvalidWeaponExceptionOnInvalidLevelRequirement()
        {

            Archer legolas = new("Legolas");
            //level is 1 by default
            int levelRequirement = 5;
            Weapon oakReflexBow = new("Oak Reflex Bow", levelRequirement, Slot.Weapon, WeaponType.Bow, 10);

            Assert.Throws<InvalidWeaponException>(() => legolas.EquipWeapon(oakReflexBow));
        }

        [Fact]

        public void HeroWeaponEquip_ShouldThrowInvalidWeaponExceptionOnInvalidWeaponType()
        {

            Archer legolas = new("Legolas");
            var weaponType = WeaponType.Wand;
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, weaponType, 10);

            Assert.Throws<InvalidWeaponException>(() => legolas.EquipWeapon(oakReflexBow));
        }

        [Fact]
        public void Heroes_ShouldBeAbleToEquipArmor()
        {
            Archer legolas = new("Legolas");
            Armor clothArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(10, 20, 30));
            legolas.EquipArmor(clothArmor);

            Armor? expectedEquippedArmor = legolas.EquippedArmor;

            Assert.NotNull(expectedEquippedArmor);
        }

        [Fact]
        public void HeroArmorEquip_ShouldThrowInvalidArmorExceptionOnInvalidArmorType()
        {

            Archer legolas = new("Legolas");
            var armorType = ArmorType.Cloth;
            Armor clothArmor = new("Head Armor", 1, Slot.Head, armorType, new HeroAttribute(10, 20, 30));

            Assert.Throws<InvalidArmorException>(() => legolas.EquipArmor(clothArmor));
        }

        [Fact]
        public void HeroArmorEquip_ShouldThrowInvalidArmorExceptionOnInvalidLevelRequirement()
        {

            Archer legolas = new("Legolas");
            int levelRequirement = 5;

            Armor clothArmor = new("Head Armor", levelRequirement, Slot.Head, ArmorType.Mail, new HeroAttribute(10, 20, 30));

            Assert.Throws<InvalidArmorException>(() => legolas.EquipArmor(clothArmor));
        }

        [Fact]
        public void HeroTotalAttributes_ShouldBeEqualLevelAttributesWhenNoEquipmentIsAdded()
        {
            //Default values level 1 for archer class
            int expectedStrengtArcher = 1;
            int expectedDexterityArcher = 7;
            int expectedIntelligenceArcher = 1;

            Archer legolas = new("Legolas");

            HeroAttribute levelAttributes = new(expectedStrengtArcher, expectedDexterityArcher, expectedIntelligenceArcher);
            var totalAttributes = legolas.TotalAttributes();

            Assert.Equal(levelAttributes, totalAttributes);
        }

        [Fact]
        public void HeroTotalAttributes_ShouldBeEqualLevelAttributesWhenOnePieceOfArmorIsAdded()
        {

            //Default values level 1 for archer class
            int expectedStrengtArcher = 1;
            int expectedDexterityArcher = 7;
            int expectedIntelligenceArcher = 1;

            Archer legolas = new("Legolas");

            Armor headArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(5, 5, 5));
           
            legolas.EquipArmor(headArmor);

            HeroAttribute expectedTotalAttributes = new(expectedStrengtArcher + 5, expectedDexterityArcher + 5, expectedIntelligenceArcher + 5);
            var totalAttributes = legolas.TotalAttributes();

            Assert.Equal(expectedTotalAttributes, totalAttributes);
        }


        [Fact]
        public void HeroTotalAttributes_ShouldBeEqualLevelAttributesWhenTwoPiecesOfArmorIsAdded()
        {

            //Default values level 1 for archer class
            int expectedStrengtArcher = 1;
            int expectedDexterityArcher = 7;
            int expectedIntelligenceArcher = 1;

            Archer legolas = new("Legolas");

            Armor headArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(5, 5, 5));
            Armor legArmor = new("Leg Armor", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(5, 5, 5));
            legolas.EquipArmor(headArmor);
            legolas.EquipArmor(legArmor);

            HeroAttribute expectedTotalAttributes = new(expectedStrengtArcher + 10, expectedDexterityArcher + 10, expectedIntelligenceArcher + 10);
            var totalAttributes = legolas.TotalAttributes();

            Assert.Equal(expectedTotalAttributes, totalAttributes);
        }
    }
}








