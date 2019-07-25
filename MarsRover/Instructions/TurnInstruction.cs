using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class TurnInstruction: IInstruction
    {
        private static HashSet<char> AllowedTurns { get; } = new HashSet<char>
        {
            'L', 'R'
        };

        private static Dictionary<char, int> _move { get; } = new Dictionary<char, int>()
        {
            {'L', -1 },
            {'R', 1 }
        };

        public bool TryProcessing(char command, ref Rover rover)
        {
            if (IsATurn(command) == false)
            {
                return false;
            }

            Turn(ref rover, command);
            return true;
        }

        private static bool IsATurn(char turn) => AllowedTurns.Contains(turn);

        public static void Turn(ref Rover rover, char turn)
        {
            int indexOfNewDirection =
                GetCurrentDirectionIndex(ref rover) + _move[turn];

            MapIndexToValidRange(ref indexOfNewDirection);

            ChangeToDirectionAtNewIndex(ref rover, indexOfNewDirection);
        }

        public static void MapIndexToValidRange(ref int directionIndexAfterTurning)
        {
            directionIndexAfterTurning += Enum.GetNames(typeof(Directions)).Length;
            directionIndexAfterTurning %= Enum.GetNames(typeof(Directions)).Length;
        }

        private static void ChangeToDirectionAtNewIndex(ref Rover rover, int directionIndexAfterTurning)
        {
            rover.Compass.Direction =
                (Directions)directionIndexAfterTurning;
        }

        private static int GetCurrentDirectionIndex(ref Rover rover)
        {
            return (int)rover.Compass.Direction;
        }
    }
}
