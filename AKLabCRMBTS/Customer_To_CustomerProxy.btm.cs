namespace AKLabCRMBTS {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service+Customer", typeof(global::AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service.Customer))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service+AddCustomer", typeof(global::AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service.AddCustomer))]
    public sealed class Customer_To_CustomerProxy : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://AKLabCRM/service"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Customer"" />
  </xsl:template>
  <xsl:template match=""/ns0:Customer"">
    <ns0:AddCustomer>
      <ns0:newCustomer>
        <xsl:if test=""ns0:EmailAddress"">
          <xsl:variable name=""var:v1"" select=""string(ns0:EmailAddress/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v1)='true'"">
            <ns0:EmailAddress>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:EmailAddress>
          </xsl:if>
          <xsl:if test=""string($var:v1)='false'"">
            <ns0:EmailAddress>
              <xsl:value-of select=""ns0:EmailAddress/text()"" />
            </ns0:EmailAddress>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:FirstName"">
          <xsl:variable name=""var:v2"" select=""string(ns0:FirstName/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v2)='true'"">
            <ns0:FirstName>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:FirstName>
          </xsl:if>
          <xsl:if test=""string($var:v2)='false'"">
            <ns0:FirstName>
              <xsl:value-of select=""ns0:FirstName/text()"" />
            </ns0:FirstName>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:LastName"">
          <xsl:variable name=""var:v3"" select=""string(ns0:LastName/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v3)='true'"">
            <ns0:LastName>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:LastName>
          </xsl:if>
          <xsl:if test=""string($var:v3)='false'"">
            <ns0:LastName>
              <xsl:value-of select=""ns0:LastName/text()"" />
            </ns0:LastName>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:MiddleName"">
          <xsl:variable name=""var:v4"" select=""string(ns0:MiddleName/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v4)='true'"">
            <ns0:MiddleName>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:MiddleName>
          </xsl:if>
          <xsl:if test=""string($var:v4)='false'"">
            <ns0:MiddleName>
              <xsl:value-of select=""ns0:MiddleName/text()"" />
            </ns0:MiddleName>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:NamePrefix"">
          <xsl:variable name=""var:v5"" select=""string(ns0:NamePrefix/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v5)='true'"">
            <ns0:NamePrefix>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:NamePrefix>
          </xsl:if>
          <xsl:if test=""string($var:v5)='false'"">
            <ns0:NamePrefix>
              <xsl:value-of select=""ns0:NamePrefix/text()"" />
            </ns0:NamePrefix>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:PhoneNumber"">
          <xsl:variable name=""var:v6"" select=""string(ns0:PhoneNumber/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v6)='true'"">
            <ns0:PhoneNumber>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:PhoneNumber>
          </xsl:if>
          <xsl:if test=""string($var:v6)='false'"">
            <ns0:PhoneNumber>
              <xsl:value-of select=""ns0:PhoneNumber/text()"" />
            </ns0:PhoneNumber>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:PrimaryAddressCity"">
          <xsl:variable name=""var:v7"" select=""string(ns0:PrimaryAddressCity/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v7)='true'"">
            <ns0:PrimaryAddressCity>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:PrimaryAddressCity>
          </xsl:if>
          <xsl:if test=""string($var:v7)='false'"">
            <ns0:PrimaryAddressCity>
              <xsl:value-of select=""ns0:PrimaryAddressCity/text()"" />
            </ns0:PrimaryAddressCity>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:PrimaryAddressPostalCode"">
          <xsl:variable name=""var:v8"" select=""string(ns0:PrimaryAddressPostalCode/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v8)='true'"">
            <ns0:PrimaryAddressPostalCode>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:PrimaryAddressPostalCode>
          </xsl:if>
          <xsl:if test=""string($var:v8)='false'"">
            <ns0:PrimaryAddressPostalCode>
              <xsl:value-of select=""ns0:PrimaryAddressPostalCode/text()"" />
            </ns0:PrimaryAddressPostalCode>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:PrimaryAddressState"">
          <xsl:variable name=""var:v9"" select=""string(ns0:PrimaryAddressState/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v9)='true'"">
            <ns0:PrimaryAddressState>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:PrimaryAddressState>
          </xsl:if>
          <xsl:if test=""string($var:v9)='false'"">
            <ns0:PrimaryAddressState>
              <xsl:value-of select=""ns0:PrimaryAddressState/text()"" />
            </ns0:PrimaryAddressState>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns0:PrimaryAddressStreet"">
          <xsl:variable name=""var:v10"" select=""string(ns0:PrimaryAddressStreet/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v10)='true'"">
            <ns0:PrimaryAddressStreet>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns0:PrimaryAddressStreet>
          </xsl:if>
          <xsl:if test=""string($var:v10)='false'"">
            <ns0:PrimaryAddressStreet>
              <xsl:value-of select=""ns0:PrimaryAddressStreet/text()"" />
            </ns0:PrimaryAddressStreet>
          </xsl:if>
        </xsl:if>
      </ns0:newCustomer>
    </ns0:AddCustomer>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service+Customer";
        
        private const global::AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service.Customer _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service+AddCustomer";
        
        private const global::AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service.AddCustomer _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service+Customer";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AKLabCRMBTS.CrmCustomerProxy_aklabcrm_service+AddCustomer";
                return _TrgSchemas;
            }
        }
    }
}
