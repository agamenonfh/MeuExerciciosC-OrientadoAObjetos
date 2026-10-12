using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        override public string ToString() 
        {
            return $"Color: {Color}, Area: {Area()}";
        }
    }
}
