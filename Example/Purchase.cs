using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class PurchaseSale
    {
        public int Id { get; set; }
        public bool IsPurchase { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Sum { get; set; }

        public int PropertyId {  get; set; }
        public Property Property { get; set; }

        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; }
    }
}
