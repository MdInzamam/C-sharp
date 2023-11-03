using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class account
    {
        public int accountBalance = 1000;
        //int accountBalance = 1000;

        //public void setBalance(int Amount)
        //{
        //    accountBalance = Amount;
        //}

        //public void getBalance() {
        //    Console.WriteLine("Your account balance is : " + accountBalance);
        //}
        public int Balance
        {
            set
            {
                accountBalance = value;
            }
            get
            {
                return accountBalance;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account myAccount = new account();
            //myAccount.accountBalance = 100; 
            //myAccount.setBalance(10000);
            //myAccount.getBalance();

            myAccount.Balance = 10000;
            Console.WriteLine("Your account balance is : " + myAccount.Balance);
            Console.ReadLine();
        }
    }
}
