using System;    //They are built in Projects
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 =0 , num2=0;
            //Console.WriteLine("Enter the value of  Number 1: " );
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the value of  Number 2: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //num1 = Convert.ToInt32(Math.Pow(num1 , num2));
            Power();

            Console.ReadKey();
        }

        static void Power()
        {
            int num1 = 0, num2 = 0;
            Console.WriteLine("Enter the value of  Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of  Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            num1 = Convert.ToInt32(Math.Pow(num1, num2));
            Console.WriteLine("Printing {0} {1}", num1, num2);
            //return ;

        }
    }
}
