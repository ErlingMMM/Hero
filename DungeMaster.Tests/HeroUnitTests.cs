using DungeonMaster.hero;

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
    }




}