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
            string apiUrl = "https://localhost:4242/api/HighscoreData/lastten";
            try
            {
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
            return null;
        }

        public async Task<List<Highscore>> GetTopTenScores()
        {
            HttpClient client = new();
            string apiUrl = "https://localhost:4242/api/HighscoreData/topten";

            try
            {
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
            return null;
        }

        public static async Task AddHighscore(string player_name, string scoreStr)
        {
                HttpClient client = new();
                string apiUrl = "https://localhost:4242/api/HighscoreData/add";
                var data = new { PlayerName = player_name, ScoreStr = scoreStr };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    InfoPopup popup = new(
                        "API Success",
                        $"Your score has been submitted!\r\n User: {player_name}\r\nScore: {scoreStr}",
                        "OK"
                        );
                    popup.Show();
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    InfoPopup popup = new(
                        "API error",
                        $"Failed to add highscore." +
                        $"\r\nStatus code: {response.StatusCode}" +
                        $"\r\nResponse content: {responseContent}",
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
