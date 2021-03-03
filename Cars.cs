using System;
using System.Collections.Generic;
using System.Text;

namespace City_Assignment
{
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }
        public int Year { get; set; }

        public Cars(string brand, string model, string color, string plate, int year)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Plate = plate;
            Year = year;
        }
    }
}
