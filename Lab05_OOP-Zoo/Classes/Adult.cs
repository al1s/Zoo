using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Zoo.Classes
{
    public class Adult : Visitor
    {
        public override int FrightLevel { get; set; } = 8;
    }
}
