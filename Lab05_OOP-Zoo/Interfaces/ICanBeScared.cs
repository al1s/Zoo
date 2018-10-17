using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Zoo.Interfaces
{
    public interface ICanBeScared
    {
        int FrightLevel { get; set; }
        void SeenSomethingScary();
        void NameYourself();
    }
}
