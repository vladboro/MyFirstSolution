using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acct = new BankAccount();
            acct.AccountNegativeEvent += InformNegative;
            acct.AccountNegativeEvent += InformNegative2;
            acct.Deposit(200);
            acct.Withdraw(100);
            acct.Withdraw(70);
            acct.Withdraw(50);
        }


        public static void InformNegative(object sender, BalanceEventArgs e)
        {
            Console.WriteLine("Balance is negative. Current amount is: {0}", e.Balance);
        }

        public static void InformNegative2(object sender, BalanceEventArgs e)
        {
            Console.WriteLine("Balance is negative2. Current amount is: {0}", e.Balance);
        }
    }

    public class BalanceEventArgs : EventArgs
    {
        public int Balance { get; set; }

        public BalanceEventArgs(int balance)
        {
            this.Balance = balance;
        }

    }

    public delegate void InformNegativeEventHandler(object sender, BalanceEventArgs e);

    enum AccountStatus
    {
        OK = 0,
        Negative = 1,
        Closed = 2
    }

    public class BankAccount
    {
        int deposit = 0;

        public event InformNegativeEventHandler AccountNegativeEvent;

        public void Withdraw(int sum)
        {
            deposit -= sum;
            if(deposit < 0)
            {
                if (AccountNegativeEvent != null)
                {
                    BalanceEventArgs e = new BalanceEventArgs(deposit);
                    AccountNegativeEvent(this, e);
                }
            }
        }

        public void Deposit(int sum)
        {
            deposit += sum;
        }

        public int GetDeposit()
        {
            return deposit;
        }
    }
}
