using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class InstructionProcessor
    {
        public List<Instruction> Instructions { get; set; }

        public InstructionProcessor()
        {
            this.Instructions = new List<Instruction>();
        }

        public void GetInstructions(string instructions)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                Instructions.Add((Instruction)Enum.Parse(typeof(Instruction), instructions[i].ToString()));
            }
        }
    }
}
