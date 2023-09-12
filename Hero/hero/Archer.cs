using Hero.Attributes;
using Hero.Services;


namespace Hero.hero
{
    public class Archer : Hero
    {
        private readonly DisplayService displayService = new DisplayService();


        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(strength: 1, dexterity: 7, intelligence: 1);

        }

        public override void LevelUp()
        {
            Level++;
            int levelStrengt = LevelAttributes.Strength + 1;
            int levelDexterity = LevelAttributes.Dexterity + 5;
            int levelIntelligence = LevelAttributes.Intelligence + 1;
            LevelAttributes = new HeroAttribute(strength: levelStrengt, dexterity: levelDexterity, intelligence: levelIntelligence);
        }

        public void Display()
        {
            displayService.DisplayHeroInfo(Name, "Archer", Level, LevelAttributes);
        }
    }
}