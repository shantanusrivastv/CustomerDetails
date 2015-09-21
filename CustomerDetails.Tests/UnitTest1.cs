using System;

using System.Threading.Tasks;
using NUnit.Framework;
using ServiceStack;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
//using PortaPlus2.API.Data.Models.Porta;
using System.Xml;
using System.Xml.Linq;
using System.Linq;



namespace CustomerDetails.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var client = new JsonServiceClient("http://host:8080/");
            var response = client.Get("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=xml");

            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(response.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();   
            
        }

        [Test]
        public void Test3()
        {
            //var CustomersShortInfo = new List<PortaCustomerShortInfo>();

            //var client = new JsonServiceClient("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=json");
            //var som = client.Get(new CustomerRes());

            //var response = client.Get(new PortaCustomerShortInfo());

            //Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            //using (Stream responseStream = client.Get<Stream>("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=xml"))
            //{
            //        var dto = responseStream.ReadFully()
            //            .FromUtf8Bytes();
                        
                    
            //    }


            // Create an HttpClient instance
            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri("http://test.api.iccnetworks.com/GetCustomersShortInfo/");

            // Usage
            HttpResponseMessage response2 = client2.GetAsync("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=json").Result;
            if (response2.IsSuccessStatusCode)
            {
                var dto = response2.Content.ReadAsAsync<Shantanu.CustomerRes>().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response2.StatusCode, response2.ReasonPhrase);
            }
               
            
           
        }

        [Test]
        public void TestOther()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;  // Blocking call!

           
        }

        [Test]
        public void Test4()
        {
            XmlDocument doc = new XmlDocument();
            string path = @"E:\Assignments\iccnetworks\one.xml";
            //doc.Load(@"E:\Assignments\iccnetworks\one.xml");
            //XElement xmlDoc = XElement.Load(@"E:\Assignments\iccnetworks\one.xml");
            ////string xpath = "PortaCustomerInfoResponse/CustomersShortInfo/";
            //var nodes = from cust in xmlDoc.Descendants("PortaCustomerInfoResponse")
            //            select cust;

            XmlDocument results = new XmlDocument();
            results.Load(path);

            XmlNamespaceManager ns = new XmlNamespaceManager(results.NameTable);
            ns.AddNamespace("ns",
                    "http://halo.com/schemas/custom/users/GetUser_V1");

            string Result = results.SelectSingleNode(
            "//PortaCustomerInfoResponse/ns:CustomersShortInfo/", ns).InnerText;



            
        }




    }

   
}
