using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Bank_Account
    {
        private double balance = 0.0; 
    
        public void Deposit(double money)
        {
            balance += money;
        }
    
       public void GetBalance()
        {
            Console.WriteLine(balance); 
        }
    }

}
