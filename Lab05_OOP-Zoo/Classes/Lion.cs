using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Lion : Carnivore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        /// <returns>string</returns>
        public override string Eat(Animal food)
        {
            if(food is Monkey)
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
            Console.WriteLine("I'm fastest");
            double monkeyVar = 1.7;
            return (int)Math.Round(avgSpeed * time * monkeyVar); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return "Rooar!";
        }
    }
}
