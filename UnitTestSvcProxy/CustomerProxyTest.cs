using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicsCRM.SvcProxy;

namespace UnitTestSvcProxy
{
    [TestClass]
    public class CustomerProxyTest
    {
        [TestMethod]
        public void AddCustomer()
        {
            CrmCustomerProxy proxy = new CrmCustomerProxy();
            Customer customer = new Customer();
            customer.FirstName = "Aaron";
            customer.LastName = "Kim";
            customer.PhoneNumber = "0000000000";
            customer.EmailAddress = "ahkim@ahkim.com";

            string contactId = proxy.AddCustomer(customer);
            System.Diagnostics.Debug.WriteLine("Submitted customer. New contactId retrieved was " + contactId);
        }
    }
}
