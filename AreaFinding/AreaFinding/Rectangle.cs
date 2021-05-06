using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinding
{
    class Rectangle : Base
    {
        //private double rlength;
        //private double rwidth;

        //public double RectangleLength
        //{
        //    get { return rlength; }
        //    set { this.rlength = value; }
        //}

        //public double RectangleWidth
        //{
        //    get { return rwidth; }
        //    set { this.rwidth = value; }
        //}

        public double Area(double rlength, double rwidth)
        {

            double area;
            area = (rlength * rwidth);
            Console.WriteLine("The area of the Rectangle is : " + area);
            return area;
        }
    }
}
