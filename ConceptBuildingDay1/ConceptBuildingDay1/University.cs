using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptBuildingDay1
{
    class University
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Student" , "Rubaiyad" , "19-39541-1" , 'M' , "A+" );
            st1.showInfo();

            Faculty fc1 = new Faculty("Faculty", "Azmayeen" , "2020-40-1" , "A+" , "Assistant Professor");
            fc1.showInfo();

            Console.ReadKey();
        }
    }
}
