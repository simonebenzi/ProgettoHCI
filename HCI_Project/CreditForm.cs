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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();

            Instructions.Text = Config.instructionsTitle[(int)Config.langSelection];
            richTextBox1.Text = Config.instructions[(int)Config.langSelection];
            DevelopedLabel.Text = Config.developers[(int)Config.langSelection];
            UniversityLabel.Text = Config.university[(int)Config.langSelection];
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
