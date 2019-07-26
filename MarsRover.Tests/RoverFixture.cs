using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverFixture
    {
        [Theory]
        [InlineData(5, 5, 1, 2, Directions.North, "LMLMLMLMM", 0, 1, Directions.South)]
        [InlineData(5, 5, 3, 3, Directions.East, "MMRMMRMRRM", 4, 2, Directions.West)]
        [InlineData(5, 5, 2, 2, Directions.East, "RMRRMR", 2, 0, Directions.West)]
        [InlineData(4, 4, 4, 0, Directions.SouthEast, "LMRMLLRM", 4, 0, Directions.East)]
        [InlineData(4, 4, 0, 2, Directions.NorthEast, "MMMRMLM", 3, 4, Directions.NorthEast)]
        [InlineData(1, 1, 0, 0, Directions.West, "RRRMLLMLM", 0, 1, Directions.West)]
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
