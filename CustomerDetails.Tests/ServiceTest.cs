using NUnit.Framework;
using System.Net.Http;

namespace CustomerDetails.Tests
{
    [TestFixture]
    public class ServiceTest
    {
        const int customerCount = 100;

        [Test]
        public void ServiceShouldResultCustomers()
        {
            // Create an HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=json").Result;
                Assert.IsTrue(response.IsSuccessStatusCode);
                var dto = response.Content.ReadAsAsync<CustomerRes>().Result;
                CollectionAssert.IsNotEmpty(dto.CustomersShortInfo);
            }
        }

        [Test]
        public void CustomerCountShouldMacth()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://test.api.iccnetworks.com/GetCustomersShortInfo/j66fc3bc-50fc-47be-ac75-e5ef94767cd1?format=json").Result;
                Assert.IsTrue(response.IsSuccessStatusCode);
                var dto = response.Content.ReadAsAsync<CustomerRes>().Result;
                Assert.AreEqual(customerCount, dto.CustomersShortInfo.Count);
            }
        }





    }


}
