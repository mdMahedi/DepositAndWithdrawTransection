using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    //class Account
    //{
    //    public string accountNumber;
    //    public string customerName;
    //    public double amount=0;

    //    public double AddAmount(double dipositAmount)
    //    {
    //        return amount+dipositAmount;
    //    }
    //    public double SubtractAmount(double dipositAmount)
    //    {
    //        return amount - dipositAmount;
    //    }
    //}

    public class Account
    {

        public string id { get; set; }

        public string name { get; set; }

        public Decimal balance { get; set; }

        public Decimal DepositMoney(Decimal amount)
        {
            balance += amount;
            return balance;
        }

        public Decimal WithdrawMoney(Decimal amount)
        {
        Decimal moneyAfterWithdrawal = balance-amount;

        if(moneyAfterWithdrawal >= 0)
        {
           balance = moneyAfterWithdrawal;
           return balance;
        }
            return amount;
        }
    }
}
