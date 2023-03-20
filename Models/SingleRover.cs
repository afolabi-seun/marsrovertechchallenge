using marsrover.Enums;

namespace marsrover.Models
{
    public class SingleRover
    {
        public string[] Cordinates { get; set; }
        public Orientation Orientation { get; set; }
        public string Command { get; set; }
    }
}

