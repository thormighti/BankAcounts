using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
  abstract class Acount : IDeposit<decimal>       //  all accounts deposit
    {
        Customers customer;
        decimal balance;
        int month;
        decimal interestRate;
        DateTime theDate;
        public Acount(Customers customer, decimal balance,  decimal interestRate, DateTime theDate)
        {
            this.customer = customer;
            this.balance = balance;
           // this.month = month;
            this.interestRate = interestRate;
            this.theDate = theDate;

        }
        public decimal Balance { get { return balance; }
            set { this.balance = value; }
            }
        public decimal InterestRate {
            get { return balance; }
            set { this.balance = value; }
        }
        public int Month {
        get
            {
                return ((DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.theDate.Year * 12 + this.theDate.Month )); // to get the month duration
            }
                }
        public Customers Customer {
            get
            {
                return customer;
            }
            set
            {
                if(customer == null)
                {
                    throw new ArgumentException("We need Customers " + customer);
                }
                this.customer = value;
            }
        }
        public decimal DoDeposits(decimal amount)
        {
           if(amount <= 0)
            {
                throw new ArgumentException("You cant put in nothing bro " + amount);
            }
            return balance += amount;
        }
        public abstract decimal CalculateInterest();
    }
}
