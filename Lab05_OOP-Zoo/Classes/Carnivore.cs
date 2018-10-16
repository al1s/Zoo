namespace Lab05_OOP_Zoo.Classes
{
    abstract public class Carnivore : Animal
    {
        /// <summary>
        /// Make an animal to eat
        /// </summary>
        /// <param name="food">Food to eat</param>
        /// <returns></returns>
        abstract public string Eat(Animal food);
    }
}
