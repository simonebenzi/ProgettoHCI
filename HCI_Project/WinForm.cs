using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Project
{
    public partial class WinForm : Form
    {
        private int language = 0;
        private string[] loseString = { "Hai raggiunto il numero massimo di mosse!", "You have reached the maximum number of moves allowed!" };
        private string[] winString = { "Hai vinto!", "You Won!" };
        private string[] winSuggestion = { "Premi il pulsante 'Nuovo gioco' per iniziare una nuova partita", "Press the 'New game' button to start a new game" };
        public WinForm(bool hasWon)
        {
            InitializeComponent();
            if (hasWon)
                labelWon.Text = winString[language];
            else
                labelWon.Text = loseString[language];
            labelSuggestion.Text = winSuggestion[language];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
