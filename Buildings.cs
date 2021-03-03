using System;
using System.Collections.Generic;
using System.Text;

namespace City_Assignment
{
    class Buildings
    {
        public string BuildingName { get; set; }
        public string BuildingType { get; set; }
        public string BuildingSurface { get; set; }

        public Buildings(string buildingName, string buildingType, string buildingSurface)
        {
            BuildingName = buildingName;
            BuildingType = buildingType;
            BuildingSurface = buildingSurface;
        }
    }
}
