using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails.Tests
{

    public class CustomerRes
    {
        public int Balance { get; set; }
        public int CreditLimit { get; set; }
        public int availableBalance { get; set; }
        public List<CustomerShortInfo> CustomersShortInfo { get; set; }
    }
    public class CustomerShortInfo
    {
        public int ICustomer { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime CreationDate { get; set; }        
    }   
}
