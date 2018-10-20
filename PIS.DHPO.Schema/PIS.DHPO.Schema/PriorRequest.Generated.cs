//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by the XsdToClasses tool.
//     Tool Version:    1.2.23.0
//     Runtime Version: 4.0.30319.17929
//     Generated on:    15/07/2014 12:12:28 PM
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
// Workaround for bug http://lab.msdn.microsoft.com/productfeedback/viewfeedback.aspx?feedbackid=d457a36e-0ce8-4368-9a27-92762860d8e1
#pragma warning disable 1591
namespace eHealth.DHPO.Schema.PriorRequest
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("Prior.Request", Namespace="", IsNullable=false)]
    public partial class PriorRequest {
        
        /// <remarks/>
        public PriorRequestHeader Header;
        
        /// <remarks/>
        public PriorRequestAuthorization Authorization;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestHeader {
        
        /// <remarks/>
        public string SenderID;
        
        /// <remarks/>
        public string ReceiverID;
        
        /// <remarks/>
        public string TransactionDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string RecordCount;
        
        /// <remarks/>
        public HeaderDispositionFlag DispositionFlag;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum HeaderDispositionFlag {
        
        /// <remarks/>
        TEST,
        
        /// <remarks/>
        PRODUCTION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestAuthorization {
        
        /// <remarks/>
        public AuthorizationType Type;
        
        /// <remarks/>
        public string ID;
        
        /// <remarks/>
        public string IDPayer;
        
        /// <remarks/>
        public string MemberID;
        
        /// <remarks/>
        public string PayerID;
        
        /// <remarks/>
        public string EmiratesIDNumber;
        
        /// <remarks/>
        public string DateOrdered;
        
        /// <remarks/>
        public PriorRequestAuthorizationEncounter Encounter;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Diagnosis")]
        public PriorRequestAuthorizationDiagnosisCollection Diagnosis;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Activity")]
        public PriorRequestAuthorizationActivityCollection Activity;
        
        /// <remarks/>
        public PriorRequestAuthorizationResubmission Resubmission;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum AuthorizationType {
        
        /// <remarks/>
        Eligibility,
        
        /// <remarks/>
        Authorization,
        
        /// <remarks/>
        Cancellation,
        
        /// <remarks/>
        Extension,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Status Inquiry")]
        StatusInquiry,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestAuthorizationEncounter {
        
        /// <remarks/>
        public string FacilityID;
        
        /// <remarks/>
        public EncounterType Type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum EncounterType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestAuthorizationDiagnosis {
        
        /// <remarks/>
        public DiagnosisType Type;
        
        /// <remarks/>
        public string Code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum DiagnosisType {
        
        /// <remarks/>
        Principal,
        
        /// <remarks/>
        Secondary,
        
        /// <remarks/>
        Admitting,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestAuthorizationActivity {
        
        /// <remarks/>
        public string ID;
        
        /// <remarks/>
        public string Start;
        
        /// <remarks/>
        public ActivityType Type;
        
        /// <remarks/>
        public string Code;
        
        /// <remarks/>
        public float Quantity;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified;
        
        /// <remarks/>
        public float Net;
        
        /// <remarks/>
        public string Clinician;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Observation")]
        public PriorRequestAuthorizationActivityObservationCollection Observation;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum ActivityType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestAuthorizationActivityObservation {
        
        /// <remarks/>
        public ObservationType Type;
        
        /// <remarks/>
        public string Code;
        
        /// <remarks/>
        public string Value;
        
        /// <remarks/>
        public string ValueType;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum ObservationType {
        
        /// <remarks/>
        LOINC,
        
        /// <remarks/>
        Text,
        
        /// <remarks/>
        File,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Universal Dental")]
        UniversalDental,
        
        /// <remarks/>
        Financial,
        
        /// <remarks/>
        Grouping,
        
        /// <remarks/>
        ERX,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriorRequestAuthorizationResubmission {
        
        /// <remarks/>
        public ResubmissionType Type;
        
        /// <remarks/>
        public string Comment;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Attachment;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="ValidationSchema")]
    public enum ResubmissionType {
        
        /// <remarks/>
        correction,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("internal complaint")]
        internalcomplaint,
        
        /// <remarks/>
        legacy,
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace=null)]
    public partial class PriorRequestAuthorizationDiagnosisCollection : System.Collections.Generic.List<PriorRequestAuthorizationDiagnosis> {
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace=null)]
    public partial class PriorRequestAuthorizationActivityCollection : System.Collections.Generic.List<PriorRequestAuthorizationActivity> {
    }
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace=null)]
    public partial class PriorRequestAuthorizationActivityObservationCollection : System.Collections.Generic.List<PriorRequestAuthorizationActivityObservation> {
    }
}
#pragma warning restore 1591