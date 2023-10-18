using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Security.Helpers
{
    public class XmlHelper<T> where T : class
    {

        public static string SerializeXmlToString(T model)
        {
            return SerializeXmlToString(model, System.Text.Encoding.UTF8);
        }

        public static string SerializeXmlToString(T model, System.Text.Encoding encoding)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(model.GetType());

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = encoding;
                settings.Indent = true;

                using (StringWriter textWriter = new StringWriter())
                {
                    using (XmlWriter xWriter = XmlWriter.Create(textWriter, settings))
                    {
                        serializer.Serialize(xWriter, model);
                        return textWriter.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool SerializeXmlToStream(T model, Stream stream)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(model.GetType());

                serializer.Serialize(stream, model);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Save xml to a file and returns whether serialization went well or not.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        public static bool SerializeXmlToFile(T model, string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, model);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Save xml to a file and returns whether serialization went well or not.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        public static bool SerializeXmlToFile(T model, string fileName, Encoding encoding)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(fileName, true, encoding))
                {
                    serializer.Serialize(writer, model);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Returns valid instance of target type or null if error occurred during deserialization.
        /// </summary>
        /// <param name="xmlString">Xml definition.</param>
        public static T DeserializeXml(string xmlString)
        {
            if ((string.IsNullOrWhiteSpace(xmlString)))
            {
                return null;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                dynamic settings = new XmlReaderSettings();

                using (StringReader textReader = new StringReader(xmlString))
                {
                    using (XmlReader xReader = XmlReader.Create(textReader, settings))
                    {
                        T value = (T)serializer.Deserialize(xReader);
                        return value;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns valid instance of target type or null if error occurred during deserialization.
        /// </summary>
        /// <param name="xmlStream">Xml definition.</param>
        public static T DeserializeXml(Stream xmlStream)
        {
            if ((xmlStream == null))
            {
                return null;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                T value = (T)serializer.Deserialize(xmlStream);
                return value;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns valid instance of target type or throws exception if error occurred during deserialization.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <exception cref="Exception"></exception>
        public static T DeserializeXmlFromFile(string path)
        {
            T model = null;

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                model = serializer.Deserialize(stream) as T;
            }
            return model;
        }
    }
}
