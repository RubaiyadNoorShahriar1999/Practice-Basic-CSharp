using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Faculty : CommonClass
    {
        public Faculty()
        {
            Console.WriteLine("Enter your designation : ");
            designation = Console.ReadLine();

        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        new public void showInfo(string name, string id, string dob, string bloodgroup) //Function overriding
        {
            this.Name = name;
            this.Id = id;
            this.Dob = dob;
            this.BloodGroup = bloodgroup;

            base.showInfo(Name, Id, Dob, BloodGroup);
            Console.WriteLine("Designation : {0} ", designation);
        }
        
    }
}
