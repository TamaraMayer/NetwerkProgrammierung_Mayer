using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://fhwnnetworkprog.azurewebsites.net/");


            StudentMessage message = new StudentMessage();
            message.Name = "Tamara Mayer";
            message.Message = "Hi ,this is a Message.";


            var json = JsonSerializer.Serialize(message);
            var data = new StringContent(json, Encoding.UTF8, "application/json");


            var result = await httpClient.PostAsync("api/receiver", data);
            var test = result.StatusCode;
        }
    }
}

