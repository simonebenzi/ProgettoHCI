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
            this.BackColor = Config.backgroundColor;

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(workingRectangle.Width/3, workingRectangle.Height/2 - workingRectangle.Height/10);
            versionLabel.Text = Config.versionString[(int)Config.langSelection];
            DevelopedLabel.Text = Config.developers[(int)Config.langSelection];
            UniversityLabel.Text = Config.university[(int)Config.langSelection];
            infoLabel.Text = Config.infoString[(int)Config.langSelection];

            ChangeLabelColor(this.Controls);
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {

        }
        private void ChangeLabelColor(Control.ControlCollection control)
        {
            Color labelColor = new Color();
            float luminance = (float)(Config.backgroundColor.R * 0.299 + Config.backgroundColor.G * 0.587 + Config.backgroundColor.B * 0.114);
            if (luminance/255 > 0.5)
                labelColor = Color.Black;
            else
                labelColor = Color.White;
            foreach (Control label in control)
            {
                ChangeLabelColor(label.Controls);
                if (label is Label)
                    if(label.Name != "DevelopedLabel" && label.Name != "label4" && label.Name != "label5" && label.Name != "UniversityLabel")
                        label.ForeColor = labelColor;
                    else if(label.ForeColor == Config.backgroundColor)
                        label.ForeColor = labelColor;
            }
        }
    }
}
