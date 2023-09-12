namespace Hero.Equipment
{
    public abstract class Item
    {
        public string Name;
        public int RequiredLevel;
        public string Slot;

        protected Item(string name, int requiredLevel, string slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}