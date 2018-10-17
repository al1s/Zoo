using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo.Classes
{
    abstract public class Visitor : ICanBeScared
    {
        public string Name { get; set; }
        abstract public int FrightLevel { get; set; }
        public void NameYourself()
        {
            Console.Write($"I'm a {this.Name}. ");
        }
        public void SeenSomethingScary()
        {
            Console.Write("A-A-A-a-a-a-a-a!");
        }
    }
}
