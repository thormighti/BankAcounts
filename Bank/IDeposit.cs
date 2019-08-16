using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    interface IDeposit<T>
    {
        decimal DoDeposits(T amount);
    }
}
