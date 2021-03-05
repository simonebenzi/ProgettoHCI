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

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(workingRectangle.Width/3, workingRectangle.Height/2 - workingRectangle.Height/10);
            versionLabel.Text = Config.versionString[(int)Config.langSelection];
            DevelopedLabel.Text = Config.developers[(int)Config.langSelection];
            UniversityLabel.Text = Config.university[(int)Config.langSelection];
            infoLabel.Text = Config.infoString[(int)Config.langSelection];
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
