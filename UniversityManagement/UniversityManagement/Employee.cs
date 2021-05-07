using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class Employee : CommonClass
    {
        public Employee()
        {
            Console.WriteLine("Enter your post");
            post = Console.ReadLine();

            Console.WriteLine("Enter your Working hours:  ");
            workHour =  Convert.ToInt32(Console.ReadLine());
        }
        private string post;

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        private int workHour;

        public int WorkHour
        {
            get { return workHour; }
            set { workHour = value; }
        }

        new public void showInfo(string name, string id, string dob, string bloodgroup) //Function overriding
        {
            this.Name = name;
            this.Id = id;
            this.Dob = dob;
            this.BloodGroup = bloodgroup;

            base.showInfo(Name, Id, Dob, BloodGroup);
            Console.WriteLine("Post : {0} ", post);
            Console.WriteLine("Working Hours : {0} ", workHour);
        }
        
        
        
    }
}
