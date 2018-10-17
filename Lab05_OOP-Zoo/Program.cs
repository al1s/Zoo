using System;
using Lab05_OOP_Zoo.Classes;
using Lab05_OOP_Zoo.Interfaces;

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
            Animal[] zoo = new Animal[5];
            zoo[0] = bigMonkey;
            zoo[1] = smallElephant;
            zoo[2] = normalTurtle;
            zoo[3] = lion;
            zoo[4] = snake;

            Visitor[] visitors = new Visitor[3];
            Adult adultBrave = new Adult() { Name = "Adult, brave one" };
            Adult adultNotSoBrave = new Adult() { FrightLevel = 7, Name = "Adult but not so brave" };
            Child child = new Child() { Name = "Child" };

            visitors[0] = adultBrave;
            visitors[1] = adultNotSoBrave;
            visitors[2] = child;

            FeedAnimals(zoo);
            SoundFrom(zoo);
            ScareAll(visitors, zoo);
            Console.ReadLine();
        }
        /// <summary>
        /// Try to scare visitors with animals
        /// </summary>
        /// <param name="animals">Animals available</param>
        /// <param name="visitors">Visitors available</param>
        public static void ScareAll(Visitor[] visitors, Animal[] animals)
        {
            Random rnd = new Random();
            foreach (Animal animal in animals)
            {
                animal.Scare(visitors[rnd.Next(0, 3)]);
            }
        }
        /// <summary>
        /// Get a sound for each animals
        /// </summary>
        /// <param name="animals">Animals we want to hear</param>
        public static void SoundFrom(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                animal.NameYourself();
                Console.WriteLine(animal.Sound());
            }
        }
        /// <summary>
        /// Feed all animals
        /// </summary>
        /// <param name="animals">Animals to feed</param>
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
                    if (food.FrightLevel < 2) animal.Scare(food);
                    animal.Eat(food);
                }
            }
        }
    }
}
