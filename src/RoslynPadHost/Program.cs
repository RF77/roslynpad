using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using RoslynPadLib.Roslyn;


namespace RoslynPadHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.PostAsync(baseAddress + "completion", 
                    new ObjectContent(typeof(RoslynData), new RoslynData()
                    {
                        Offset = 55,
                        Code = "Mein Code"
                    }, new JsonMediaTypeFormatter() )).Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }

        }
    }
}
