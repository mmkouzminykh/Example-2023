using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class TransactionElement
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public decimal Sum { get; set; }

        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;
    }
}
