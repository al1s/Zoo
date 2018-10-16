using System;

namespace Lab05_OOP_Zoo.Classes
{
    public class Snake : Carnivore
    {
        public override int ScarcityLevel { get; set; } = 8;
        public override bool CanJump { get => base.CanJump; set => base.CanJump = false; }
        public override int FrightLevel { get; set; } = 8;

        public override string Eat(Animal food)
        {
            if (food is Turtle)
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

        public override void SeenSomethingScary()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            return "Hsssss!";
        }
    }
}
