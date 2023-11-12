using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class PriceRenewal
    {
        public int Id { get; set; }
        public DateTime RenewalDate { get; set; }
        public string Comment { get; set; }

        public ICollection<RenewalDetail> RenewalDetails { get; set; }

    }
}
