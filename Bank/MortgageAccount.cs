using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MortgageAccount : Acount
    {
        public MortgageAccount(Customers customer, decimal balance, decimal interestRate, DateTime theDate):base(customer,balance,interestRate,theDate)
        {

        }
        public override decimal CalculateInterest()
        {
            decimal result = 0;
            if(Customer.Type == CustomerType.individuals && Month >= 6)
            {
                return 0;
            }
            if(Customer.Type == CustomerType.company && Month >= 12)
            {
                 result = (Month * InterestRate)/2;
            }
            return result;
        }
    }
}
