using _11_APIs_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            Console.WriteLine("DnD 5e API");
            Console.WriteLine("Type the name of the class you would like to search:");
            string index = Console.ReadLine().ToLower();

            HttpResponseMessage response = httpClient.GetAsync($"https://www.dnd5eapi.co/api/classes/{index}").Result;

            if (response.IsSuccessStatusCode)
            {
                // Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine($"Status code 200: {response.StatusCode}");
            }
            else Console.WriteLine("No results");

            CharacterClass characterClass = response.Content.ReadAsAsync<CharacterClass>().Result;

            Console.WriteLine($"{characterClass.Name} uses a d{characterClass.Hit_Die} hit dice.");

            Console.ReadKey();
        }
    }
}
