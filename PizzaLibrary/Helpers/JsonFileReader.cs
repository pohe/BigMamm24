using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaLibrary.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<string, Customer> ReadJson(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<Dictionary<string, Customer>>(indata);
            }
        }

        //public static List<Customer> ReadJson(string jsonFileName)
        //{
        //    using (var jsonFileReader = File.OpenText(jsonFileName))
        //    {
        //        string indata = jsonFileReader.ReadToEnd();
        //        return JsonSerializer.Deserialize<List<Customer>>(indata);
        //    }
        //}

    }
}
