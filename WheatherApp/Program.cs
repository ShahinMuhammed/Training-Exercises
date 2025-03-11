using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static async Task Main()
        {
            Console.Write("Enter the city:");
            string city = Console.ReadLine();

            string weatherInformation = await GetWeatherAsync(city);

            Console.WriteLine(weatherInformation);
            Console.WriteLine("Completed...");
        }

        static async Task<string> GetWeatherAsync(string city)
        {
            string apiKey = "61e74b94bc264e95b4e201423250903"; 
            string apiUrl = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return "Error: Unable to fetch weather data. Please check the city name.";
                    }
                }
                catch (Exception e)
                {
                    return $"Error: {e.Message}";
                }
            }
        }
    }
}