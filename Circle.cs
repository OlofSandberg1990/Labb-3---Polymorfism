using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorfism
{
    public class Circle : Geometry                              
    {
        public double Radius { get; set; }


        public Circle()
        {
            Radius = 4;
        }


        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            Console.WriteLine("Area Circle : " + Math.Round(area, 1));
            return area;
        }
    }
}
