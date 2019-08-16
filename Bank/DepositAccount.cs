using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DepositAccount : Acount,IWithdraw<decimal>
    {
        public DepositAccount(Customers customer, decimal balance,decimal interestRate, DateTime theDate): base(customer, balance,interestRate,theDate)
        {

        }
        
        public override decimal CalculateInterest()
        {
            if(Balance < 1000)
            {
                return 0;
            }
            return Month * InterestRate;
        }
        public decimal MakeWithdrawal(decimal amount)
        {
            if(Balance < 0)
            {
                throw new ArgumentException("Hey Brokee have some money in your account please");
            }
            return Balance -= amount;
        }
    }
}
