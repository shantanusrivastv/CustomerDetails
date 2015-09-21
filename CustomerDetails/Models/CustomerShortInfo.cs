using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerDetails.Models
{
    public class CustomerShortInfo
    {
        [Key]
        public int ICustomer { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime CreationDate { get; set; }

    }

}