using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo
{
    public interface IScary
    {
        int ScarcityLevel { get; set; }
        void Scare(ICanBeScared person);
    }
}
