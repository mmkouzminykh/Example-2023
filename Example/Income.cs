using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Income: Transaction
    {
        public Income(): base() 
        { }
        public Source? Source { get; set; }
        public Account? DestinationAccount { get; set; }

        public override string FullInfo()
        {
            return $"Поступление {Name} от {Date} на {DestinationAccount?.Name} на сумму {this.Sum}";
        }

        public override string TransactionInfo()
        {
            return $"Поступление на {DestinationAccount?.Name} на сумму {this.Sum}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (obj is not Income)
                return false;

            Income income = obj as Income;
            
            if (income.Sum == this.Sum)
                return true;
            return false;
        }

        public static bool operator ==(Income lhs, Income rhs) => lhs.Equals(rhs);

        public static bool operator !=(Income lhs, Income rhs) { return !(lhs == rhs); }



    }
}
