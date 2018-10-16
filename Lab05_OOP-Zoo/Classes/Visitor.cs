using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo.Classes
{
    abstract public class Visitor : ICanBeScared
    {
        /// <summary>
        /// Name of a visitor
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Define easy/hard to scary the visitor
        /// </summary>
        abstract public int FrightLevel { get; set; }
        /// <summary>
        /// Print to console the name of a visitor
        /// </summary>
        public void NameYourself()
        {
            Console.Write($"I'm a {this.Name}. ");
        }
        /// <summary>
        /// Behavior if a visitor's seen something scary
        /// </summary>
        public void SeenSomethingScary()
        {
            Console.Write("A-A-A-a-a-a-a-a!");
        }
    }
}
