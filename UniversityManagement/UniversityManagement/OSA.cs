using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement
{
    class OSA : CommonClass
    {
        public OSA()
        {
            Console.WriteLine("Enter your room number : ");
            room = Convert.ToInt32(Console.ReadLine());
        }
        private int room;

        public int Room
        {
            get { return room; }
            set { room = value; }
        }

        new public void showInfo(string name, string id, string dob, string bloodgroup) //Function overriding
        {
            this.Name = name;
            this.Id = id;
            this.Dob = dob;
            this.BloodGroup = bloodgroup;

            base.showInfo(Name ,Id ,Dob ,BloodGroup);
            Console.WriteLine("Room Number : {0} " , room);
        }
        
    }
}
