﻿using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class MapFixture
    {
        [Fact]
        public void Map_initialization_test()
        {
            var map = new Map()
            {
                StartPosition = new Position() { X = 0, Y = 0},
                EndPosition = new Position() { X = 10, Y = 10}
            };

            map.StartPosition.X.Should().Be(0);
            map.StartPosition.Y.Should().Be(0);
            map.EndPosition.X.Should().Be(10);
            map.EndPosition.Y.Should().Be(10);
        }

        [Theory]
        [InlineData(10, 10, true)]
        [InlineData(0, 0, true)]
        [InlineData(0, 10, true)]
        [InlineData(10, 0, true)]
        [InlineData(-1, 10, false)]
        [InlineData(0, 11, false)]
        [InlineData(11, 10, false)]
        [InlineData(12, -1, false)]
        public void Vicinity_test(int x, int y, bool expected)
        {
            var map = new Map()
            {
                StartPosition = new Position() { X = 0, Y = 0 },
                EndPosition = new Position() { X = 10, Y = 10 }
            };

            map.IsInVicinity(new Position() { X = x, Y = y })
                .Should().Be(expected);
        }
    }
}
