using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTriangleAccount
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public Triangle(/*int x, int y , int z*/)
        {
            //this.x = x;
            //this.y = y;
            //this.z = z;

            Console.Write("Enter the value of X : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of Y : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of Z : ");
            z = Convert.ToInt32(Console.ReadLine());

        }

        public int X
        {
            set { this.x = value; }
            get { return x; }
        }

        public int Y
        {
            set { this.y = value; }
            get { return y; }
        }

        public int Z
        {
            set { this.z = value; }
            get { return z; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("\n--> The First line of the Triangle is : {0}" , x);

            Console.WriteLine("--> The Second line of the Triangle is : {0}", y);

            Console.WriteLine("--> The  Third line of the Triangle is : {0}", z);
        }

        public void TestTriangle()
        {
            if(x==y && x==z && y==z)
            {
                Console.WriteLine("\nThe Triangle is Equilateral!");
            }
            else if (x == y && x == z || y == x && y == z || z == x && z == y)
            {
                Console.WriteLine("\nThe Triangle is Isoscaeles!");
            }
            else
            {
                Console.WriteLine("\nThe Triangle is Scalene!");
            }
        }
    }
}
