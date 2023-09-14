using Dungeon.Equipment;
using System.Text;

namespace Dungeon.Services
{
    public class DisplayEquipmentService
    {
        public string DisplayEquipment(string name, int level, Dictionary<Slot, Item> equipment)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Equipment for {name} (Level {level}):");

            foreach (Slot slot in Enum.GetValues(typeof(Slot)))
            {
                var equippedItem = equipment[slot];

                if (equippedItem != null)
                {
                    output.AppendLine($"Slot: {slot}");
                    output.AppendLine($"Type: {equippedItem.Slot}");
                    output.AppendLine($"Name: {equippedItem.Name}");
                    output.AppendLine($"Required Level: {equippedItem.RequiredLevel}");
                    output.AppendLine();
                }
            }

            return output.ToString();
        }
    }
}
