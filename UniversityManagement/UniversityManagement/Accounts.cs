using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Accounts : CommonClass
    {

        public Accounts()
        {
            Console.WriteLine("Enter Shift : {0}", shift);
            shift = Console.ReadLine();
        }

        private string shift;

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        new public void showInfo(string name, string id, string dob, string bloodgroup) //Function overriding
        {
            this.Name = name;
            this.Id = id;
            this.Dob = dob;
            this.BloodGroup = bloodgroup;

            base.showInfo(Name, Id, Dob, BloodGroup);
            Console.WriteLine("Shift : {0} ", shift);
        }
        
        
    }
}
