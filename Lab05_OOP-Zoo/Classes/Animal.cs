using System;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo.Classes
{
    abstract public class Animal : Eatable, IScary, ICanBeScared
    {
        /// <summary>
        /// How scary the animal is
        /// </summary>
        abstract public int ScarcityLevel { get; set; }
        /// <summary>
        /// Try to scare a creature
        /// </summary>
        /// <param name="creature">A creature to be tried to scare</param>
        public void Scare(ICanBeScared creature)
        {
            if (creature.FrightLevel < ScarcityLevel)
            {
                this.NameYourself();
                Console.Write("I scared you!!! ");
                creature.NameYourself();
                creature.SeenSomethingScary();
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Whether the animal can jump
        /// </summary>
        public virtual bool CanJump { get; set; } = true;
        abstract public int FrightLevel { get; set; }

        /// <summary>
        /// Make a sound
        /// </summary>
        /// <returns>string</returns>
        abstract public string Sound();

        /// <summary>
        /// Make an animal to sleep 
        /// </summary>
        /// <param name="startTime">Start time of the sleep</param>
        /// <param name="duration">Duration of the sleep</param>
        /// <returns>string</returns>
        public virtual string Sleep(string startTime, int duration)
        {
            return "Zzz...";
        }
        /// <summary>
        /// Print to console the name of a visitor
        /// </summary>
        public void NameYourself()
        {
            Console.Write($"I'm a {this.Name}. ");
        }
        /// <summary>
        /// Make an animal to move
        /// </summary>
        /// <param name="avgSpeed">Average speed of the animal</param>
        /// <returns>int</returns>
        virtual public int Move(int avgSpeed, int time)
        {
            return avgSpeed * time;
        }

        abstract public void SeenSomethingScary();
    }
}