using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace _20200514_jsonUzklausa
{
    class Program
    {
        static void Main(string[] args)
        {
            GautiVeikejus();
            while (true)
            {

            }

        }

        private static async void GautiVeikejus()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 2YwiB3xJ9QVBPIK9KaGD");
            var response = await client.GetAsync("https://the-one-api.herokuapp.com/v1/character");
            var zinute = await response.Content.ReadAsStringAsync();
            VeikejoAtsakymas ats = JsonConvert.DeserializeObject<VeikejoAtsakymas>(zinute);
            foreach (var item in ats.docs)
            {
                Console.WriteLine(item.name + " " + item.race);
            }
        }

        private static async void GautiUZklausa()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://the-one-api.herokuapp.com/v1/book");
            var zinute = await response.Content.ReadAsStringAsync();
            Console.WriteLine(zinute);
            AtsakymasIUzklausa ats = JsonConvert.DeserializeObject<AtsakymasIUzklausa>(zinute);
            string aa;
            aa = "";
        }
    }
}
