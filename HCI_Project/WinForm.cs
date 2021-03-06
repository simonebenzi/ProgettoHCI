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
            this.BackColor = Config.backgroundColor;
            if (hasWon)
                labelWon.Text = Config.winString[(int)Config.langSelection];
            else
                labelWon.Text = Config.loseString[(int)Config.langSelection];
            labelSuggestion.Text = Config.winSuggestion[(int)Config.langSelection];

            ChangeLabelColor(this.Controls);
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }
        private void ChangeLabelColor(Control.ControlCollection control)
        {
            Color labelColor = new Color();
            float luminance = (float)(Config.backgroundColor.R * 0.299 + Config.backgroundColor.G * 0.587 + Config.backgroundColor.B * 0.114);
            if (luminance / 255 > 0.5)
                labelColor = Color.Black;
            else
                labelColor = Color.White;
            foreach (Control label in control)
            {
                ChangeLabelColor(label.Controls);
                if (label is Label || label.Name == "instructionsTextBox")
                    label.ForeColor = labelColor;
            }
        }
    }
}
