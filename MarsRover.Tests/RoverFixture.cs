using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverFixture
    {
        [Theory]
        [InlineData(5, 5, 1, 2, Directions.N, "LMLMLMLMM", 0, 1, Directions.S)]
        [InlineData(5, 5, 3, 3, Directions.E, "MMRMMRMRRM", 4, 2, Directions.W)]
        [InlineData(5, 5, 2, 2, Directions.E, "RMRRMR", 2, 0, Directions.W)]
        public void Rover_test_final_integration(int mapEndX, int mapEndY, int roverX, int roverY, Directions roverDirection, string roverCommand, int expectedRoverX, int expectedRoverY, Directions expectedRoverDirction)
        {
            var rover = new Rover();
            rover.SetPosition(roverX, roverY);
            rover.SetDirection(roverDirection);
            rover.SetMap(mapEndX, mapEndY);

            rover.Command(roverCommand);

            rover.Position.X.Should().Be(expectedRoverX);
            rover.Position.Y.Should().Be(expectedRoverY);
            rover.Compass.Direction.Should().Be(expectedRoverDirction);
        }
    }
}
