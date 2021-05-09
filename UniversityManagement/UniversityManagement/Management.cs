using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Management :CommonClass
    {
        public Management()
        {
            Console.WriteLine("Enter your post : ");
            managementPost = Console.ReadLine();
        }
        private string managementPost;

        public string ManagementPost
        {
            get { return managementPost; }
            set { managementPost = value; }
        }

        new public void showInfo(string name, string id, string dob, string bloodgroup) //Function overriding
        {
            this.Name = name;
            this.Id = id;
            this.Dob = dob;
            this.BloodGroup = bloodgroup;

            base.showInfo(Name, Id, Dob, BloodGroup);
            Console.WriteLine("Management Post : {0} ", managementPost);
        }
        
        
    }
}
