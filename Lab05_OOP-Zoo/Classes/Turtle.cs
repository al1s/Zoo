using System;


namespace Lab05_OOP_Zoo.Classes
{
    public class Turtle : Herbivore
    {
        public override int ScarcityLevel { get; set; } = 1;
        public override bool CanJump { get => base.CanJump; set => base.CanJump = false; }
        public override string Eat(Plant food)
        {
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
            Console.WriteLine("I'm the slowest!");
            double turtleVar = 0.1;
            return (int)Math.Round(speed * time * turtleVar);
        }

        public override string Sound()
        {
            return string.Empty;
        }
    }
}
