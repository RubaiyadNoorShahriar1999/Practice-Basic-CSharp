using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class OverDraft : Account
    {
        private double limit = 50000;

        public double Limit
        {
            get { return limit = 50000; }
            set { limit = value; }
        }

        new public bool Withdraw(double balance, double amount)
        {
            balance = balance + limit;

            if (amount < balance)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawn Amount : {0}", amount);
                Console.WriteLine("Remained Balance  : {0}", balance);
                return true;

            }
            else
            {
                Console.WriteLine("You don't have enough balance!");
                return false;
            }

        }
        
    }
}
