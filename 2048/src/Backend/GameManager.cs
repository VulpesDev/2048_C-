using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace _2048.src.Backend
{
    /// <summary>
    /// This is the game state simple class(struct-like)
    /// data, it's going to be serialized and saved in a file
    /// for later de-serialization for it to be loaded
    /// </summary>
    public class GameState
    {
        public int[][] Board { get; set; }
        public uint Score { get; set; }

        public GameState(int[][] board, uint score)
        {
            Board = board;
            Score = score;
        }
    }
    /// <summary>
    /// Manages the game information (when to start or stop the game or game information(save files))
    /// </summary>
    public static class GameManager
    {
        private const string    gameName           = "2048_VulpesDev";
        private const string    savefileName       = "savegame.json";
        private static string   default_info_title = "Game Management Error";
        public static void SaveGameState(GameState gameState)
        {
            string jsonString = JsonSerializer.Serialize(gameState);

            try
            {
                File.WriteAllText(GetSaveFilePath(), jsonString);
            }
            catch (Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                    default_info_title, ex.Message);
            }
        }
        public static GameState LoadGameState()
        {
            string      jsonString = null;
            GameState   gameState  = null;
            string      filePath   = GetSaveFilePath();

            if (!File.Exists(filePath))
                return null;
            jsonString = File.ReadAllText(filePath);
            if (jsonString == null)
                return null;

            try
            {
                gameState = JsonSerializer.Deserialize<GameState>(jsonString);
            }
            catch(Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                        default_info_title, ex.Message);
            }
            return gameState;
        }

        //The save file is saved in appdata in a folder named after the game
        public static string GetSaveFilePath()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gameName);
            try
            {
                Directory.CreateDirectory(folderPath);
            }
            catch(Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                        default_info_title, ex.Message);
            }
            return Path.Combine(folderPath, savefileName);
        }
        public static void StartGame()
        {
            Form        formMenu = Application.OpenForms.OfType<FormMenu>().FirstOrDefault();
            FormGame    game     = new FormGame();

            if (formMenu != null)
            {
                formMenu.Visible = true;
            }
            else
            {
                InfoPopup popup = new InfoPopup(
                        default_info_title,
                        "Error occured! Could not find a running application.");
                return;
            }

            game.Show();
            formMenu.Visible = false;
        }
        public static void DeleteSave()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gameName);
            string filePath   = Path.Combine(folderPath, savefileName);

            try
            {
                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                InfoPopup popup = new InfoPopup(
                        default_info_title, "Couldn't delete file.");
            }
        }
    }
}
