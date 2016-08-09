using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICrmCustomerProxy" in both code and config file together.
[ServiceContract(Namespace = "http://AKLabCRM/service")]
public interface ICrmCustomerProxy
{
    [OperationContract]
    string AddCustomer(Customer newCustomer);
}

[DataContract(Namespace = "http://AKLabCRM/service")]
public class Customer
{
    [DataMember]
    public string NamePrefix { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string MiddleName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public string PrimaryAddressStreet { get; set; }
    [DataMember]
    public string PrimaryAddressCity { get; set; }
    [DataMember]
    public string PrimaryAddressState { get; set; }
    [DataMember]
    public string PrimaryAddressPostalCode { get; set; }
    [DataMember]
    public string PhoneNumber { get; set; }
    [DataMember]
    public string EmailAddress { get; set; }
}

