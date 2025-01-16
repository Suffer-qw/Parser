using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NOSCHOOLNEEDED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "shool";

            var request = new GetRequest($"https://kitsu.io/api/edge/anime?filter[text]={text}");
            request.Run();

            var response = request.Response;

            var json = JObject.Parse(response);

            var data = json["data"];

            foreach (var item in data)
            {
                var attri = item["attributes"];
                var name = attri["slug"];
                Console.WriteLine($"name = {name}\n");
            }

        }
    }
}
