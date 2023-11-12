using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class RenewalDetail
    {
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public int PriceRenewalId { get; set; }
        public PriceRenewal PriceRenewal { get; set; }

        public decimal NewPrice { get; set; }
    }
}
