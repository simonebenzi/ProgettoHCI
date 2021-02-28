using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HCI_Project
{
    public class Settings
    {
        // File .ini path
        public const String PATH = "config.ini";

        public enum Lang 
        {
            Italiano,
            English
        }

        // To be used for the correct program operations
        // Dialogues
        public static Lang langSelection = Lang.Italiano;
        public static string[] quit = { "Esci", "Quit" };
        public static string[] home = { "Menu principale", "Main menu" };
        public static string[] newGame = { "Nuovo gioco", "New game" };
        public static string[] reset = { "Reset", "Reset" };
        public static string[] back = { "Indietro", "Back" };
        public static string[] numOp = { "Numero operazioni:", "Number of moves:" };
        public static string[] maxNumOp = { "Numero massimo: ", "Maximum number: " };
        public static string[] startExStr = {"Nuovo gioco", "New Game" };
        public static string[] settingsStr = { "Impostazioni", "Settings" };
        public static string[] creditsStr = { "Credits", "Credits" };
        public static string[] exitStr = { "Esci", "Quit" };
        public static string[] langLabel = { "Lingua", "Language" };
        public static string[] minRowLabel = { "Numero minimo di righe", "Min number of rows" };
        public static string[] maxRowLabel = { "Numero massimo di righe", "Max number of rows" };
        public static string[] minColLabel = { "Numero minimo di colonne", "Min number of columns" };
        public static string[] maxColLabel = { "Numero massimo di colonne", "Max number of columns" };
        public static string[] saveStr = { "Salva", "Save" };
        public static string[] backMenuStr = { "Menu principale", "Main menu" };
        
        // Chosen by the user
        public static int minRows = 3;
        public static int maxRows = 10;
        public static int minCols = 3;
        public static int maxCols = 10;
        public static int maxMoves = 10;

        // To be changed inside the txt file
        public static Color tilesColor = Color.Black;
        public static Color wrongTilesColor = Color.Red;
        public static Color moveTilesColor = Color.Gray;
        public static Color backgroundColor = SystemColors.Control;
        public static Color rectBackgroundColor = Color.White;
    }
}
