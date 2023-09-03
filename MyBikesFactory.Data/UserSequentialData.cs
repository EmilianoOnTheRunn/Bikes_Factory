using MyBikesFactory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public static class UserSequentialData
    {
        public const string COLUMN_SEPARATOR = ",";

        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\login.txt";
        }
        public static List<User> Load()
        {
            var listOfUsers = new List<User>();
            string filePath = GetFilePath();

            if (File.Exists(filePath + ".txt"))
            {
                System.IO.File.Move(filePath + ".txt", filePath);
            }

            if (!File.Exists(filePath))
                return listOfUsers;

            string data = File.ReadAllText(filePath);


            string[] lines = data.Split(Environment.NewLine);
            /* lines[0] = "10,Peter Parker"
             */

            foreach (string line in lines)
            {
                string[] lineFields = line.Split(COLUMN_SEPARATOR);
                string username = lineFields[0];
                string password = lineFields[1];
                var user = new User(username, password);
                listOfUsers.Add(user);
            }

            return listOfUsers;
        }
        //public static void Save(List<User> listOfStudents)
        //{
        //    string filePath = GetFileSpath();

        //    var sb = new StringBuilder();
        //    foreach (var user in listOfStudents)
        //    {
        //        if (sb.Length > 0)
        //            sb.AppendLine();

        //        sb.Append(user.Username);
        //        sb.Append(COLUMN_SEPARATOR);
        //        sb.Append(user.Password);
        //    }

        //    File.WriteAllText(filePath, sb.ToString());
        //}
    }
}
