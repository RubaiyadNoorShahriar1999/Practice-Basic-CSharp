using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinding
{
    class Triangle
    {
        //private double tlength;
        //private double theigth;

        //public double TriangleLength
        //{
        //    get { return tlength; }
        //    set { this.tlength = value;  }
        //}

        //public double TriangleHeight
        //{
        //    get { return theigth; }
        //    set { this.theigth = value; }
        //}

        public double Area(double tlength, double theigth)
        {
            double area;
            area = 0.5 * (tlength * theigth);
            Console.WriteLine("The area of the Triangle is : " + area);
            return area;
        }
    }
}
