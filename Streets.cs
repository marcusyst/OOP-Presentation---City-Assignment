using System;
using System.Collections.Generic;
using System.Text;

namespace City_Assignment
{
    class Streets
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string StreetType { get; set; }

        public Streets(string streetName, int streetNumber, string streetType)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            StreetType = streetType;
        }
    }
}
