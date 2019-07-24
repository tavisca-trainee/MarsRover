using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Compass
    {
        private Dictionary<char, int> _move = new Dictionary<char, int>()
        {
            {'L', -1 },
            {'R', 1 }
        };
        private readonly Dictionary<char, int> _directionToIndexMap = new Dictionary<char, int>
        {
            { 'N', 0 },
            { 'E', 1 },
            { 'S', 2 },
            { 'W', 3 }
        };
        private readonly Dictionary<int, char> _indexToDirectionMap = new Dictionary<int, char>
        {
            { 0, 'N' },
            { 1, 'E' },
            { 2, 'S' },
            { 3, 'W' }
        };
        public char Direction { get; set; }

        public void Turn(char turn)
        {
            int directionIndexAfterTurning =
                GetCurrentDirectionIndex() + _move[turn];

            MapIndexInTheRange0To3(ref directionIndexAfterTurning);

            ChangeToDirectionAtNewIndex(directionIndexAfterTurning);
        }

        private void MapIndexInTheRange0To3(ref int directionIndexAfterTurning)
        {
            if (directionIndexAfterTurning < 0)
            {
                directionIndexAfterTurning += 4;
                return;
            }

            if (directionIndexAfterTurning > 3)
            {
                directionIndexAfterTurning -= 4;
            }

            return;
        }

        private void ChangeToDirectionAtNewIndex(int directionIndexAfterTurning)
        {
            this.Direction = _indexToDirectionMap[directionIndexAfterTurning];
        }

        private int GetCurrentDirectionIndex()
        {
            return _directionToIndexMap[this.Direction];
        }
    }
}
