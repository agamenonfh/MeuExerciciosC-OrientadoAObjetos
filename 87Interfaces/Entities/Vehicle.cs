using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
