using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace _2048.src.Backend.Database
{
    /// <summary>
    /// This class is used for all the communication with the API,
    /// which in turn communicates with the mySQL database hosted on infinityfree
    /// apiUrl must be the url specified in the HighscoreDataAccess.cs
    /// Here I am also using the InfoPopup.cs form for detailed info
    /// of API actions(on success or general info)
    /// and, if any, errors that occur in the API.
    /// </summary>
    internal static class API_connect
    {
        private static string default_info_title = "API error";

        /// <summary> region GetMethodCalls
        /// This region contains get request
        /// </summary>
        /// <returns>Most of them (all of them for now) List of Highscores (simple class / more like a struct)</returns>

        #region GetMethodCalls
        public static async Task<List<Highscore>> GetLastTenScores()
        {
            List<Highscore> lastScores = null;
            HttpClient      client     = new();
            string          apiUrl     = "https://localhost:4242/api/HighscoreData/lastten";

            try
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    lastScores = JsonConvert.DeserializeObject<List<Highscore>>(jsonString);
                }
                else
                {
                    InfoPopup popup = new InfoPopup(
                        default_info_title,
                        "Failed to retrieve last ten scores: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                        default_info_title,
                        "Unknown error: " + ex.Message);
            }
            return lastScores;
        }

        public static async Task<List<Highscore>> GetTopTenScores()
        {
            List<Highscore> topScores = null;
            HttpClient      client    = new();
            string          apiUrl    = "https://localhost:4242/api/HighscoreData/topten";

            try
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    topScores = JsonConvert.DeserializeObject<List<Highscore>>(jsonString);
                }
                else
                {
                    InfoPopup popup = new InfoPopup(
                        default_info_title,
                        "Failed to retrieve top ten scores: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                        default_info_title,
                        "Unknown error: " + ex.Message);
            }
            return topScores;
        }
        #endregion

        /// <summary> region PostMethodCalls
        /// This region contains post requests
        /// </summary>
        /// <returns>nothing</returns>
        #region PostMethodCalls
        public static async Task AddHighscore(string player_name, string scoreStr)
        {
            HttpClient  client  = new();
            string      apiUrl  = "https://localhost:4242/api/HighscoreData/add";

            var         data    = new { PlayerName = player_name, ScoreStr = scoreStr };
            var         json    = JsonConvert.SerializeObject(data);
            var         content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            
            try
            {
                var response = await client.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    InfoPopup popup = new InfoPopup(
                        default_info_title,
                        $"Your score has been submitted!" +
                        $"\r\n User: {player_name}" +
                        $"\r\nScore: {scoreStr}");
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    InfoPopup popup = new InfoPopup(
                        default_info_title,
                        $"Failed to add highscore." +
                        $"\r\nStatus code: {response.StatusCode}" +
                        $"\r\nResponse content: {responseContent}");
                }
            }
            catch (Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                       default_info_title,
                       "Unknown error: " + ex.Message);
            }
        }
        #endregion
    }
}
