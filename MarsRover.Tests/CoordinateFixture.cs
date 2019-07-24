using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class CoordinateFixture
    {
        [Fact]
        public void Check_position_initialization()
        {
            var position = new Position()
            {
                X = 10,
                Y = 20
            };

            position.X.Should().Be(10);
            position.Y.Should().Be(20);
        }

        [Fact]
        public void Check_step_initialization()
        {
            var step = new Step()
            {
                X = 10,
                Y = 20
            };

            step.X.Should().Be(10);
            step.Y.Should().Be(20);
        }
    }
}
