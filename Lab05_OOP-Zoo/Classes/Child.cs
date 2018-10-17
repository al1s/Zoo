using Lab05_OOP_Zoo.Interfaces;
using System;

namespace Lab05_OOP_Zoo.Classes
{
    public class Child : Visitor
    {
        /// <summary>
        /// Define easy/hard to scary the visitor
        /// </summary>
        public override int FrightLevel { get; set; } = 2;
    }
}
