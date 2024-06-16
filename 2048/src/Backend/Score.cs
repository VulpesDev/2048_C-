using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.src.Backend
{
    public class Score
    {
        private static uint score = 0;

        public static uint GetScore()
        {
            return score;
        }

        public static void SetScore( uint newScore )
        {
            score = newScore;
        }

        public static void AddToScore(uint addition)
        {
            score += addition;
        }

        //Database
        private static string connectionString = "Server=localhost;Database=2048_VulpesDev;Uid=root;Pwd=123321;";

        public static void AddHighscore(string playerName, uint score)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO highscores (player_name, score) VALUES (@playerName, @score)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@playerName", playerName);
                command.Parameters.AddWithValue("@score", score);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
