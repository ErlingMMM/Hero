namespace DungeonMaster.Equipment
{
    public abstract class Item
    {
        public string Name;
        public int RequiredLevel;
        public Slot Slot { get; }
        protected Item(string name, int requiredLevel, Slot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
             Slot = slot;
        }
    }
}