using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CustomerDetails.Models
{
    public class CustomerHelper
    {
        //Static contructor to ensure customer list is populated
        static CustomerHelper()
        {
            GetCustomer();
        }


        public static void GetCustomer()
        {
            // Create an HttpClient instance
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=json").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var dto = response.Content.ReadAsAsync<CustomerRes>().Result;
                        CustomersList = dto.CustomersShortInfo;
                    }
                    else
                    {
                        throw new Exception(String.Format("Error while retriveing the customers .The status code is {0} and the reason is {1}", response.StatusCode, response.ReasonPhrase));
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("Exception thrown while calling the service");
            }


        }
        //Private Set show that it cannot be set to null / illegal operation
        public static List<CustomerShortInfo> CustomersList { get; private set; }

    }
}