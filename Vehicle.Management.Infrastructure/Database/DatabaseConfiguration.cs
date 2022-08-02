using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Management.Infrastructure.Database
{
    public static class DatabaseConfiguration
    {
        public static IEnumerable<T> GetAllData<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<IEnumerable<T>>(jsonString);
        }

        public static void InsertAllData<T>(IEnumerable<T> accounts, string filePath)
        {
            string jsonString = JsonConvert.SerializeObject(accounts);
            jsonString = jsonString.Replace(@"\", "");

            File.WriteAllText(filePath, jsonString);
        }
    }
}
