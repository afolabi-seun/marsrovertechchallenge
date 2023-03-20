using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace marsrover.Enums
{
    public enum Orientation
    {
        [Display(Name = "N")]
        North,
        [Display(Name = "E")]
        East,
        [Display(Name = "S")]
        South,
        [Display(Name = "W")]
        West
    }
}

