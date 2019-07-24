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
                Direction = 'E'
            };

            compass.Direction.Should().Be('E');

        }
    }
}
