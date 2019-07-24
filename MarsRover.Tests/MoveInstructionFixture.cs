using Xunit;
using FluentAssertions;

namespace MarsRover.Tests
{
    public class MoveInstructionFixture
    {
        [Theory]
        [InlineData('V')]
        [InlineData('Q')]
        [InlineData('E')]
        [InlineData('R')]
        [InlineData('Z')]
        [InlineData('L')]
        [InlineData('O')]
        [InlineData('P')]
        public void Invalid_move_commands_return_false_test(char command)
        {
            var instruction = new MoveInstruction();
            var rover = new Rover();

            instruction.TryProcessing(command, ref rover)
                .Should().Be(false);
        }

        [Theory]
        [InlineData('F')]
        [InlineData('M')]
        public void Valid_move_command_should_move_rover_test(char command)
        {
            var rover = new Rover()
            {
                Position = new Position() { X = 2, Y = 2 },
                Map = new Map()
                {
                    StartPosition = new Position { X = 0, Y = 0 },
                    EndPosition = new Position { X = 10, Y = 10 }
                },
                Compass = new Compass() { Direction = 'E'}
            };

            var instruction = new MoveInstruction();

            instruction.TryProcessing(command, ref rover)
                .Should().Be(true);
        }
    }
}
