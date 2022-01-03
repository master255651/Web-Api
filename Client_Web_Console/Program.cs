using System;
using System.Net.Http;

namespace Client_Web_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            Console.WriteLine("Calling WebApi...");
            var responceTask = client.GetAsync("https://localhost:44395/flights");
            responceTask.Wait();

            if (responceTask.IsCompleted)
            {
                var result = responceTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var messageTask = result.Content.ReadAsStringAsync();
                    messageTask.Wait();
                    Console.WriteLine("All flights: " + messageTask.Result);
                }
            }

        }
    }
}
