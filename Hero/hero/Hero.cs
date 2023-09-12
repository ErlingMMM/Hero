using Hero.Attributes;


namespace Hero.hero
{
    public abstract class Hero
    {
        protected string Name;
        protected int Level;
        protected HeroAttribute LevelAttributes;
        public abstract void LevelUp();
        public abstract void Display();



        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute();

        }
    }
}


