using System;
using System.Collections.Generic;
using System.Text;

namespace Bovie
{
    public class Coordinate
    {
        public int Point { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public override string ToString()
        {
            return Latitude + ", " + Longitude;
        }
    }
}
