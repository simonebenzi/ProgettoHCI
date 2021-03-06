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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(workingRectangle.Width / 2, (int)((17f/30f)* workingRectangle.Height));

            this.BackColor = Config.backgroundColor;
            instructionsTextBox.BackColor = Config.backgroundColor;

            helpLabel.Text = Config.instructionsTitle[(int)Config.langSelection];
            instructionsTextBox.Text = Config.instructions[(int)Config.langSelection];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
