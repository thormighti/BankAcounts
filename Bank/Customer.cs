using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customers
    {
        string name;
        CustomerType type;
        public Customers(string name, CustomerType type)
        {
            this.name = name;
            this.type = type;
        }
        public string String {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                this.name = value;
            }
        }
        public CustomerType Type { get; set; }
    }
}
