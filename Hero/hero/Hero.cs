using Hero.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hero.hero
{
    public abstract class Hero
    {
        protected string Name;
        protected int Level;
        protected HeroAttribute LevelAttributes;
        public abstract void  LevelUp();



        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute();


        }

    }
}
