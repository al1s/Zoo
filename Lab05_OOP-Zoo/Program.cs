using System;
using Lab05_OOP_Zoo.Classes;

namespace Lab05_OOP_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Monkey bigMonkey = new Monkey() { Name = "Monkey Key" };
            Elephant smallElephant = new Elephant() { Name = "Elephant Elle" };
            Turtle normalTurtle = new Turtle() { Name = "Turtle Bee" };
            Lion lion = new Lion() { Name = "Lion Lee" };
            Snake snake = new Snake() { Name = "Slithering One" };
            Animal[] animals = new Animal[5];
            animals[0] = bigMonkey;
            animals[1] = smallElephant;
            animals[2] = normalTurtle;
            animals[3] = lion;
            animals[4] = snake;

            FeedAnimals(animals);
            //Stroll(animals);
            Console.ReadLine();
        }
        public static void FeedAnimals(Animal[] animals)
        {
            int numberOfFoodEntities = 2;
            Plant[] plantFoodBank = new Plant[numberOfFoodEntities];
            for (int i = 0; i < plantFoodBank.Length/2; i++)
            {
                plantFoodBank[i] = new Banana() { Name = "Banana" };
            }
            for (int i = numberOfFoodEntities / 2; i < plantFoodBank.Length; i++)
            {
                plantFoodBank[i] = new Bamboo() { Name = "Bamboo" };
            }

            Animal[] meatFoodBank = new Animal[2];
            int numberOfFoodForMeatEaters = 0;
            foreach (Animal animal in animals)
            {
                if(animal is Turtle || animal is Monkey)
                {
                    meatFoodBank[numberOfFoodForMeatEaters] = animal;
                    numberOfFoodForMeatEaters += 1;
                }
            }

            Herbivore[] plantsEaters = new Herbivore[3];
            Carnivore[] meatEaters = new Carnivore[2];
            int numberOfPlantEaters = 0;
            int numberOfMeatEaters = 0;
            foreach (Animal animal in animals)
            {
                if (animal is Herbivore)
                {
                    plantsEaters[numberOfPlantEaters] = (Herbivore) animal;
                    numberOfPlantEaters += 1;
                }
                else if(animal is Carnivore)
                {
                    meatEaters[numberOfMeatEaters] = (Carnivore) animal;
                    numberOfMeatEaters += 1;
                }
            }
            foreach(Herbivore animal in plantsEaters)
            {
                foreach (Plant food in plantFoodBank)
                {
                    animal.NameYourself();
                    animal.Eat(food);
                }
            }
            foreach(Carnivore animal in meatEaters)
            {
                foreach(Animal food in meatFoodBank)
                {
                    animal.NameYourself();
                    animal.Eat(food);
                }
            }
        }
    }
}
