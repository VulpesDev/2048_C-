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
            HttpClient client = new();
                string apiUrl = "https://localhost:4242/api/HighscoreData/lastte";

                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    List<Highscore> lastScores = JsonConvert.DeserializeObject<List<Highscore>>(jsonString);
                    return lastScores;
                }
                else
                {
                    InfoPopup popup = new(
                        "API error",
                        "Failed to retrieve last ten scores: " + response.StatusCode,
                        "OK"
                        );
                    popup.Show();
                    return null;
                }
        }

        public async Task<List<Highscore>> GetTopTenScores()
        {
            HttpClient client = new();
            string apiUrl = "https://localhost:4242/api/HighscoreData/topte";

            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                List<Highscore> topScores = JsonConvert.DeserializeObject<List<Highscore>>(jsonString);
                return topScores;
            }
            else
            {
                InfoPopup popup = new(
                        "API error",
                        "Failed to retrieve top ten scores: " + response.StatusCode,
                        "OK"
                        );
                popup.Show();
                return null;
            }
        }

        public static async Task AddHighscore(string player_name, string scoreStr)
        {
            try
            {
                HttpClient client = new();

                string apiUrl = "https://localhost:4242/api/HighscoreData/ad";

                var data = new { PlayerName = player_name, ScoreStr = scoreStr };

                var json = JsonConvert.SerializeObject(data);

                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Highscore added successfully.");
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    InfoPopup popup = new(
                        "API error",
                        $"Failed to add highscore. Status code: {response.StatusCode}" +
                        $"\nResponse content: {responseContent}",
                        "OK"
                        );
                    popup.Show();
                }
            }
            catch (Exception ex)
            {
                InfoPopup popup = new(
                        "API error",
                        "Unknown error occured! exception: " + ex.Message,
                        "OK"
                        );
                popup.Show();
            }
        }
    }
}
