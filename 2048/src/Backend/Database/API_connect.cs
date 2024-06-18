using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _2048.src.Backend.Database
{
    internal class API_connect
    {
        public async Task<List<Highscore>> GetLastTenScores()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://localhost:4242/api/HighscoreData/lastten"; // Replace with your actual API URL

                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    List<Highscore> lastScores = JsonConvert.DeserializeObject<List<Highscore>>(jsonString);
                    return lastScores;
                }
                else
                {
                    Console.WriteLine("Failed to retrieve last ten scores: " + response.StatusCode);
                    return null;
                }
            }
        }
    }
}
