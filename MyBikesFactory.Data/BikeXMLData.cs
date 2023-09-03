using MyBikesFactory.Business;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public static class BikeXMLData
    {
        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "Bike.xml"; // or "\\bike.xml"
        }

        public static List<Bike> Load()
        {
            string filepath = GetFilePath();
            if (!File.Exists(filepath))
            {
                return new List<Bike>();
            }

            string fileContent = File.ReadAllText(filepath);

            if (fileContent == "")
            {
                return new List<Bike>();
            }

            using (var reader = new StringReader(fileContent))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                return (List<Bike>)serializer.Deserialize(reader);
            }
        }

        public static void Save(List<Bike> list)
        {
            string filePath = GetFilePath();
            using (var writer = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                serializer.Serialize(writer, list);
            }
        }
    }
}
