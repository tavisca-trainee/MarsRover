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
            InstructionProcessor instructionProcessor = new InstructionProcessor();
            instructionProcessor.GetInstructions("LLMRLRMRLRMRRMM");
            instructionProcessor.Instructions.Should().BeEquivalentTo(new List<Instruction>
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
