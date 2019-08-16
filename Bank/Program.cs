using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers mycustomer = new Customers("Peter", CustomerType.individuals);
            DepositAccount mydeposit = new DepositAccount(mycustomer, 4000, 2.5m, new DateTime(2019, 01, 23));

            Console.WriteLine(mydeposit.MakeWithdrawal(500m));
            Console.WriteLine(mydeposit.CalculateInterest());
            //Console.WriteLine(DateTime.Now.Month);
            Console.ReadKey();
        }
    }
}
