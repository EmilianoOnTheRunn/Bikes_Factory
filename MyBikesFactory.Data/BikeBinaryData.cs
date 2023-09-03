using MyBikesFactory.Business;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public static class BikeBinaryData
    {
        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "Bikes.bin";
        }

        public static List<Bike> Load()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
                return new List<Bike>();

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var bf = new BinaryFormatter();
                return (List<Bike>)bf.Deserialize(stream);
            }
        }

        public static void Save(List<Bike> listOfBikes)
        {
            string filePath = GetFilePath();
            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(stream, listOfBikes);
                stream.Close();
            }
        }
    }
}
