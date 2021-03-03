using System;
using System.Collections.Generic;
using System.Text;

namespace City_Assignment
{
    class Parks
    {
        public string ParkName { get; set; }
        public string ParkSurface { get; set; }

        public Parks(string parkName, string parkSurface)
        {
            ParkName = parkName;
            ParkSurface = parkSurface;
        }
    }
}
