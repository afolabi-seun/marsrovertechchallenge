using System.Collections.Generic;

namespace marsrover.Models
{
    public class Instruction
    {
        public Instruction()
        {
            Rovers = new List<SingleRover>();
        }
        public string[] Grid { get; set; }
        public List<SingleRover> Rovers { get; set; }
    }
}

