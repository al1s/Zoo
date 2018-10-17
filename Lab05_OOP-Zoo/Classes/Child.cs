using Lab05_OOP_Zoo.Interfaces;
using System;

namespace Lab05_OOP_Zoo.Classes
{
    public class Child : Visitor
    {
        public override int FrightLevel { get; set; } = 2;
    }
}
