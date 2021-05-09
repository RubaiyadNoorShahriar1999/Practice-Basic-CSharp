using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptBuildingDay1
{
    class Faculty
    {
        string position;
        string name;
        string id;
        string bloodGroup;
        string designation;

        public Faculty(string position, string name , string id, string bloodGroup, string designation ) 
        {
            this.position = position;
            this.name = name;
            this.id = id;
            this.bloodGroup = bloodGroup;
            this.designation = designation;


        }

        public string Position
        {
            set { this.position = value; }
            get { return position; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }

        public string Id
        {
            set { this.id = value; }
            get { return id; }
        }

        public string BloodGroup
        {
            set { this.bloodGroup = value; }
            get { return bloodGroup; }
        }
        public string Designation
        {
            set { this.designation = value; }
            get { return designation; }
        }

        public void showInfo()
        {
            Console.WriteLine("\nThe name of the {0} is : {1}",position, name);
            Console.WriteLine("The ID of the {0} is : {1}", position, id);
            Console.WriteLine("The Blood Group of the {0} is : {1}", position, bloodGroup);
            Console.WriteLine("The designation of the {0} is : {1}",position,designation);
        }
    }
}
