using DungeonMaster.Equipment;
using System.Text;

namespace DungeonMaster.Services
{
    public class DisplayEquipmentService
    {
        public static string DisplayEquipment(string name, int level, Dictionary<Slot, Item?> equipment)
        {
            StringBuilder output = new();
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
