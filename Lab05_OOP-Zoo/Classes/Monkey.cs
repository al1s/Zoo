using System;


namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Monkey : Herbivore
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="food"></param>
        /// <returns>string</returns>
        public override string Eat(Plant food)
        {
            if (food is Banana)
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
            Console.WriteLine("I'm fast");
            double monkeyVar = 1.3;
            return (int)Math.Round(avgSpeed * time * monkeyVar); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>string</returns>
        public override string Sound()
        {
            return "Meow";
        }
    }
}