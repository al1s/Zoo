using System;
using Xunit;
using System.Collections.Generic;
using Lab05_OOP_Zoo.Classes;
using Lab05_OOP_Zoo;
using Lab05_OOP_Zoo.Interfaces;

namespace Lab05_OOP_ZooTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Setup data for animal can move tests
        /// </summary>
        public static IEnumerable<object[]> AnimalsWithMultipliers => new List<object[]>
            {
                new object[] { new Elephant(), 0.7 },
                new object[] { new Turtle(), 0.1 },
                new object[] { new Monkey(), 1.3 },
                new object[] { new Lion(), 1.7 },
                new object[] { new Snake(), 1 },
            };
        /// <summary>
        /// Setup data for animal can make sound tests
        /// </summary>
        public static IEnumerable<object[]> AnimalsWithSounds => new List<object[]>
            {
                new object[] { new Elephant(), "Pawoo!" },
                new object[] { new Turtle(), string.Empty },
                new object[] { new Monkey(), "Meow..." },
                new object[] { new Lion(), "Rooar!" },
                new object[] { new Snake(), "Hsssss!" },
            };
        /// <summary>
        /// Setup data for animal can sleep or animals implement interface tests
        /// </summary>
        public static IEnumerable<object[]> Animals => new List<object[]>
            {
                new object[] { new Elephant() },
                new object[] { new Turtle() },
                new object[] { new Monkey() },
                new object[] { new Lion() },
                new object[] { new Snake() },
            };
        /// <summary>
        /// Test whether animals can move
        /// </summary>
        /// <param name="animal">Instance of an animal</param>
        /// <param name="animalSpeedMultiplier">Animal inherent speed multiplier</param>
        [Theory]
        [MemberData(nameof(AnimalsWithMultipliers))]
        public void AnimalCanMove(Animal animal, double animalSpeedMultiplier)
        {
            Assert.Equal((int)Math.Round(1 * 1 * animalSpeedMultiplier), animal.Move(1, 1));
        }

        /// <summary>
        /// Test whether animals are scary
        /// </summary>
        /// <param name="animal">Instance of an animal</param>
        [Theory]
        [MemberData(nameof(Animals))]
        public void AnimalImpelementsIScary(Animal animal)
        {
            Assert.True(animal is IScary);
        }
        /// <summary>
        /// Test whether animals can sleep
        /// </summary>
        /// <param name="animal">Instance of an animal</param>
        [Theory]
        [MemberData(nameof(Animals))]
        public void AnimalCanSleep(Animal animal)
        {
            Assert.Equal("Zzz...", animal.Sleep("", 1));
        }
        /// <summary>
        /// Test whether animals can make sound
        /// </summary>
        /// <param name="animal">Instance of an animal</param>
        /// <param name="sound">Expected sound the animal makes</param>
        [Theory]
        [MemberData(nameof(AnimalsWithSounds))]
        public void AnimalInheritSound(Animal animal, string sound)
        {
            Assert.Equal(sound, animal.Sound());
        }
        /// <summary>
        /// Test whether an interface ICanBeScared implemented in an Adult class
        /// </summary>
        [Fact]
        public void AdultImplementICanBeScared()
        {
            Assert.True(new Adult() is ICanBeScared);
        }
        /// <summary>
        /// Test whether an interface ICanBeScared implemented in a Child class
        /// </summary>
        [Fact]
        public void ChildImplementICanBeScared()
        {
            Assert.True(new Child() is ICanBeScared);
        }
    }
}
