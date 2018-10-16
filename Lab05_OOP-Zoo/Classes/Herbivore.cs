using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Zoo.Classes
{
    abstract public class Herbivore : Animal
    {
        abstract public string Eat(Plant food);
    }
}
