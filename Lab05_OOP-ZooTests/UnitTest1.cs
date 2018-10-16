using System;
using Xunit;
using Lab05_OOP_Zoo.Classes;

namespace Lab05_OOP_ZooTests
{
    public class UnitTest1
    {
        [Fact]
        public void MonkeyCanMove()
        {
            Monkey monkey = new Monkey();
            Assert.Equal((int)Math.Round(1*1*1.3), monkey.Move(1, 1));
        }
        [Fact]
        public void LionCanMove()
        {
            Lion lion = new Lion();
            Assert.Equal((int)Math.Round(1*1*1.7), lion.Move(1, 1));
        }
        [Fact]
        public void TurtleCanMove()
        {
            Turtle turtle = new Turtle();
            Assert.Equal((int)Math.Round(1*1*0.1), turtle.Move(1, 1));
        }
        [Fact]
        public void SnakeCanMove()
        {
            Snake snake = new Snake();
            Assert.Equal(1, snake.Move(1, 1));
        }
        [Fact]
        public void ElephantCanMove()
        {
            Elephant elephant= new Elephant();
            Assert.Equal((int)Math.Round(1*1*0.7), elephant.Move(1, 1));
        }

        [Fact]
        public void MonkeyCanSleep()
        {
            Monkey monkey = new Monkey();
            Assert.Equal("Zzz...", monkey.Sleep("", 1));
        }
        [Fact]
        public void LionCanSleep()
        {
            Lion lion = new Lion();
            Assert.Equal("Zzz...", lion.Sleep("", 1));
        }
        [Fact]
        public void TurtleCanSleep()
        {
            Turtle turtle = new Turtle();
            Assert.Equal("Zzz...", turtle.Sleep("", 1));
        }
        [Fact]
        public void SnakeCanSleep()
        {
            Snake snake = new Snake();
            Assert.Equal("Zzz...", snake.Sleep("", 1));
        }
        [Fact]
        public void ElephantCanSleep()
        {
            Elephant elephant= new Elephant();
            Assert.Equal("Zzz...", elephant.Sleep("", 1));
        }
    }
}
