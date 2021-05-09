using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Student : CommonClass
    {
        private string semester;

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public Student()
        {
            Console.WriteLine("Enter your semster : ");
            semester = Console.ReadLine();
        }

        new public void showInfo(string name, string id, string dob, string bloodgroup) //Function overriding
        {
            this.Name = name;
            this.Id = id;
            this.Dob = dob;
            this.BloodGroup = bloodgroup;

            base.showInfo(Name, Id, Dob, BloodGroup);
            Console.WriteLine("Semester : {0} ", semester);
        }
        
        
    }
}
