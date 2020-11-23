using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab1
{
    class FixedAccount : Account
    {
        private int temp = 0;
        public int tenureyear = 2;
        private int openDate;

        public int OpenDate
        {
            get { return openDate; }
            set { openDate = value; }
        }
        DateTime date = DateTime.Now;

        public FixedAccount(string name, string id, int openDate, double balance) : base(name, id, balance)
        {
            this.name = name;
            this.id = id;
            this.openDate = openDate;
            this.balance = balance;
        }
        override public void transaction(double amount)
        {
            int crdate = DateTime.Now.Year;

            if (crdate - this.openDate <= tenureyear)
            {
                Console.WriteLine("Sorry ! Your Account isn't mature enough for transaction....");

            }
            else
            {
                if (amount - this.balance > this.balance)
                {
                    Console.WriteLine("Sorry! Not enough Balance ....");
                }
                else
                {
                    this.balance = this.balance - amount;
                    Console.WriteLine("Transaction Executed....");
                }

            }

        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + " ID :" + id + "  Balance :" + balance);
        }
    }
}


