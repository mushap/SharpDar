using Newtonsoft.Json;
using System;
using System.Web;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolKit.Models;
using System.Xml.Serialization;

namespace ToolKit
{

    public static class JsonEx
    {
        //Create a directory if its not exist and write json data to this file
        public static void CreateJsonData()
        {
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 10; i++)
            {
                customers.Add(new Customer
                {
                    CustomerId = i,
                    Name = $"Customer-{i}",
                    OrderNo = 1
                });
            }

            try
            {
                WriteJsonDataToFile(customers);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private static void WriteJsonDataToFile(List<Customer> customers)
        {
            string Path = "jsondata.txt";
            //var dataToWriteFile = JsonConvert.SerializeObject(customers);

            using (StreamWriter _testData = new StreamWriter(Path, true))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(_testData, customers);
            }
        }
    }
}
