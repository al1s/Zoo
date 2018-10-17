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
        public static IEnumerable<object[]> AnimalsWithMultipliers => new List<object[]>
            {
                new object[] { new Elephant(), 0.7 },
                new object[] { new Turtle(), 0.1 },
                new object[] { new Monkey(), 1.3 },
                new object[] { new Lion(), 1.7 },
                new object[] { new Snake(), 1 },
            };

        public static IEnumerable<object[]> AnimalsWithSounds => new List<object[]>
            {
                new object[] { new Elephant(), "Pawoo!" },
                new object[] { new Turtle(), string.Empty },
                new object[] { new Monkey(), "Meow..." },
                new object[] { new Lion(), "Rooar!" },
                new object[] { new Snake(), "Hsssss!" },
            };

        public static IEnumerable<object[]> Animals => new List<object[]>
            {
                new object[] { new Elephant() },
                new object[] { new Turtle() },
                new object[] { new Monkey() },
                new object[] { new Lion() },
                new object[] { new Snake() },
            };

        [Theory]
        [MemberData(nameof(AnimalsWithMultipliers))]
        public void AnimalCanMove(Animal animal, double animalSpeedMultiplier)
        {
            Assert.Equal((int)Math.Round(1 * 1 * animalSpeedMultiplier), animal.Move(1, 1));
        }


        [Theory]
        [MemberData(nameof(Animals))]
        public void AnimalImpelementsIScary(Animal animal)
        {
            Assert.True(animal is IScary);
        }

        [Theory]
        [MemberData(nameof(Animals))]
        public void AnimalCanSleep(Animal animal)
        {
            Assert.Equal("Zzz...", animal.Sleep("", 1));
        }

        [Theory]
        [MemberData(nameof(AnimalsWithSounds))]
        public void AnimalInheritSound(Animal animal, string sound)
        {
            Assert.Equal(sound, animal.Sound());
        }

        [Fact]
        public void AdultImplementICanBeScared()
        {
            Assert.True(new Adult() is ICanBeScared);
        }
        [Fact]
        public void ChildImplementICanBeScared()
        {
            Assert.True(new Child() is ICanBeScared);
        }
    }
}
