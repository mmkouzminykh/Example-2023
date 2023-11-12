using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Expense: Transaction
    {
        public Destination? Destination { get; set; }

        public Account? SourceAccount { get; set; }

        public override string FullInfo()
        {
            return $"Расход {Name} от {Date} с {SourceAccount?.Name} на сумму {this.Sum}";
        }

        public override string TransactionInfo()
        {
            return $"Расход с {SourceAccount?.Name} на сумму {this.Sum}";
        }
    }
}
