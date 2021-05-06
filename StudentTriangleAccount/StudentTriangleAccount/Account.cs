using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTriangleAccount
{
    class Account
    {
        string accountName;
        string accountId;
        //double balance; //needed if balance parameter is passed through the constructor
        double balance = 10000; //needed when balance is not passed through parameteres
        double amount;

        public double CAmount()
        {
            Console.WriteLine("Enter an amount : ");
            amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }



        public Account(/*string accountName, string accountId , double balance,*/ int choice)
        {
            //this.accountName = accountName;
            //this.accountId = accountId;
            //this.balance = balance;


            Console.Write("Enter the name of the account : ");
            accountName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the ID of the account : ");
            accountId = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the balance of the account : ");
            balance = Convert.ToDouble(Console.ReadLine());

            amount = CAmount();

            if (choice == 1)
            {
                Deposite(amount);
            }
            else if(choice == 2)
            {
                Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return accountName; }
        }

        public string AccountId
        {
            set { this.accountId = value; }
            get { return accountId; }
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
        }
        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("You don't have enough balance!");
            }
            else
            {
                balance = balance - amount;
            }
        }

        public void Showdetails()
        {
            Console.WriteLine("--> The name of the account : {0}",accountName );
            Console.WriteLine("--> The Id of the account is : {0}",accountId);
            Console.WriteLine("--> The amount of your holding account : {0}", balance);
        }

    }
}
