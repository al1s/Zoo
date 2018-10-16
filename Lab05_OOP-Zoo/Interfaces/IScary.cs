using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo
{
    public interface IScary
    {
        /// <summary>
        /// How scary the animal is
        /// </summary>
        int ScarcityLevel { get; set; }
        /// <summary>
        /// Try to scare a creature
        /// </summary>
        /// <param name="creature">A creature to be tried to scare</param>
        void Scare(ICanBeScared person);
    }
}
