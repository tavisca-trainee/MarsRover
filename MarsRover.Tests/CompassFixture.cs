using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class CompassFixture
    {
        [Fact]
        public void Compass_should_be_able_to_set_initial_value()
        {
            var compass = new Compass(Direction.E);
            compass.Direction.Should().Be(Direction.E);
        }

        [Fact]
        public void Compass_should_be_able_to_rotate_in_left_direction()
        {
            var rover = new Rover("2 3 W");
            rover.RecieveInstructions("L");
            rover.Compass.Direction.Should().Be(Direction.S);
        }

        [Fact]
        public void Compass_should_be_able_to_rotate_in_right_direction()
        {
            var rover = new Rover("2 3 S");
            rover.RecieveInstructions("R");
            rover.Compass.Direction.Should().Be(Direction.W);
        }
    }
}