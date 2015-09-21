using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDetails.Models
{
    public class CustomerRes
    {
        public int Balance { get; set; }
        public int CreditLimit { get; set; }
        public int availableBalance { get; set; }
        public List<CustomerShortInfo> CustomersShortInfo { get; set; }
    }
}