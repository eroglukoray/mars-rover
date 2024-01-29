using MarsRover;
using System;
using Xunit;

namespace MarsRoverTest
{
    public class RoverMovement
    {
        [Fact]
        public void TurnLeft()
        {
            //arrange
            Plateau plateau = new Plateau("5 5");
            Rover rover = new Rover("1 2 N",plateau);
            //act
            rover.TurnLeft();
            //assert
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void TurnRight()
        {
            //arrange
            Plateau plateau = new Plateau("5 5");
            Rover rover = new Rover("1 2 N",plateau);
            //act
            rover.TurnRight();
            //assert
            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void GoForward()
        {
            //arrange
            Plateau plateau = new Plateau("5 5");
            Rover rover = new Rover("1 2 S", plateau);
            //act
            rover.GoForward();
            //assert
            Assert.Equal(1, rover.y);
        }

        [Fact]
        public void Move_1()
        {
            Plateau plateau = new Plateau("5 5");
            Rover rover = new Rover("1 2 N", plateau);

            string command = "LMLMLMLMM";
            if (rover.x<= plateau.xUnit && rover.y <= plateau.yUnit)
            {
                rover.Move(command);
                Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
            }
            else
                throw new ArgumentOutOfRangeException(string.Format("Out of range for x: {0} and/or y: {1}", rover.x, rover.y));
        }
        [Fact]
        public void Move_2()
        {
            Plateau plateau = new Plateau("5 5");
            Rover rover = new Rover("3 3 E", plateau);

            string command = "MMRMMRMRRM";

            if (rover.x >= 0 && rover.y >= 0 && rover.x <= plateau.xUnit && rover.y <= plateau.yUnit)
            {
                rover.Move(command);
                Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
            }
            else
                throw new ArgumentOutOfRangeException(string.Format("Out of range for x: {0} and/or y: {1}", rover.x, rover.y));
            
        }
    }
}
