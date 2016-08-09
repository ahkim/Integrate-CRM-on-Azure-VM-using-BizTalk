namespace SAWaterBTS {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddCustomer", @"Customer", @"AddCustomerResponse"})]
    public sealed class CrmCustomerProxy_sawater_service : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://SAWater/service"" elementFormDefault=""qualified"" targetNamespace=""http://SAWater/service"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AddCustomer"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""newCustomer"" nillable=""true"" type=""tns:Customer"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""Customer"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EmailAddress"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FirstName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""LastName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""MiddleName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""NamePrefix"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PhoneNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PrimaryAddressCity"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PrimaryAddressPostalCode"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PrimaryAddressState"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PrimaryAddressStreet"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Customer"" nillable=""true"" type=""tns:Customer"" />
  <xs:element name=""AddCustomerResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""AddCustomerResult"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CrmCustomerProxy_sawater_service() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "AddCustomer";
                _RootElements[1] = "Customer";
                _RootElements[2] = "AddCustomerResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://SAWater/service",@"AddCustomer")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddCustomer"})]
        public sealed class AddCustomer : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddCustomer() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddCustomer";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://SAWater/service",@"Customer")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Customer"})]
        public sealed class Customer : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Customer() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Customer";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://SAWater/service",@"AddCustomerResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddCustomerResponse"})]
        public sealed class AddCustomerResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddCustomerResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddCustomerResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
