using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class Fixed : Account
    {
        private int tenureYear = 4 ;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int passedYear;

        public int Passedyear
        {
            get { return passedYear; }
            set { passedYear = value; }
        }


        
        new public bool Withdraw(double balance, double amount)
        {
            if (balance > amount)
            {
                Console.WriteLine("Enter the time passed after your account opening");
                passedYear = Convert.ToInt32(Console.ReadLine());

                if (tenureYear < passedYear)
                {
                    balance = balance - amount;
                    Console.WriteLine("Remained Balance  : {0}", balance);
                    Console.WriteLine("Withdrawn Money: {0}", amount);
                    return true;

                }
                else
                {
                    Console.WriteLine("You can not withdaw money until you reach your tenure year!");
                    return false;
                }
            }
            else
            {

                Console.WriteLine("You don't have enough balance!");
                Console.WriteLine("You can not withdaw money until you reach your tenure year!");
                return false;
            }

        }

        
    }
}
