using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class InstructionProcessorFixture
    {
        [Fact]
        public void Instruction_processor_should_be_able_to_receive_instructions()
        {
            Rover rover = new Rover("2 3 E");
            rover.InstructionProcessor.GetInstructions("LLMRLRMRLRMRRMM");
            rover.InstructionProcessor.Instructions.Should().BeEquivalentTo(new List<Instruction>
            {
                Instruction.L,
                Instruction.L,
                Instruction.M,
                Instruction.R,
                Instruction.L,
                Instruction.R,
                Instruction.M,
                Instruction.R,
                Instruction.L,
                Instruction.R,
                Instruction.M,
                Instruction.R,
                Instruction.R,
                Instruction.M,
                Instruction.M
            });
        }
    }
}