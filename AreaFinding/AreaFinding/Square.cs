using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinding
{
    class Square : Base
    {
        public double Area(double slength , double swidth)
        {
            double area;
            area = (slength * swidth);
            Console.WriteLine("The area of the Square is : " + area);
            return area;
        }
    }
}
