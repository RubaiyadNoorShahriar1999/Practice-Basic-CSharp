using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class Account
    {
        double balance;
        double amount;
        int type;
        private bool isTrue;

        public bool IsTrue
        {
            get { return isTrue; }
            set { isTrue = value; }
        }
        
        public double Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }

        public double Amount
        {
            set { this.amount = value; }
            get { return amount; }
        }

        public void Deposite(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Total Balance of Account B : {0}" , balance);
        }

        public bool Withdraw(double balance ,double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("You don't have enough balance!");
                return false;
            }
            else
            {
                balance = balance - amount;
                return true;
            }
        }

        public void Transfer(double amount, Account acc)
        {

            Console.WriteLine("Enter the type of account : \n1)Savings\n2)Special Current\n3)Fixed\n4)Over Draft");
            type = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {
                this.amount = amount;
                Savings s = new Savings();
                IsTrue = s.Withdraw(balance , amount);
                if (IsTrue)
                {
                    acc.Deposite(amount);
                }
            }
            else if (type == 2)
            {
                this.amount = amount;
                SpeacialCurrent sp = new SpeacialCurrent(balance);
                IsTrue = sp.Withdraw(balance , amount);
                if (IsTrue)
                {
                    acc.Deposite(amount);
                }
            }
            else if (type == 3)
            {
                this.amount = amount;
                Fixed f = new Fixed();
                IsTrue = f.Withdraw(balance , amount);
                if (IsTrue)
                {
                    acc.Deposite(amount);
                }
            }
            else
            {
                this.amount = amount;
                OverDraft o = new OverDraft();
                IsTrue = o.Withdraw(balance , amount);
                if (IsTrue)
                {
                    acc.Deposite(amount);
                }
            }

        }

        public void Showdetails()
        {
            Console.WriteLine("--> The amount of your holding account : {0}", balance);
        }

    }
}
