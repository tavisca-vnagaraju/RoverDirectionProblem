namespace RoverDirections
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction direction { get; set; }
        public Coordinates(int X,int Y,Direction direction)
        {
            this.X = X;
            this.Y = Y;
            this.direction = direction;
        }

    }
}
