using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Turtle : Herbivore
    {
        /// <summary>
        /// 
        /// </summary>
        public override bool CanJump { get => base.CanJump; set => base.CanJump = false; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        /// <returns>string</returns>
        public override string Eat(Plant food) {
            if (food is Bamboo)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        /// <returns>string</returns>
        public override int Move(int speed, int time)
        {
            Console.WriteLine("I'm the slowest!");
            double turtleVar = 0.1;
            return (int) Math.Round(speed * time * turtleVar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return string.Empty;
        }
    }
}
