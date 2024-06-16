using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace _2048.src.Backend
{
    public class GameState
    {
        public int[][] Board { get; set; }
        public uint Score { get; set; }
    }
    public class GameManager
    {
        private const string gameName = "2048_VulpesDev";
        private const string savefileName = "savegame.json";
        public static void SaveGameState(GameState gameState)
        {
            string jsonString = JsonSerializer.Serialize(gameState);
            File.WriteAllText(GetSaveFilePath(), jsonString);
        }
        public static GameState LoadGameState()
        {
            string filePath = GetSaveFilePath();
            if (!File.Exists(filePath))
                return null;

            string jsonString = File.ReadAllText(filePath);
            GameState gameState = JsonSerializer.Deserialize<GameState>(jsonString);
            return gameState;
        }
        public static string GetSaveFilePath()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gameName);
            Directory.CreateDirectory(folderPath);
            return Path.Combine(folderPath, savefileName);
        }
        public static void StartGame()
        {
            Form formMenu = Application.OpenForms.OfType<FormMenu>().FirstOrDefault();

            if (formMenu != null)
            {
                formMenu.Visible = true;
            }
            else
            {
                MessageBox.Show("Error occured! Could not find a running application.");
            }
            FormGame game = new FormGame();
            game.Show();
            formMenu.Visible = false;
        }
        public static void DeleteSave()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gameName);
            string filePath = Path.Combine(folderPath, savefileName);
            File.Delete(filePath);
        }
    }
}
