namespace Hero.Equipment
{
    public abstract class Item
    {
        protected string Name;
        protected int RequiredLevel;
        protected string Slot;

        protected Item(string name, int requiredLevel, string slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}