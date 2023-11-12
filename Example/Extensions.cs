using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public static class Extensions
    {
        public static string BalanceInfo(this Account account)
        {
            return $"Счет {account.Name} с остатком {account.Balance}";
        }
    }
}
