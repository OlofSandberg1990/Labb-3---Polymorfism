﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorfism
{
    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 5;
            Height = 10;
        }

        public override double Area()
        {
            double area = Height * Width;
            Console.WriteLine("Area Rectangle : " + Math.Round(area, 1));
            return area;
        }
    }
}
