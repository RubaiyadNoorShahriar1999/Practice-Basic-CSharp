using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumBasic
{
    class Enum
    {
        enum Days                       // a value type user defined datatype
        {                               //enum is a class element, it has to be defined in a class not in a method
            sat,
            sun,
            mon,
            tue,
            wed,
            thurs
        }

        enum Days1                       
        {                               
            sat=200,
            sun,
            mon=1,
            tue,
            wed,
            thurs
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Days.sat); //will return sat 

            Console.WriteLine((int)Days.sat); //will return the value of set

            Console.WriteLine((int)Days1.sat); // will return the value assigned to sat in Days1

            Console.WriteLine((int)Days1.sun); // sun will take the immediate prevoius value and add it by 1

            Console.WriteLine((int)Days1.mon); // will return 1

            Console.WriteLine((int)Days1.tue); //will take the immediate prevoius value and add it by 1 to define itself


            Console.ReadKey();
        }
    }
}
