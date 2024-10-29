using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaLibrary.Helpers
{
    public class JsonFileWriter
    {
       
        public static void WriteCustomerToJson(Dictionary<string, Customer> customers, string jsonFileName)
        {

            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                JsonSerializer.Serialize(outputStream, customers, options);
            }

        }
        //using(FileStream outputStream =File.OpenWrite(jsonFileName))
        //using (FileStream outputStream = File.Create(jsonFileName))
        //{
        //    var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
        //    {
        //        SkipValidation = false,
        //        Indented = true,
        //    });
        //    JsonSerializer.Serialize<Customer[]>(writter, customers.ToArray());
        //}
    }
    //public static void WritetoJson(List<Customer> customers, string jsonFileName)
    //{
    //    //using(FileStream outputStream =File.OpenWrite(jsonFileName))
    //    using (FileStream outputStream = File.Create(jsonFileName))
    //    {
    //        var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
    //        {
    //            SkipValidation = false,
    //            Indented = true,
    //        });
    //        JsonSerializer.Serialize<Customer[]>(writter, customers.ToArray());
    //    }
    //}
}

