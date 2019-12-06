using System;

namespace RoverDirections
{
    public class MovementRules
    {
        public Coordinates GetCoordinates(Coordinates coordinates,char command)
        {
            if (command.Equals('M'))
            {
                switch (coordinates.direction)
                {
                    case Direction.North:
                        coordinates.Y++;
                        return coordinates;
                    case Direction.South:
                        coordinates.Y--;
                        return coordinates;
                    case Direction.West:
                        coordinates.X--;
                        return coordinates;
                    case Direction.East:
                        coordinates.X++;
                        return coordinates;
                    default:
                        throw new FormatException();
                }
            }
            else
            {
                throw new FormatException();
            }
            
        }
    }
}
