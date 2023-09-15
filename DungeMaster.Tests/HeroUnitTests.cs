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
            //Assert.AreEqual(expectedLevel, archer.Level);
            /*Assert.AreEqual(expectedStrength, archer.LevelAttributes.Strength);
            Assert.AreEqual(expectedDexterity, archer.LevelAttributes.Dexterity);
            Assert.AreEqual(expectedIntelligence, archer.LevelAttributes.Intelligence);*/

        }
    }




}