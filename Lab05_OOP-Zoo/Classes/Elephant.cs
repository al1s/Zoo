using System;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Elephant : Herbivore
    {
        public override int ScarcityLevel { get; set; } = 6;
        public override int FrightLevel { get; set; } = 8;

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
        public override int Move(int speed, int time)
        {
            Console.WriteLine("I'm slow!");
            double elephantVar = 0.7;
            return (int) Math.Round(speed * time * elephantVar);
        }

        public override void SeenSomethingScary()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            return "Pawoo!";
        }
    }
}
