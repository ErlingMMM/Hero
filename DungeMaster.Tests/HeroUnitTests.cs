using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.HeroNamespace;
using DungeonMaster.Exceptions;
using DungeonMaster.Services;





namespace DungeonMaster.Tests
{
    public class HeroUnitTests
    {
        [Fact]
        public void CreateArcher_ShouldHaveCorrectName()
        {
            string expectedName = "Legolas";

            Hero legolas = new Archer(expectedName);
            Assert.Equal(expectedName, legolas.GetName());
        }

        [Fact]
        public void CreateWizard_ShouldHaveCorrectName()
        {
            string expectedName = "Gandalf";

            Hero gandalf = new Wizard(expectedName);
            Assert.Equal(expectedName, gandalf.GetName());
        }


        [Fact]
        public void CreateArcher_ShouldHaveCorrectLevel()
        {
            int expectedLevel = 1;

            Hero legolas = new Archer("Legolas");
            Assert.Equal(expectedLevel, legolas.Level);
        }

        [Fact]
        public void CreateWizard_ShouldHaveCorrectLevel()
        {
            int expectedLevel = 1;

            Hero gandalf = new Wizard("Gandalf");
            Assert.Equal(expectedLevel, gandalf.Level);
        }

        [Fact]
        public void CreateArcher_ShouldHaveCorrectStrength()
        {
            int expectedStrength = 1;

            Hero legolas = new Archer("Legolas");
            Assert.Equal(expectedStrength, legolas.GetLevelAttributes().Strength);
        }

     

        [Fact]
        public void CreateWizard_ShouldHaveCorrectStrength()
        {
            int expectedStrength = 1;

            Hero gandalf = new Wizard("Gandalf");
            Assert.Equal(expectedStrength, gandalf.GetLevelAttributes().Strength);
        }

 

        [Fact]
        public void ArcherIncreaseLevel_ShouldHaveCorrectIncreasedLevel()
        {
            int expectedLevel = 2;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedLevel, legolas.Level);
        }

        [Fact]
        public void WizardIncreaseLevel_ShouldHaveCorrectIncreasedLevel()
        {
            int expectedLevel = 2;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedLevel, gandalf.Level);
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
        public void WizardIncreaseLevel_ShouldHaveCorrectIncreasedStrength()
        {
            int expectedStrength = 2;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedStrength, gandalf.GetLevelAttributes().Strength);
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
        public void WizardIncreaseLevel_ShouldHaveCorrectIncreasedDexterity()
        {
            int expectedDexterity = 2;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedDexterity, gandalf.GetLevelAttributes().Dexterity);
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
        public void WizardIncreaseLevel_ShouldHaveCorrectIncreasedIntelligence()
        {
            int expectedIntelligence = 13;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedIntelligence, gandalf.GetLevelAttributes().Intelligence);
        }

        [Fact]
        public void ArcherLevelUp_ShouldIncreaseStrengthCorrectly()
        {
            int expectedDefaultStrength = 1;
            int expectedLevelUpStrengthIncrease = 1;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDefaultStrength + expectedLevelUpStrengthIncrease, legolas.GetLevelAttributes().Strength);
        }

        [Fact]
        public void ArcherLevelUp_ShouldIncreaseDexterityCorrectly()
        {
            int expectedDefaultDexterity = 7;
            int expectedLevelUpDexterityIncrease = 5;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDefaultDexterity + expectedLevelUpDexterityIncrease, legolas.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void ArcherLevelUp_ShouldIncreaseIntelligenceCorrectly()
        {
            int expectedDefaultIntelligence = 1;
            int expectedLevelUpIntelligenceIncrease = 1;

            Hero legolas = new Archer("Legolas");
            legolas.LevelUp();
            Assert.Equal(expectedDefaultIntelligence + expectedLevelUpIntelligenceIncrease, legolas.GetLevelAttributes().Intelligence);
        }


        [Fact]
        public void WizardLevelUp_ShouldIncreaseStrengthCorrectly()
        {
            int expectedDefaultStrength = 1;
            int expectedLevelUpStrengthIncrease = 1;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedDefaultStrength + expectedLevelUpStrengthIncrease, gandalf.GetLevelAttributes().Strength);
        }

        [Fact]
        public void WizardLevelUp_ShouldIncreaseDexterityCorrectly()
        {
            int expectedDefaultDexterity = 1; 
            int expectedLevelUpDexterityIncrease = 1;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedDefaultDexterity + expectedLevelUpDexterityIncrease, gandalf.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void WizardLevelUp_ShouldIncreaseIntelligenceCorrectly()
        {
            int expectedDefaultIntelligence = 8;
            int expectedLevelUpIntelligenceIncrease = 5;

            Hero gandalf = new Wizard("Gandalf");
            gandalf.LevelUp();
            Assert.Equal(expectedDefaultIntelligence + expectedLevelUpIntelligenceIncrease, gandalf.GetLevelAttributes().Intelligence);
        }


        [Fact]
        public void CreateBarbarian_ShouldHaveCorrectName()
        {
            string expectedName = "Conan";

            Hero conan = new Barbarian(expectedName);
            Assert.Equal(expectedName, conan.GetName());
        }

        [Fact]
        public void CreateBarbarian_ShouldHaveCorrectLevel()
        {
            int expectedLevel = 1;

            Hero conan = new Barbarian("Conan");
            Assert.Equal(expectedLevel, conan.Level);
        }

        [Fact]
        public void BarbarianIncreaseLevel_ShouldHaveCorrectIncreasedLevel()
        {
            int expectedLevel = 2;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedLevel, conan.Level);
        }

        [Fact]
        public void BarbarianIncreaseLevel_ShouldHaveCorrectIncreasedStrength()
        {
            int expectedStrength = 8;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedStrength, conan.GetLevelAttributes().Strength);
        }

        [Fact]
        public void BarbarianIncreaseLevel_ShouldHaveCorrectIncreasedDexterity()
        {
            int expectedDexterity = 4;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedDexterity, conan.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void BarbarianIncreaseLevel_ShouldHaveCorrectIncreasedIntelligence()
        {
            int expectedIntelligence = 2;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedIntelligence, conan.GetLevelAttributes().Intelligence);
        }

        [Fact]
        public void BarbarianLevelUp_ShouldIncreaseStrengthCorrectly()
        {
            int expectedDefaultStrength = 5;
            int expectedLevelUpStrengthIncrease = 3;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedDefaultStrength + expectedLevelUpStrengthIncrease, conan.GetLevelAttributes().Strength);
        }

        [Fact]
        public void BarbarianLevelUp_ShouldIncreaseDexterityCorrectly()
        {
            int expectedDefaultDexterity = 2;
            int expectedLevelUpDexterityIncrease = 2;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedDefaultDexterity + expectedLevelUpDexterityIncrease, conan.GetLevelAttributes().Dexterity);
        }

        [Fact]
        public void BarbarianLevelUp_ShouldIncreaseIntelligenceCorrectly()
        {
            int expectedDefaultIntelligence = 1;
            int expectedLevelUpIntelligenceIncrease = 1;

            Hero conan = new Barbarian("Conan");
            conan.LevelUp();
            Assert.Equal(expectedDefaultIntelligence + expectedLevelUpIntelligenceIncrease, conan.GetLevelAttributes().Intelligence);
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
        public void HeroTotalAttributes_ShouldBeCalculatedCorrectlyWhenNoEquipmentIsAdded()
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
        public void HeroTotalAttributes_ShouldBeCalculatedCorrectlyWhenOnePieceOfArmorIsAdded()
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
        public void HeroTotalAttributes_ShouldBeCalculatedCorrectlyWhenTwoPiecesOfArmorIsAdded()
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

        [Fact]
        public void HeroTotalAttributes_ShouldBeCalculatedCorrectlyWithAReplacedPieceOfArmor()
        {

            //Default values level 1 for archer class
            int expectedStrengtArcher = 1;
            int expectedDexterityArcher = 7;
            int expectedIntelligenceArcher = 1;

            Archer legolas = new("Legolas");

            Armor headArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(3, 3, 3));
            Armor replacedHeadArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(5, 5, 5));
            legolas.EquipArmor(headArmor);
            legolas.EquipArmor(replacedHeadArmor);

            HeroAttribute expectedTotalAttributes = new(expectedStrengtArcher + 5, expectedDexterityArcher + 5, expectedIntelligenceArcher + 5);
            var totalAttributes = legolas.TotalAttributes();

            Assert.Equal(expectedTotalAttributes, totalAttributes);
        }




        [Fact]
        public void HeroDamage_ShouldBeCalculatedCorrectlyWithNoWeaponEquipped()
        {

            //Default values level 1 for archer class
            //Dexterity is the damage attribute for Archer class
            int dexterityAttributeArcher = 7;
            int initialWeaponDamage = 1;

            int expectedDamage = initialWeaponDamage * (1 + dexterityAttributeArcher / 100);

            Archer legolas = new("Legolas");


            Assert.Equal(expectedDamage, legolas.Damage());
        }

        [Fact]
        public void HeroDamage_ShouldBeCalculatedCorrectlyWithWeaponEquipped()
        {

           
            int dexterityAttributeArcher = 7;
            int weaponDamage = 10;

            int expectedDamage = weaponDamage * (1 + dexterityAttributeArcher / 100);

            Archer legolas = new("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, weaponDamage);
            legolas.EquipWeapon(oakReflexBow);

            Assert.Equal(expectedDamage, legolas.Damage());
        }

        [Fact]
        public void HeroDamage_ShouldBeCalculatedCorrectlyWithReplacedEquippedWeapon()
        {


            int dexterityAttributeArcher = 7;
            int weaponDamage = 10;

            int expectedDamage = weaponDamage * (1 + dexterityAttributeArcher / 100);

            Archer legolas = new("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, weaponDamage);
            Weapon commonBow = new("Common Bow", 1, Slot.Weapon, WeaponType.Bow, weaponDamage);
            legolas.EquipWeapon(oakReflexBow);
            legolas.EquipWeapon(commonBow);

            Assert.Equal(expectedDamage, legolas.Damage());
        }

        [Fact]
        public void HeroDamage_ShouldBeCalculatedCorrectlyWithReplacedEquippedWeaponAndEquippedArmor()
        {


            int initialDexterityAttributeArcher = 7;
            int armorDexterityBonus = 5;
            int totalDexterity = initialDexterityAttributeArcher + armorDexterityBonus;
            int weaponDamage = 10;

            int expectedDamage  = (int) (weaponDamage * (1 + totalDexterity / 100.0));

            Archer legolas = new("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, weaponDamage);
            Armor headArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(3, armorDexterityBonus, 3));
            legolas.EquipWeapon(oakReflexBow);
            legolas.EquipArmor(headArmor);

            Assert.Equal(expectedDamage, legolas.Damage());
        }

        [Fact]
        public void Heroes_ShouldDisplayTheirStateCorrectly()
        {

            int initialDexterityAttributeArcher = 7;
            int initialWeaponDamage = 1;

            int expectedDamage = initialWeaponDamage * (1 + initialDexterityAttributeArcher / 100);

            Archer legolas = new("Legolas");
          

            string expectedState = "Name: Legolas" +
                              "\nClass: Archer" +
                              "\nLevel: 1" +
                              "\nTotal Strength: 1" +
                              "\nTotal Dexterity: 7" +
                              "\nTotal Intelligence: 1" +
                              $"\nDamage: {expectedDamage}" +
                              "\n\n"; 


            string actualState = DisplayHeroService.DisplayHeroInfo(legolas.GetName(), "Archer", legolas.Level, legolas.TotalAttributes(), legolas.Damage()).Replace("\r\n", "\n"); ;

            Assert.Equal(expectedState, actualState);
        }

        [Fact]
        public void Heroes_ShouldDisplayTheirEquipment()
        {
            Archer legolas = new("Legolas");
            Weapon oakReflexBow = new("Oak Reflex Bow", 1, Slot.Weapon, WeaponType.Bow, 10);
            Armor headArmor = new("Head Armor", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(3, 3, 3));
            legolas.EquipWeapon(oakReflexBow);
            legolas.EquipArmor(headArmor);

            string expectedEquipmentDisplay = "Equipment for Legolas (Level 1):\n" +
                                              "Slot: Weapon\n" +
                                              "Type: Weapon\n" +
                                              "Name: Oak Reflex Bow\n" +
                                              "Required Level: 1\n\n" +
                                              "Slot: Head\n" +
                                              "Type: Head\n" +
                                              "Name: Head Armor\n" +
                                              "Required Level: 1\n\n";

            string actualEquipmentDisplay = DisplayEquipmentService.DisplayEquipment(
                legolas.GetName(),
                legolas.Level,
                legolas.Equipment
            ).Replace("\r\n", "\n").Replace("\r", "\n");

            Assert.Equal(expectedEquipmentDisplay, actualEquipmentDisplay);
        }






        //readme
        //readme


    }
}









    













