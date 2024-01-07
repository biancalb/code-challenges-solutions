using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    class CsharpAgeCounting
    {
        public static void AgeCounting()
        {

            // WebClient client = new WebClient();
            string s = "https://coderbyte.com/api/challenges/json/age-counting";

            using var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, s);
            var response = httpClient.Send(request);
            using var reader = new StreamReader(response.Content.ReadAsStream());
            var responseBody = reader.ReadToEnd();

            JObject jsonObject = JObject.Parse(responseBody);

            var data = (string)jsonObject["data"];
            string[] items = data.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (var item in items)
            {
                if (item.Contains("age="))
                {
                    int age = int.Parse(item.Split('=')[1]);
                    if (age >= 50)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
