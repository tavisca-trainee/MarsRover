using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Compass
    {
        internal static Dictionary<char, int> _directionToIndexMap { get; } = new Dictionary<char, int>
        {
            { 'N', 0 },
            { 'E', 1 },
            { 'S', 2 },
            { 'W', 3 }
        };
        internal static Dictionary<int, char> _indexToDirectionMap { get; } = new Dictionary<int, char>
        {
            { 0, 'N' },
            { 1, 'E' },
            { 2, 'S' },
            { 3, 'W' }
        };
        public char Direction { get; set; }
    }
}
