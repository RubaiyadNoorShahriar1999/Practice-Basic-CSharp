using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Department
    {
        private string dept;

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        private String batch;

        public String Batch
        {
            get { return batch; }
            set { batch = value; }
        }

        public Department()
        {
            int choice;
            Console.WriteLine("Enter the department: \n1)CSE\n2)EEE\n3)BBA\n4)English");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                dept = "CSE";
            }
            else if(choice == 2)
            {
                dept = "EEE";
            }
            else if(choice == 3)
            {
                dept = "BBA";
            }
            else
            {
                dept = "English";
            }

            Console.WriteLine("Enter batch : ");
            batch = Console.ReadLine();

        }



        public void showInfo()
        {
            Console.WriteLine("Department : {0} ", dept);
            Console.WriteLine("Batch Number : {0} ", batch);
        }
        
        
        
        
    }
}
