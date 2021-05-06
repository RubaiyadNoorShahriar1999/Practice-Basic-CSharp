using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Params
    {

        //params are used to take variable number or arguments in a method parameter

        static void Sum(params int[] x)  //can be only 1 params in i method
        {                                //param structure must contain a 1D array
            int sum = 0 ;
            foreach (int a in x)
            {
                sum += a;
            }
            Console.WriteLine("Total sum : {0}" , sum );
        }

        static void Sum(string name, int id, params string[] course) //additional parameters must be written 
        {                                                            //before params
            Console.WriteLine("The name of the user is : {0}" , name);
            Console.WriteLine("The ID of the user is : {0}" , id);

            foreach (string c in course)
            {
                Console.WriteLine("The name of your course is : {0} ", c);
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 2,3,4,5,6,7};

            Sum(10,30);
            Sum("Rubaiyad", 1, "Artificial Intelligence" , "Web Technologies" , "Advanced .NET");
            Sum(array); //we can pass 1D array to params

            Console.ReadKey();
        }

    }
}
