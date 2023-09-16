using DungeonMaster.hero;
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
    }
}