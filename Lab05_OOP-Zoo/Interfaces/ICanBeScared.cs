using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP_Zoo.Interfaces
{
    public interface ICanBeScared
    {
        /// <summary>
        /// Define easy/hard to scary the visitor
        /// </summary>
        int FrightLevel { get; set; }
        /// <summary>
        /// Behavior if a visitor's seen something scary
        /// </summary>
        void SeenSomethingScary();
        /// <summary>
        /// Print to console the name of a visitor
        /// </summary>
        void NameYourself();
    }
}
