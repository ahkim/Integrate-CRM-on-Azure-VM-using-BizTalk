using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.ServiceModel.Description;
using AKLabCRMXrm;
using System.Data.Services;

namespace DynamicsCRM.SvcProxy
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CrmCustomerProxy" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CrmCustomerProxy.svc or CrmCustomerProxy.svc.cs at the Solution Explorer and start debugging.
    public class CrmCustomerProxy : ICrmCustomerProxy
    {
        #region ICrmCustomerProxy Members

        public string AddCustomer(Customer newCustomer)
        {
            OrganizationServiceProxy proxy;
            ClientCredentials creds = new ClientCredentials();
            creds.UserName.UserName = "{your username}";
            creds.UserName.Password = "{your password}";

            Contact newContact;
            Guid newContactId;

            using (proxy = new OrganizationServiceProxy(new Uri("{your crm online uri}"), null, creds, null))
            {
                proxy.ServiceConfiguration.CurrentServiceEndpoint.Behaviors.Add(new ProxyTypesBehavior());

                newContact = new Contact();
                newContact.Salutation = newCustomer.NamePrefix;
                newContact.FirstName = newCustomer.FirstName;
                newContact.MiddleName = newCustomer.MiddleName;
                newContact.LastName = newCustomer.LastName;
                newContact.Address1_Line1 = newCustomer.PrimaryAddressStreet;
                newContact.Address1_City = newCustomer.PrimaryAddressCity;
                newContact.Address1_StateOrProvince = newCustomer.PrimaryAddressState;
                newContact.Address1_PostalCode = newCustomer.PrimaryAddressPostalCode;
                newContact.Telephone1 = newCustomer.PhoneNumber;
                newContact.EMailAddress1 = newCustomer.EmailAddress;

                newContactId = proxy.Create(newContact);

            }

            return newContactId.ToString();
        }
        #endregion
    }
}
