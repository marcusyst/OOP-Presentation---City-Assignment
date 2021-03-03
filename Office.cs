using System;
using System.Collections.Generic;
using System.Text;

namespace City_Assignment
{
    class Office : Buildings
    {

        public string OfficeName { get; set; }
        public string OwnerName { get; set; }

        public Office(string buildingName, string buildingType, string buildingSurface, string officeName, string ownerName) : base(buildingName, buildingType, buildingSurface)
        {
        OfficeName = officeName;
        OwnerName = ownerName;
        }
}
}