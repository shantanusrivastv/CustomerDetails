using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerDetails;
using CustomerDetails.Models;

namespace CustomerDetails.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: /Customer/
        public ActionResult Index()
        {
            var cutomers = CustomerHelper.CustomersList;            
            return View(cutomers);
        }

        
        [HttpGet]
        public PartialViewResult GetPartialCustomer(int id = 25369)
        {
            //use Id to return customer
            var customer2 = CustomerHelper.CustomersList.Where(x => x.ICustomer == id).SingleOrDefault();
            return PartialView("_CustomerDetails", customer2);
        }



    }
}
