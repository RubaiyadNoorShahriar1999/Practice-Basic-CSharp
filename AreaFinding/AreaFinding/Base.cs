using System;

namespace AreaFinding
{
    class Base
    {
        private static double length;
        private static double width;
        private static double height;
        private static double choose = 0 ;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose your options : \n1)Square Area\n2)Rectangle\n3)Triangle");
            choose = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Length : ");
            length = Convert.ToDouble(Console.ReadLine());

            if (choose == 1 || choose == 2)
            {
                Console.Write("Enter Width : ");
                width = Convert.ToDouble(Console.ReadLine());
            }

            else
            {
                Console.Write("Enter Heigth : ");
                height = Convert.ToDouble(Console.ReadLine());
            }
       
            if (choose == 1)
            {
                Square sqr = new Square();
                sqr.Area(length, width);
            }
            if (choose == 2)
            {
                Rectangle rct = new Rectangle();
                rct.Area(length, width);
            }
            if (choose == 3)
            {
                Triangle tr = new Triangle();
                tr.Area(length, height);
            }
            Console.ReadKey();
        }
    }
}
