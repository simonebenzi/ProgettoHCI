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
        public WinForm(bool hasWon)
        {
            InitializeComponent();
            if (hasWon)
                labelWon.Text = Config.winString[(int)Config.langSelection];
            else
                labelWon.Text = Config.loseString[(int)Config.langSelection];
            labelSuggestion.Text = Config.winSuggestion[(int)Config.langSelection];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
