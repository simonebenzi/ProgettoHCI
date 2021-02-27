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
    public partial class PrimaryForm : Form
    {

        private int _lastFormSize;

        public PrimaryForm()
        {
            InitializeComponent();

            this.Resize += new EventHandler(PrimaryForm_Resize);
            _lastFormSize = GetFormArea(this.Size);
        }

        private int GetFormArea(Size size)
        {
            return size.Height * size.Width;
        }

        private void PrimaryForm_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            float scaleFactor = (float)GetFormArea(control.Size) / (float)_lastFormSize;
            ResizeFont(this.Controls, scaleFactor);
            _lastFormSize = GetFormArea(control.Size);
        }

        private void ResizeFont(Control.ControlCollection controls, float scaleFactor)
        {
            foreach (Control c in controls)
            {
                if (c.HasChildren)
                {
                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {
                    if (true)
                    {
                        // scale font
                        c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                    }
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startEx_Click(object sender, EventArgs e)
        {
            startExPage.BringToFront();
        }

        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            initialPage.BringToFront();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f2 = new CreditsForm();
            f2.ShowDialog();
            //this.Close();
        }
    }
}
