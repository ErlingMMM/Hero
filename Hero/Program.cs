﻿using Hero.hero;
using System;

class Program
{
    static void Main()
    {
        Archer archer = new Archer("Arch1");
        archer.LevelUp();
        archer.LevelUp();
        archer.Display();
    }
}
