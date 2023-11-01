using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorfism
{
    public class Geometry
    {       
        public virtual double Area()
        {
            Console.WriteLine("No figure chosen");
            return 0;
        }
        
    }
}
