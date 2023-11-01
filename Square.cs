using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorfism
{
    public class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 4.6;
        }

        public override double Area()
        {
            double area = Side * Side;
            Console.WriteLine("Area Square : " + Math.Round(area, 1));
            return area;
        }

    }
}
