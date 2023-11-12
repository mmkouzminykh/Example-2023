using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalSum { get; set; }

        public ICollection<PurchaseSale> Operations { get; set; }

        public ICollection<RenewalDetail> RenewalDetails { get; set;}

    }
}
