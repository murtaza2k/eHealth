using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace eHealth.DHPO.Schema
{
    public static class XmlUtilities
    {
        public static object DeserializeObjectFromFile(string filePath, Type typeOfObjectToDeserialize)
        {
            object obj = null;

            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeOfObjectToDeserialize);

                obj = serializer.Deserialize(stream);
            }

            return obj;
        }

        public static object DeserializeObjectFromXmlString(string xmlString, Type typeOfObjectToDeserialize)
        {
            object obj = null;

            using (StringReader sr = new StringReader(xmlString))
            {
                XmlSerializer serializer = new XmlSerializer(typeOfObjectToDeserialize);

                obj = serializer.Deserialize(sr);
            }

            return obj;
        }

        public static void SerializeObjectToFile(string filePath, object objectToSerialize, Type typeOfObjectToSerialize)
        {
            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                using (XmlWriter writer = XmlWriter.Create(stream, GetXmlWriterSettings()))
                {
                    XmlSerializer serializer = new XmlSerializer(typeOfObjectToSerialize);

                    XmlSerializerNamespaces objSerializerNamespaces = new XmlSerializerNamespaces();
                    //objSerializerNamespaces.Add("", "");
                    objSerializerNamespaces.Add("xsd", "http://www.eclaimlink.ae/DHD/ValidationSchema/PriorRequest.xsd");

                    serializer.Serialize(writer, objectToSerialize, objSerializerNamespaces);
                    stream.Flush();
                }
            }
        }

        public static string SerializeObjectToXmlString(object objectToSerialize, Type typeOfObjectToSerialize)
        {
            string XmlString;

            using (Utf8StringWriter sr = new Utf8StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sr, GetXmlWriterSettings()))
                {
                    XmlSerializer serializer = new XmlSerializer(typeOfObjectToSerialize);

                    XmlSerializerNamespaces objSerializerNamespaces = new XmlSerializerNamespaces();
                    objSerializerNamespaces.Add("xsd", "http://www.eclaimlink.ae/DHD/ValidationSchema/PriorRequest.xsd");
                    

                    serializer.Serialize(writer, objectToSerialize, objSerializerNamespaces);
                    sr.Flush();
                }     
           
                XmlString = sr.ToString();
            }

            return XmlString;
        }

        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }

        private static XmlWriterSettings GetXmlWriterSettings()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.IndentChars = "\t";
            settings.Indent = true;

            return settings;
        }

        public static byte[] GetFileAsBase64Binary(string inFileName)
        {
            byte[] base64Array = null;

            if (inFileName != "")
            {
                using (StreamReader sr = File.OpenText(inFileName))
                {
                    string xmlContents = sr.ReadToEnd();
                    base64Array = Encoding.UTF8.GetBytes(xmlContents);
                }
            }

            return base64Array;
        }
    }
}
