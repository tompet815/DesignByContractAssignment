using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractExApp
{
    public class NotEnoughBalanceException : InvalidOperationException
    {
        public NotEnoughBalanceException() {
        }


        public NotEnoughBalanceException(string message) : base(message)
    {
    }

    
    }
}
