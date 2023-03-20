using System;
namespace marsrover.Models
{
    public class MarsRover
    {
        public int MaxX { get; private set; }
        public int MaxY { get; private set; }

        public MarsRover(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }

        public Rover MoveRover(Rover rover, string commands)
        {
            foreach (char command in commands)
            {
                rover.Move(command);
                if (rover.X < 0 || rover.X > MaxX || rover.Y < 0 || rover.Y > MaxY)
                {
                    throw new ArgumentOutOfRangeException("Rover out of bounds");
                }
            }
            return rover;
        }
    }
}

