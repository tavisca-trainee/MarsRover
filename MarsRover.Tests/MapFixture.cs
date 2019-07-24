using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class MapFixture
    {
        [Fact]
        public void Map_should_have_valid_dimensions_test()
        {
            Map map = new Map(5, 6);
            map.MaxCoOrdinate.X.Should().Be(5);
            map.MaxCoOrdinate.Y.Should().Be(6);
        }
    }
}