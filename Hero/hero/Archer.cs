using Hero.Attributes;


namespace Hero.hero
{
    public class Archer : Hero
    {

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
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: Archer");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Strength: {LevelAttributes.Strength}");
            Console.WriteLine($"Dexterity: {LevelAttributes.Dexterity}");
            Console.WriteLine($"Intelligence: {LevelAttributes.Intelligence}");
        }
    }
}