using System;

namespace RoverDirections
{
    public class Solution
    {
        private Coordinates _coordinates;
        private string _command;
        public Solution(Coordinates coordinates,string command)
        {
            _command = command;
            _coordinates = coordinates;
        }
        public Coordinates GetFinalCoordinates()
        {
            MovementRules movementRules = new MovementRules();
            DirectionRules directionRules = new DirectionRules();
            foreach (var item in _command)
            {
                if (item.Equals('M'))
                {
                    _coordinates = movementRules.GetCoordinates(_coordinates, item);
                }
                else if (item.Equals('L') || item.Equals('R'))
                {
                    _coordinates = directionRules.GetCoordinates(_coordinates, item);
                }
            }
            return _coordinates;
        }
    }
}
