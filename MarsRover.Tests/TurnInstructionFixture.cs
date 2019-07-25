using Xunit;
using FluentAssertions;

namespace MarsRover.Tests
{
    public class TurnInstructionFixture
    {
        [Theory]
        [InlineData('V')]
        [InlineData('Q')]
        [InlineData('E')]
        [InlineData('F')]
        [InlineData('Z')]
        [InlineData('M')]
        [InlineData('O')]
        [InlineData('P')]
        public void Invalid_turn_commands_return_false_test(char command)
        {
            var instruction = new TurnInstruction();
            var rover = new Rover();

            instruction.TryProcessing(command, ref rover)
                .Should().Be(false);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        [InlineData(-1, 3)]
        [InlineData(-2, 2)]
        [InlineData(4, 0)]
        [InlineData(5, 1)]
        public void Mapping_in_range_0_to_3_test(int input, int expected)
        {
            TurnInstruction.MapIndexInTheRange0To3(ref input);

            input.Should().Be(expected);
        }

        [Theory]
        [InlineData('E', 'L', 'N')]
        [InlineData('E', 'R', 'S')]
        [InlineData('W', 'L', 'S')]
        [InlineData('W', 'R', 'N')]
        [InlineData('N', 'L', 'W')]
        [InlineData('N', 'R', 'E')]
        [InlineData('S', 'L', 'E')]
        [InlineData('S', 'R', 'W')]
        public void Valid_move_command_should_turn_rover_test(char currentDirection, char command, char expectedDirection)
        {
            var rover = new Rover()
            {
                Position = new Position() { X = 2, Y = 2 },
                Map = new Map()
                {
                    MinimumCoordinate = new Position { X = 0, Y = 0 },
                    MaximumCoordinate = new Position { X = 10, Y = 10 }
                },
                Compass = new Compass() { Direction = currentDirection }
            };

            var instruction = new TurnInstruction();

            instruction.TryProcessing(command, ref rover)
                .Should().Be(true);

            rover.GetDirection().Should().Be(expectedDirection);
        }
    }
}
