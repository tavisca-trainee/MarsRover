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
        [InlineData(-1, 7)]
        [InlineData(-2, 6)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        public void Mapping_in_valid_range_test(int input, int expected)
        {
            TurnInstruction.MapIndexToValidRange(ref input);

            input.Should().Be(expected);
        }

        [Theory]
        [InlineData(Directions.E, 'L', Directions.NE)]
        [InlineData(Directions.E, 'R', Directions.SE)]
        [InlineData(Directions.W, 'L', Directions.SW)]
        [InlineData(Directions.W, 'R', Directions.NW)]
        [InlineData(Directions.N, 'L', Directions.NW)]
        [InlineData(Directions.N, 'R', Directions.NE)]
        [InlineData(Directions.S, 'L', Directions.SE)]
        [InlineData(Directions.S, 'R', Directions.SW)]
        public void Valid_move_command_should_turn_rover_test(Directions currentDirection, char command, Directions expectedDirection)
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
