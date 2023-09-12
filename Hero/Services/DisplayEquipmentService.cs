using Hero.Equipment;
using Hero.hero;
using System;
using System.Collections.Generic;

namespace Hero.Services
{
    public class DisplayEquipmentService
    {
        public void DisplayEquipment(string name, int level, Dictionary<Slot, Item> equipment)
        {
            Console.WriteLine($"Equipment for {name} (Level {level}):");

            foreach (Slot slot in Enum.GetValues(typeof(Slot)))
            {
                var equippedItem = equipment[slot];

                if (equippedItem != null)
                {
                    Console.WriteLine($"Slot: {slot}");
                    Console.WriteLine($"Type: {equippedItem.Slot}");
                    Console.WriteLine($"Name: {equippedItem.Name}");
                    Console.WriteLine($"Required Level: {equippedItem.RequiredLevel}");
                    Console.WriteLine();
                }
            }
        }
    }
}
