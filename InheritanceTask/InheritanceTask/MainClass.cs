using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class MainClass
    {
        static void Main(string[] args)
        {
            double amount;
            int row, column;

            //Copyright: https://www.w3resource.com/csharp-exercises/for-loop/csharp-for-loop-exercise-75.php  😁
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            

            Console.WriteLine("Enter the amount : ");
            amount = Convert.ToDouble(Console.ReadLine());

            Account acc = new Account();
            Account acc1= new Account();

            acc.Balance = 1000;
            acc1.Balance = 2000;

            acc.Transfer(amount, acc1);

            Console.ReadKey();
        }
    }
}
