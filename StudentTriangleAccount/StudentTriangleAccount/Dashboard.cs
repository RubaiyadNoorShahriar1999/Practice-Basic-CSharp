using System;

namespace StudentTriangleAccount
{
    class Dashboard
    {
        static void Main(string[] args)
        {
            int choice = 0;

            Console.WriteLine("Enter which on do you want to enter: \n1) Student\n2) Triangle\n3) Account");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Student st = new Student(/*"Rubaiyad" , "19-39541-1", "CSE" , 3.93f*/);
                st.ShowInfo();
            }
            else if (choice == 2)
            {
                Triangle tr = new Triangle( /*2 ,4, 5*/);
                tr.ShowInfo();
                tr.TestTriangle();
            }
            else
            {
                Console.WriteLine("What do you want to do:\n1) Deposite\n2) Withdraw");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1 || choice == 2)
                {
                Account sc = new Account(/*"Hridoy", "3296" , 10000,*/ choice);
                sc.Showdetails();
                }
                else
                {
                    Console.WriteLine("Invalid!");
                }
 
            }
            Console.ReadKey();
        }
    }
}
