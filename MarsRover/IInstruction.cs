namespace MarsRover
{
    public interface IInstruction
    {
        char Direction { get; }
        bool TryProcessing(char instruction, Rover rover);
    }
}
