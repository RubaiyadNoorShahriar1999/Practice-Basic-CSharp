using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class SpeacialCurrent : Account
    {
        private double minBalance;

        public double MinBalance
        {
            get { return minBalance; }
            set { minBalance = value; }
        }

        private double grandTotal;
   
        public SpeacialCurrent(double balance)
        {
            minBalance = balance * .10;
        }

        public double GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }

        new public bool Withdraw(double balance, double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;

                if (balance > minBalance)
                {
                    Console.WriteLine("Withdrawn Amount : {0}", amount);
                    Console.WriteLine("Remained Balance of Account A : {0}", balance);
                    return true;
                }

                else
                {
                    Console.WriteLine("You can not withdaw money more than minimum Balance (10% of your opening balance)");
                    return false;
                }
                
            }
            else
            {
                Console.WriteLine("You don't have enough balance!");
                return false;
            }

        }
        
        
    }
}
