using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Model
{
    public static class clsEAuthEnums
    {
        public enum HeaderDispositionFlag
        {

            /// <remarks/>
            TEST,

            /// <remarks/>
            PRODUCTION,
        }

        public enum AuthorizationType
        {

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
        public enum EncounterType
        {

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
        public enum DiagnosisType
        {

            /// <remarks/>
            Principal,

            /// <remarks/>
            Secondary,

            /// <remarks/>
            Admitting,
        }
    }
}
