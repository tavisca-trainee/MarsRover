using FluentAssertions;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverFixture
    {
        [Fact]
        public void Rover_should_have_valid_intial_co_ordinates()
        {
            Rover rover = new Rover(2,3, Direction.E);
            rover.Position.Should().BeEquivalentTo(new Position { X = 2, Y = 3 });
        }

        [Fact]
        public void Rover_should_be_facing_a_valid_direction()
        {
            Rover rover = new Rover(2, 3, Direction.E);
            rover.Compass.Direction.Should().BeEquivalentTo(Direction.E);
        }

        [Fact]
        public void Rover_should_be_able_to_receive_instructions()
        {
            Rover rover = new Rover(2, 3, Direction.E);

        }
    }
}
