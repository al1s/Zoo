using System;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Animal : Eatable, IScary
    {
        abstract public int ScarcityLevel { get; set; }
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

        public virtual bool CanJump { get; set; } = true;
        /// <summary>
        /// 
        /// </summary>
        /// <returns>string</returns>
        abstract public string Sound();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="duration"></param>
        /// <returns>string</returns>
        public virtual string Sleep(string startTime, int duration)
        {
            return "Zzz...";
        }
        public void NameYourself()
        {
            Console.Write($"I'm a {this.Name}. ");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pace"></param>
        /// <returns>int</returns>
        virtual public int Move(int avgSpeed, int time)
        {
            return avgSpeed * time;
        }

    }
}