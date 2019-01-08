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
using Newtonsoft.Json.Linq;

namespace ToolKit
{

    public class JsonEx
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
                WriteJsonDataToTxt(customers);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private static void WriteJsonDataToTxt(List<Customer> customers)
        {
            string Path = "jsondata.txt";
            //var dataToWriteFile = JsonConvert.SerializeObject(customers);

            using (StreamWriter streamWriter = new StreamWriter(Path, true))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(streamWriter, customers);
            }
        }

        public static List<Customer> ReadJsonDataFromTxt()
        {
            List<Customer> customers = new List<Customer>();

            string Path = "jsondata.txt";

            if (File.Exists(Path))//if file exist
            {
                string json = File.ReadAllText(Path);

                if (json.Any())
                {
                    if (json.Count(c => c == ']') > 1) //For Solve Of "Multiple JSON Root Elements Error"
                    {
                        json = json.Replace("[", "").Replace("]", ",");
                        json = json.Remove(json.Length - 1);
                        json = $"[{json}]";
                    }

                    customers = JsonConvert.DeserializeObject<List<Customer>>(json);//read json data from txt to collection
                }
                else
                {
                    CreateJsonData();
                }
                
            }
            else//if file not exist create a txt and fill with json data with above methods
            {
                CreateJsonData();
            }

            return customers;
        }

    }
}
