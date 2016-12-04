using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractExApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            Console.WriteLine("The original balance is: " + acc.Balance);
            Console.WriteLine("Depositing 10 ");
            acc.Deposit(10);
            Console.WriteLine("Balance is: "+ acc.Balance);
            Console.WriteLine("Withdrawing 10 ");
            acc.Withdraw(10);
            Console.WriteLine("Balance is: " + acc.Balance);
            Console.WriteLine("Withdrawing 200 ");
            acc.Withdraw(200);
            Console.WriteLine("Balance is: " + acc.Balance);

            Console.ReadLine();
        }
    }
}
