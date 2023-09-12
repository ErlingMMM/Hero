namespace Hero.Equipment
{
    public abstract class Item
    {
        protected string Name { get; }
        protected int RequiredLevel { get; }
        protected string Slot { get; }

        protected Item(string name, int requiredLevel, string slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}