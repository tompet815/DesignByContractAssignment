using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractExApp
{
    public class Account
    {
        public double Balance { get; set; }

        public Account(double balance)
        {
            Balance = balance;
        }
        //should decrease the account’s balance
        public double Deposit(double amount)
        {

            Contract.Requires(amount > 0);
            Contract.Ensures(
            Contract.Result<double>() > Contract.OldValue<double>(Balance)
            );
            Contract.Ensures(
           Contract.Result<double>() == Contract.OldValue<double>(Balance) + amount
           );
            Balance += amount;
            return Balance;
        }

        ////should decrease the account’s balance
        ////Also this amount should be positive. If the amount
        ////exceeds the balance, the  balance should be left untouched and an exception should be thrown
        public double Withdraw(double amount)
        {
            
            Contract.Requires(amount > 0);
            Contract.Ensures(
            Contract.Result<double>() < Contract.OldValue<double>(Balance)
            );
            Contract.EnsuresOnThrow<NotEnoughBalanceException>(
              Contract.OldValue<double>(Balance) == Balance
            );
            Contract.Ensures(
            Contract.Result<double>() == Contract.OldValue<double>(Balance) - amount
            );
            try
            {
                if (Balance < amount)
                {
                    throw new NotEnoughBalanceException("You don't have enough balance!");
                }
                Balance -= amount;
            }
            catch (NotEnoughBalanceException ex) {
                //do nothing
                Console.WriteLine(ex.Message);
            }
            return Balance;
        }

    }
}
