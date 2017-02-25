using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account savings = new SavingsAccount();
            savings.Deposit().DepositMoney();

            Account checkings = new CheckingsAccount();
            checkings.Deposit().DepositMoney();

            Account fixedDeposit = new FixedDepositAccount();
            fixedDeposit.Deposit().DepositMoney();

            Console.ReadLine();
        }
    }

    abstract class Account
    {
        public abstract IDeposit Deposit();
    }

    class SavingsAccount : Account
    {
        public override IDeposit Deposit()
        {
            return new AnyTimeDeposit(); 
        }
    }

    class CheckingsAccount : Account
    {
        public override IDeposit Deposit()
        {
            return new AnyTimeDeposit();
        }
    }

    class FixedDepositAccount : Account
    {
        public override IDeposit Deposit()
        {
            return new OneTimeDeposit();
        }
    }

    interface IDeposit
    {
        void DepositMoney();
    }

    class AnyTimeDeposit : IDeposit
    {
        public void DepositMoney()
        {
            Console.WriteLine("Money deposited to your Account, no interest.");
        }
    }

    class OneTimeDeposit : IDeposit
    {
        public void DepositMoney()
        {
            Console.WriteLine("Money deposited to your Account for an interest of 10% per year.");
        }
    }

}
