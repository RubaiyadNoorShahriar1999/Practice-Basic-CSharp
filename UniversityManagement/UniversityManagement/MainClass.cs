using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int choice;
            string name, id, dob, bloodgroup;

            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your ID : ");
            id = Console.ReadLine();

            Console.WriteLine("Enter your Date of Birth : ");
            dob = Console.ReadLine();

            Console.WriteLine("Enter your Blood Group : ");
            bloodgroup = Console.ReadLine();

            Console.WriteLine("Enter which one you want to see:\n1)Accounts\n2)Managements\n3)Employee\n4)OSA\n5)Faculty\n6)Student");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Accounts ac = new Accounts();
                ac.showInfo(name,id,dob,bloodgroup);
            }
            else if (choice == 2)
            {
                Management mn = new Management();
                mn.showInfo(name, id, dob, bloodgroup);
            }
            else if (choice == 3)
            {
                Employee e = new Employee();
                e.showInfo(name, id, dob, bloodgroup);
            }
            else if (choice == 4)
            {
                OSA osa = new OSA();
                osa.showInfo(name, id, dob, bloodgroup);
            }
            else if (choice == 5)
            {
                Faculty fc = new Faculty();
                Department d1 = new Department();
                fc.showInfo(name, id, dob, bloodgroup);
                d1.showInfo();
            }
            else
            {
                Student st = new Student();
                Department d1 = new Department();
                st.showInfo(name, id, dob, bloodgroup);
                d1.showInfo();
            }

            Console.ReadKey();
        }
    }
}
