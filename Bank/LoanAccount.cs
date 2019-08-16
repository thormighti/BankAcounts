using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LoanAccount : Acount
    {
        public LoanAccount(Customers customer, decimal balance,decimal interestRate,DateTime theDate):base(customer,balance,interestRate,theDate)
        {

        }
        public override decimal CalculateInterest()
        {
            if((Customer.Type == CustomerType.individuals && Month <= 3) || (Customer.Type == CustomerType.company && Month <= 2) )
            {
                return 0;
            }
            return Month * InterestRate;
        }
    }
}
