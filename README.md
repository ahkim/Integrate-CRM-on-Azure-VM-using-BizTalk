# Integrate CRM 2015 on Azure VM using BizTalk 2013 R2

### Options

* Soap : Consumes Organization.svc
* REST : Consumes OrganizationData.svc
* Leverage SDK : Creates a proxy on web server using this SDK, Consumes the proxy from BizTalk. 

Last option was selected for test of this project. 

### Some points

* ServiceContract namespace and target namespace at schema must match. Otherwise, you will meet following error.

	Error in deserializing body of request message for operation 'AddCustomer'. OperationFormatter encountered an invalid Message body. Expected to find node type 'Element' with name 'AddCustomer' and namespace 'http://AKLabCRM/service'. Found node type 'Element' with name 'ns0:AddCustomer' and namespace 'http://schema.AKLabCRM.com/Customer'

* See how the service contract and BtsActionMapping works

Message delivered supposed to have a message type

    http://AKLabCRM/service#AddCustomer

BtsActionMapping looks like

	<BtsActionMapping xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  		<Operation Name="AddCustomer" Action="http://AKLabCRM/service/ICrmCustomerProxy/AddCustomer" />
	</BtsActionMapping>

Service contract looks like

	[ServiceContract(Namespace = "http://AKLabCRM/service")]
	public interface ICrmCustomerProxy
	{
    	[OperationContract]
    	string AddCustomer(Customer newCustomer);
	}

