using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero.Attributes
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }


        public HeroAttribute(int strength = 0, int dexterity = 0, int intelligence = 0)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

    }
}
