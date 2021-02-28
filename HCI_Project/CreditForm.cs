﻿using System;
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
    public partial class CreditForm : Form
    {
        private int language = 1;
        private string[] instructionsTitle = {"Istruzioni:","Instructions" };
        private string[] instructions = { @"All'avvio l'applicazione presenta la possibilità di iniziare una nuova partita (pulsante 'Nuova partita'), cambiare le impostazioni (pulsante 'Impostazioni') o abbandonare il gioco (pulsante 'Esci').
Avviando una nuova partita, è possibile iniziare a riempire l'area rettangolare divisa in quadretti utilizzando le figure mostrate a sinistra della schermata.
Selezionare una figura cliccandoci sopra e successivamente cliccare nuovamente all'interno dell'area rettangolare per collocarla dove si è cliccato. Lo scopo del gioco è quello di riempire interamente l'area rettangolare utilizzando un numero di mosse inferiore a quello massimo previsto.
Per fare ciò è possibile ruotare e specchiare le figure selezionate attraverso la tastiera: la pressione del tasto 'r' permette la rotazione, mentre i tasti 'x' e 'y' permettono di specchiare la figura lungo, rispettivamente, l'asse orizzontale e verticale. è inoltre possibile deselezionare la figura selezionata precedentemente attraverso la pressione del tasto 'z' sulla tastiera: questo permette di eliminare figure precedentemente piazzate sull'area semplicemente cliccandoci sopra con il mouse. Ma attenzione, anche questo conta come mossa!
I tasti presenti sotto l'area rettangolare permettono inoltre di annullare l'ultimo inserimento di una figura nell'area (pulsante 'Indietro'), di riavviare la partita in corso (pulsante 'Reset'), di avviare una nuova partita (pulsante 'Nuova partita') e di tornare al Menu principale (pulsante 'Menù').",@"When the application is started, it presents the possibility to start a new game ('New game' button), change the settings ('Settings' button) or quit the game ('Exit' button).
After starting a new game, you can start filling in the rectangular area divided into squares using the figures shown on the left side of the screen.
Select a figure by clicking on it and then click again inside the rectangular area to place it where you clicked.The object of the game is to completely fill the rectangular area using less moves than the maximum allowed.
To do this, it is possible to rotate and mirror the selected figures through the keyboard: pressing the 'r' key allows rotation, while the 'x' and 'y' keys allow you to mirror the figure along the horizontal axis and vertical.it is also possible to deselect the previously selected figure by pressing the 'z' key on the keyboard: this allows you to delete figures previously placed on the area simply by clicking on them with the mouse. But beware, this also counts as a move!
The buttons below the rectangular area allow to cancel the last entry of a figure in the area ('Back' button), to restart the game in progress ('Reset' button), to start a new game('New Game' button) and return to the Main Menu ('Menu' button)." };
        private string[] developers = { "Sviluppato da:", "Developed by:" };
        private string[] university = {"Per l'Università degli Studi di Genova","For the Università degli Studi in Genoa" };

        public CreditForm()
        {
            InitializeComponent();

            Instructions.Text = instructionsTitle[language];
            richTextBox1.Text = instructions[language];
            DevelopedLabel.Text = developers[language];
            UniversityLabel.Text = university[language];
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
