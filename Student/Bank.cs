using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Bank
    {
        double Balance;

        public Bank(double bal)
        {
            Balance = bal;
        }

        public void Deposite(double amt)
        {
             Balance += amt;
            
        }
        public void Withdraw(double amt)
        {
            if (amt < Balance)
            {
                Balance -= amt;
                
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
               
                
            
        }
        public string Print()
        {
            return $"Current Balance={Balance}";
        }


    }
}
