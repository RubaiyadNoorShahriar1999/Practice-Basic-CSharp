using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinding
{
    class Rectangle : Base
    {
        public double Area(double rlength, double rwidth)
        {

            double area;
            area = (rlength * rwidth);
            Console.WriteLine("The area of the Rectangle is : " + area);
            return area;
        }
    }
}
