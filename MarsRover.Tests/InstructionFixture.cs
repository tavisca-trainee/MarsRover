using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class InstructionFixture
    {
        [Theory]
        [InlineData('L', 'L')]
        [InlineData('R', 'R')]
        public void Turn_instruction_initialize_test(char feedTurn, char expected)
        {
            var turnInstruction = new TurnInstruction(feedTurn);

            turnInstruction.Direction.Should().Be(expected);
        }
    }
}
