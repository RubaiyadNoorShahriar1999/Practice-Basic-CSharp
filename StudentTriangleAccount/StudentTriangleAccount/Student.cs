using System;

namespace StudentTriangleAccount
{
    class Student
    {

        string name;
        string id;
        string department;
        float cgpa;

        public Student( /*string name, string id,string department,float cgpa*/ )
        {
            //this.name = name;
            //this.id = id;
            //this.cgpa = cgpa;
            //this.department = department;

            Console.Write("Enter the Name of the student : ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the ID of the student : ");
            id= Convert.ToString(Console.ReadLine());

            Console.Write("Enter the Department : ");
            department= Convert.ToString(Console.ReadLine());

            Console.Write("Enter the students CGPA : ");
            cgpa = Convert.ToSingle(Console.ReadLine());
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

        public string Department
        {
            set { this.department = value; }
            get { return department; }
        }
        public float Cgpa
        {
            set { this.cgpa = value; }
            get { return cgpa; }
        }


        public void ShowInfo()
        {
            Console.WriteLine("\n--> The name of the Student is : {0}", name);
            Console.WriteLine("--> The ID of the Student is : {0}", id);
            Console.WriteLine("--> The department of the Student is : {0}", department);
            Console.WriteLine("--> The CGPA of the Student is : {0}",cgpa);
        }

    }
}
