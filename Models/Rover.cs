using System;
using marsrover.Enums;

namespace marsrover.Models
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Orientation Orientation { get; private set; }

        public Rover(int x, int y, Orientation orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
        }

        public void Move(char command)
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    MoveForward();
                    break;
                default:
                    throw new ArgumentException("Invalid command");
            }
        }

        private void TurnLeft()
        {
            Orientation = Orientation switch
            {
                Orientation.North => Orientation.West,
                Orientation.West => Orientation.South,
                Orientation.South => Orientation.East,
                Orientation.East => Orientation.North,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private void TurnRight()
        {
            Orientation = Orientation switch
            {
                Orientation.North => Orientation.East,
                Orientation.East => Orientation.South,
                Orientation.South => Orientation.West,
                Orientation.West => Orientation.North,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private void MoveForward()
        {
            switch (Orientation)
            {
                case Orientation.North:
                    Y++;
                    break;
                case Orientation.East:
                    X++;
                    break;
                case Orientation.South:
                    Y--;
                    break;
                case Orientation.West:
                    X--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"{X} {Y} {Orientation}";
        }
    }
}

