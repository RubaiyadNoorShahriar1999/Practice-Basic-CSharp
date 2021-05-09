using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class Savings : Account
    {
        private double minBalance = 430;

        public double MinBalance
        {
            get { return minBalance; }
            set { minBalance = value; }
        }

         new public bool Withdraw(double balance,double amount)
        {
            if(amount < balance)
            {
                balance = balance - amount;

                if (balance > minBalance)
                {
                    Console.WriteLine("Withdrawn Amount : {0}", amount);
                    Console.WriteLine("Remained Balance in Account A  : {0}" , balance);
                    return true;
                }

                else
                {
                    Console.WriteLine("You can not withdaw money more than minimum Balance 430 Taka!");
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