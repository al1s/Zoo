using System;


namespace Lab05_OOP_Zoo.Classes
{
    public class Monkey : Herbivore
    {
        public override int ScarcityLevel { get; set; } = 1;
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
        public override string Sound()
        {
            return "Meow...";
        }
    }
}