using Xunit;
using FluentAssertions;

namespace MarsRover.Tests
{
    public class CompassFixture
    {
        [Fact]
        public void Compass_initialization_test()
        {
            var compass = new Compass()
            {
                Direction = Directions.East
            };

            compass.Direction.Should().Be(Directions.East);

        }
    }
}
