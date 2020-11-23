using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab1

{
    class Program
    {
        static void Main(string[] args)
        {
            Account a2 = new SavingsAccount("Ornithin", "45677",25000);         
            a2.transaction(24580);
            Console.WriteLine();
            a2.transaction(2000); 
            a2.transaction(2000);
            a2.transaction(2000);
            a2.transaction(2000);
            a2.transaction(2000); 

            a2.transaction(2000); 
            a2.ShowInfo();
            Console.WriteLine();


            FixedAccount a4 = new FixedAccount("Erthugrul ", "2123", 2020, 15000); 
            a4.transaction(4000);
            a4.ShowInfo();
            Console.WriteLine();

            SpecialSavingsAccount a1 = new SpecialSavingsAccount("Ornithin", "4456", 2000); 
            SpecialSavingsAccount a7 = new SpecialSavingsAccount("Ornithin", "3300", 1500);

            a1.transaction(200);
            a1.transaction(200);
            a1.transaction(200);
            a1.transaction(200);
            a1.transaction(200);
            a1.transaction(200); 

            a7.transaction(450); 
            a1.ShowInfo();
            a7.ShowInfo();
            Console.WriteLine();


            Account a3 = new OverDraftAccount("Juthi ", "346", 10000);  
            a3.transaction(5750);
            a3.ShowInfo();
            Console.WriteLine();

        }
    }
}
