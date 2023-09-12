﻿using Hero.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero.hero
{
    public class Archer : Hero
    {

        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute
            {
                Strength = 1,
                Dexterity = 7,
                Intelligence = 1 
            };
        }
    }
}
