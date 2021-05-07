using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class CommonClass
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private string bloodgroup;

        public string BloodGroup
        {
            get { return bloodgroup; }
            set { bloodgroup = value; }
        }

        public void showInfo(string name , string id , string dob , string bloodGroup)
        {
            Console.WriteLine("Name : {0} ", name);
            Console.WriteLine("ID : {0 }" , id);
            Console.WriteLine("Date of Birth : {0} " , dob);
            Console.WriteLine("Blood Group : {0} " , bloodgroup);
        }
        
        
        
    }
}
