using System;
using marsrover.Enums;
using marsrover.Models;

namespace marsrover
{
    class Program
    {
        public static void Main()
        {
            var instruction = MapInstruction();
            MarsRover marsRover = new MarsRover(Int32.Parse(instruction.Grid[0]), Int32.Parse(instruction.Grid[1]));
            foreach (var r in instruction.Rovers)
            {
                Rover rover = new Rover(Int32.Parse(r.Cordinates[0]), Int32.Parse(r.Cordinates[1]), r.Orientation);
                rover = marsRover.MoveRover(rover, r.Command);
                Console.WriteLine(rover.ToString());
            }
        }

        private static Instruction MapInstruction()
        {
            var ctr = 1;
            var instruction = new Instruction();
            var singleRover = new SingleRover();
            string fileName = @"/Users/oluwaseunafolabi/Documents/Development/marsrovertechchallenge/Resources/test.txt";
            foreach (string line in System.IO.File.ReadLines(fileName))
            {
                if (ctr == 1)
                {
                    instruction.Grid = line.Split(' ');
                }
                else
                {
                    if (ctr % 2 == 0)
                    {
                        // even
                        var cordinates = line.Substring(0, 3);
                        var orientation = line.Substring(4, 1);
                        singleRover.Cordinates = cordinates.Split(' ');
                        singleRover.Orientation = ReturnOrientation(orientation);
                    }
                    else
                    {
                        // odd
                        singleRover.Command = line;
                        instruction.Rovers.Add(singleRover);
                        singleRover = new SingleRover();
                    }
                }
                ctr++;
            }
            return instruction;
        }

        private static Orientation ReturnOrientation(string v)
        {
            if (string.IsNullOrWhiteSpace(v))
                return Orientation.North;

            switch (v)
            {
                case "N":
                    return Orientation.North;
                case "E":
                    return Orientation.East;
                case "S":
                    return Orientation.South;
                case "W":
                    return Orientation.West;
            }
            return Orientation.North;
        }
    }
}
