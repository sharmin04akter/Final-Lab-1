using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab1

{
    class OverDraftAccount : Account
    {
        private double overdraft = 0;

        public OverDraftAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }
        override public void transaction(double amount)
        {
            if (amount > balance)
            {
                overdraft = balance * 0.15;
                balance = balance + overdraft;
                if (amount <= balance)
                {
                    this.balance = this.balance - amount;
                    Console.WriteLine("Transaction Executed!!!");
                    Console.WriteLine(name + " has a due of " + overdraft + " Taka");
                }
                else
                    Console.WriteLine("Sorry transaction can't be completed bcz its exceed the limits of loan");
            }
            else
                this.balance = this.balance - amount;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + " ID :" + id + "  Balance :" + balance);
        }
    }
}