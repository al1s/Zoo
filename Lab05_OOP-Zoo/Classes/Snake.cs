using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Snake : Carnivore
    {
        public override bool CanJump { get => base.CanJump; set => base.CanJump = false; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        /// <returns>string</returns>
        public override string Eat(Animal food)
        {
            if(food is Turtle)
            {
                Console.WriteLine($"I like eating {food}.");
                return $"I've eaten {food}";
            }
            else 
            {
                Console.WriteLine($"I don't like {food}.");
                return string.Empty;
            }
        }

        public override int Move(int avgSpeed, int time)
        {
            Console.WriteLine("I'm average");
            return avgSpeed * time; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return "Hsssss!";
        }
    }
}