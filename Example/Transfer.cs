using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Example
{
    public class Transfer: Transaction
    {
        public Account SourceAccount { get; set; }
        public Account DestinationAccount { get; set; }

        public override string FullInfo()
        {
            return $"Перевод средств {Name} от {Date} с {SourceAccount.Name} на {DestinationAccount.Name} в сумме {this.Sum}";
        }

        public override string TransactionInfo()
        {
            return $"Перевод средств с {SourceAccount.Name} на {DestinationAccount.Name} в сумме {this.Sum}";
        }
    }
}
