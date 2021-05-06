using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptBuildingDay1
{
    class Student
    {
        string position;
        string name;
        string id;
        char section;
        string bloodGroup;

        public Student(string position , string name , string id , char section , string bloodGroup)
        {
            this.position = position;
            this.name = name;
            this.id = id;
            this.section = section;
            this.bloodGroup = bloodGroup;


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

        public char Section
        {
            set { this.section = value; }
            get { return section; }
        }

        public string BloodGroup
        {
            set { this.bloodGroup = value; }
            get { return bloodGroup; }
        }

        public void showInfo()
        {
            Console.WriteLine("\nThe name of the {0} is : {1}", position, name);
            Console.WriteLine("The ID of the {0} is : {1}", position, id);
            Console.WriteLine("The section of the {0} is : {1}", position, section);
            Console.WriteLine("The Blood Group of the {0} is : {1}", position, bloodGroup);
        }
    }
        
}
