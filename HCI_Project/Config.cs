using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HCI_Project
{
    public class Config
    {
        // File .ini path
        public const String PATH = "config.ini";

        public enum Lang
        {
            Italiano,
            English
        }

        public static Lang langSelection = Lang.Italiano;

        // To be used for the correct program operation dialogues
        // PrimaryForm
        public static string[] quit = { "Esci", "Quit" };
        public static string[] home = { "Menu principale", "Main menu" };
        public static string[] newGame = { "Nuova area", "New area" };
        public static string[] reset = { "Reset", "Reset" };
        public static string[] back = { "Indietro", "Back" };
        public static string[] numOp = { "Numero operazioni:", "Number of moves:" };
        public static string[] maxNumOp = { "Numero massimo: ", "Maximum number: " };
        public static string[] startExStr = { "Inizia", "Start" };
        public static string[] settingsStr = { "Impostazioni", "Settings" };
        public static string[] creditsStr = { "Credits", "Credits" };
        public static string[] exitStr = { "Esci", "Quit" };
        public static string[] langLabel = { "Lingua", "Language" };
        public static string[] minRowLabel = { "Numero minimo di righe", "Min number of rows" };
        public static string[] maxRowLabel = { "Numero massimo di righe", "Max number of rows" };
        public static string[] minColLabel = { "Numero minimo di colonne", "Min number of columns" };
        public static string[] maxColLabel = { "Numero massimo di colonne", "Max number of columns" };
        public static string[] maxMovLabel = { "Numero massimo di mosse", "Max number of moves" };
        public static string[] saveStr = { "Salva", "Save" };
        public static string[] backMenuStr = { "Menu principale", "Main menu" };
        // HelpForm
        public static string[] instructionsTitle = { "Istruzioni:", "Instructions" };
        public static string[] instructions = { @"All'avvio l'applicazione presenta la possibilità di iniziare una nuova partita (pulsante 'Nuova partita'), cambiare le impostazioni (pulsante 'Impostazioni') o abbandonare il gioco (pulsante 'Esci').
Avviando una nuova partita, è possibile iniziare a riempire l'area rettangolare divisa in quadretti utilizzando le figure mostrate a sinistra della schermata.
Selezionare una figura cliccandoci sopra e successivamente cliccare nuovamente all'interno dell'area rettangolare per collocarla dove si è cliccato. Lo scopo del gioco è quello di riempire interamente l'area rettangolare utilizzando un numero di mosse inferiore a quello massimo previsto.
Per fare ciò è possibile ruotare e specchiare le figure selezionate attraverso la tastiera: la pressione del tasto 'r' permette la rotazione, mentre i tasti 'x' e 'y' permettono di specchiare la figura lungo, rispettivamente, l'asse orizzontale e verticale. è inoltre possibile deselezionare la figura selezionata precedentemente attraverso la pressione del tasto 'z' sulla tastiera: questo permette di eliminare figure precedentemente piazzate sull'area semplicemente cliccandoci sopra con il mouse. Ma attenzione, anche questo conta come mossa!
I tasti presenti sotto l'area rettangolare permettono inoltre di annullare l'ultimo inserimento di una figura nell'area (pulsante 'Indietro'), di riavviare la partita in corso (pulsante 'Reset'), di avviare una nuova partita (pulsante 'Nuova partita') e di tornare al Menu principale (pulsante 'Menù').", @"When the application is started, it presents the possibility to start a new game ('New game' button), change the settings ('Settings' button) or quit the game ('Exit' button).
After starting a new game, you can start filling in the rectangular area divided into squares using the figures shown on the left side of the screen.
Select a figure by clicking on it and then click again inside the rectangular area to place it where you clicked.The object of the game is to completely fill the rectangular area using less moves than the maximum allowed.
To do this, it is possible to rotate and mirror the selected figures through the keyboard: pressing the 'r' key allows rotation, while the 'x' and 'y' keys allow you to mirror the figure along the horizontal axis and vertical.it is also possible to deselect the previously selected figure by pressing the 'z' key on the keyboard: this allows you to delete figures previously placed on the area simply by clicking on them with the mouse. But beware, this also counts as a move!
The buttons below the rectangular area allow to cancel the last entry of a figure in the area ('Back' button), to restart the game in progress ('Reset' button), to start a new game('New Game' button) and return to the Main Menu ('Menu' button)." };
        public static string[] developers = { "Sviluppato da:", "Developed by:" };
        public static string[] university = { "Per l'Università degli Studi di Genova", "For the Università degli Studi in Genoa" };
        // WinForm
        public static string[] loseString = { "Hai raggiunto il numero massimo di mosse!", "You have reached the maximum number of moves allowed!" };
        public static string[] winString = { "Hai vinto!", "You Won!" };
        public static string[] winSuggestion = { "Premi il pulsante 'Nuovo gioco' per iniziare una nuova partita", "Press the 'New game' button to start a new game" };

        //CreditForm
        public static string[] versionString = {"Versione 1.0","Version 1.0" };
        public static string[] infoString = { "Sviluppato per Windows 10", "Developed for Windows 10" };

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
