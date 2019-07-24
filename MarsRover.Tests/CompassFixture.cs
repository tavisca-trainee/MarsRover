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

        //[Fact]
        //public void Compass_should_be_able_to_change_direction()
        //{
        //    var compass = new Compass(Direction.E);            
        //    compass.Direction.Should().Be(Direction.E);
        //}
    }
}
