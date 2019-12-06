using RoverDirections;
using System;
using Xunit;

namespace RoverDirectionsTests
{
    public class RoverDirectionFixature
    {
        [Fact]
        public void Test_For_Only_Direction_Left()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.North), "LLLLL");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,0,W", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Only_Direction_Right()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.North), "RRRRR");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,0,E", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Only_Movement_North()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.North), "MMM");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,3,N", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Only_Movement_South()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.South), "MMM");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,-3,S", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Only_Movement_West()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.West), "MMM");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("-3,0,W", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Only_Movement_East()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.East), "MMM");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("3,0,E", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Round_Trip_Right()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.North), "MRMRMRMR");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,0,N", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Round_Trip_Left()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.North), "MLMLMLML");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,0,N", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Round_Trip_Left_Initial_South()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.South), "MLMLMLML");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,0,S", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Direction_And_Movement_1()
        {
            Solution solution = new Solution(new Coordinates(0, 1, Direction.East), "MML");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("2,1,N", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Direction_And_Movement_2()
        {
            Solution solution = new Solution(new Coordinates(10, 5, Direction.North), "MMLMRMML");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("9,9,W", coordinates.X.ToString() + "," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Direction_And_Movement_3()
        {
            Solution solution = new Solution(new Coordinates(0, 0, Direction.North), "MMRMRMRMMLMLM");
            Coordinates coordinates = solution.GetFinalCoordinates();
            Assert.Equal("0,0,E", coordinates.X.ToString()+"," + coordinates.Y.ToString() + "," + coordinates.direction.ToString()[0]);
        }
    }
}
