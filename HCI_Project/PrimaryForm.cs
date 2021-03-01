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
        private IniParser config;

        // Form and font properties to be used for different screen sizes
        private int originalFormSize;
        private float originalFormFont1, originalFormFont2;
        private int originalSquareSize;

        // Game data
        private int[,] squareMatrix; // Representation of the rectangular area
        private int rows = 0; // Actual row number for the current game
        private int columns = 0; // Actual column number for the current game
        private Random rand = new Random();

        // Handling selected figure, rows and columns
        private int figure = 0; // Figure = 0 means no figure is selected
        private int rotation = 0;
        private bool mirrorx = false;
        private bool mirrory = false;

        // Used to know where the mouse is when inside the rectangular area
        private int mouseX = -1;
        private int mouseY = -1;
        private bool isMouseAllowedToClick = false;
        private int move;

        // Handling the win
        private WinForm winForm;
        private bool hasWon;

        public PrimaryForm()
        {
            InitializeComponent();

            // Used to read/modify config.ini or used to create that (if not present)
            config = new IniParser(Settings.PATH);
            InitializeSettings();
            SetLanguage();
            //this.Resize += new EventHandler(PrimaryForm_Resize);
            _lastFormSize = GetFormArea(this.Size);

            // Make the app fullscreen
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
            this.GamePanel.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.BringToFront();

            // Initializing the GamePanel in background
            GamePanel.Visible = false;

            // To resize the fonts every time the form is reshaped,
            // it is computed the size of the form compared to the size of the original
            // form - then the font is scaled appropriately
            this.Resize += new EventHandler(Form1_Resize);
            originalFormSize = GetFormArea(this.Size);
            originalFormFont1 = numMosse.Font.Size;
            originalFormFont2 = maxNumMosse.Font.Size;
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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startEx_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            NewGame();
            GamePanel.BringToFront();
        }

        private void PrimaryForm_Load(object sender, EventArgs e)
        {
            initialPage.BringToFront();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form credit = new CreditForm();
            credit.ShowDialog();
            //this.Close();
        }

        private void itaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (itaCheckBox.Checked)
            {
                engCheckBox.Checked = false;
            }
        }

        private void engCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (engCheckBox.Checked)
            {
                itaCheckBox.Checked = false;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            maxColTxtBox.Text = Settings.maxCols.ToString();
            minColTxtBox.Text = Settings.minCols.ToString();
            minRowTxtBox.Text = Settings.minRows.ToString();
            maxRowTxtBox.Text = Settings.maxRows.ToString();
            settingsPage.BringToFront();
        }

        private void settingReturnBtn_Click(object sender, EventArgs e)
        {
            initialPage.BringToFront();
        }

        private void settingsSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.minRows = Int32.Parse(minRowTxtBox.Text.Substring(0, Math.Min(minRowTxtBox.Text.Length, 2)));
                Settings.maxRows = Int32.Parse(maxRowTxtBox.Text.Substring(0, Math.Min(maxRowTxtBox.Text.Length, 2)));
                Settings.minCols = Int32.Parse(minColTxtBox.Text.Substring(0, Math.Min(minColTxtBox.Text.Length, 2)));
                Settings.maxCols = Int32.Parse(maxColTxtBox.Text.Substring(0, Math.Min(maxColTxtBox.Text.Length, 2)));
                
                
                // Handling user input
                if (Settings.minRows > Settings.maxRows)
                    Settings.minRows = Settings.maxRows;

                if (Settings.minCols > Settings.maxRows)
                    Settings.minCols = Settings.maxCols;

                if (Settings.maxCols >= 30)
                    Settings.maxCols = 30;
                if (Settings.maxRows >= 30)
                    Settings.maxRows = 30;

                config.UpdateSetting("Rows", "minRow", Settings.minRows.ToString());
                config.UpdateSetting("Rows", "maxRow", Settings.maxRows.ToString());
                config.UpdateSetting("Columns", "minCol", Settings.minCols.ToString());
                config.UpdateSetting("Columns", "maxCol", Settings.maxCols.ToString());

                maxColTxtBox.Text = Settings.maxCols.ToString();
                minColTxtBox.Text = Settings.minCols.ToString();
                minRowTxtBox.Text = Settings.minRows.ToString();
                maxRowTxtBox.Text = Settings.maxRows.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserisci un numero!!", "Format Error");
            }

            if (itaCheckBox.Checked)
            {
                Settings.langSelection = Settings.Lang.Italiano;
                config.UpdateSetting("Language", "langSelection", ((int)Settings.Lang.Italiano).ToString());
            }
            else if (engCheckBox.Checked)
            {
                Settings.langSelection = Settings.Lang.English;
                config.UpdateSetting("Language", "langSelection", ((int)Settings.Lang.English).ToString());
            }

            SetLanguage();
        }

        // Initialize setting variables using config file
        private void InitializeSettings()
        {
            int temp = Int32.Parse(config.GetSetting("Language", "langSelection"));
            Settings.langSelection = (Settings.Lang)temp;
            if (Settings.langSelection == Settings.Lang.Italiano)
            {
                itaCheckBox.Checked = true;
                engCheckBox.Checked = false;
            }
            else if (Settings.langSelection == Settings.Lang.English)
            {
                engCheckBox.Checked = true;
                itaCheckBox.Checked = false;
            }
            Settings.minRows = Int32.Parse(config.GetSetting("Rows", "minRow"));
            minRowTxtBox.Text = config.GetSetting("Rows", "minRow");
            Settings.maxRows = Int32.Parse(config.GetSetting("Rows", "maxRow"));
            maxRowTxtBox.Text = config.GetSetting("Rows", "maxRow");
            Settings.minCols = Int32.Parse(config.GetSetting("Columns", "minCol"));
            minColTxtBox.Text = config.GetSetting("Columns", "minCol");
            Settings.maxCols = Int32.Parse(config.GetSetting("Columns", "maxCol"));
            maxColTxtBox.Text = config.GetSetting("Columns", "maxCol");
            Settings.maxMoves = Int32.Parse(config.GetSetting("Moves", "maxMoves"));
            maxMovTxtBtn.Text = config.GetSetting("Moves", "maxMoves");
            // Standardizing all the background colors
            String color = config.GetSetting("Colors", "backgroundColor");
            Settings.backgroundColor = LinkColor(color);
            this.BackColor = Settings.backgroundColor;
            labelNumOp.BackColor = Settings.backgroundColor;
            numMosse.BackColor = Settings.backgroundColor;
            maxNumMosse.BackColor = Settings.backgroundColor;
            MainPanel.BackColor = Settings.backgroundColor;
            MoveLabelPanel.BackColor = Settings.backgroundColor;
            UpperLabelMovePanel.BackColor = Settings.backgroundColor;
            color = config.GetSetting("Colors", "rectBackgroundColor");
            Settings.rectBackgroundColor = LinkColor(color);
            color = config.GetSetting("Colors", "tilesColor");
            Settings.tilesColor = LinkColor(color);
            color = config.GetSetting("Colors", "wrongTilesColor");
            Settings.wrongTilesColor = LinkColor(color);
            color = config.GetSetting("Colors", "moveTilesColor");
            Settings.moveTilesColor = LinkColor(color);
        }

        // Added just some colors, developers can modify this method to add others
        private Color LinkColor(String color)
        {
            if (color == "BLACK")
                return Color.Black;
            else if (color == "RED")
                return Color.Red;
            else if (color == "GRAY")
                return Color.Gray;
            else
                return Color.White;
        }

        // Writing on the labels and the buttons
        private void SetLanguage()
        {
            labelNumOp.Text = Settings.numOp[(int)Settings.langSelection];
            maxNumMosse.Text = Settings.maxNumOp[(int)Settings.langSelection] + Settings.maxMoves.ToString();
            backButton.Text = Settings.back[(int)Settings.langSelection];
            homeButton.Text = Settings.home[(int)Settings.langSelection];
            resetButton.Text = Settings.reset[(int)Settings.langSelection];
            newGameButton.Text = Settings.newGame[(int)Settings.langSelection];
            //quitButton.Text = Settings.quit[(int)Settings.langSelection];
            startEx.Text = Settings.startExStr[(int)Settings.langSelection];
            settings.Text = Settings.settingsStr[(int)Settings.langSelection];
            credits.Text = Settings.creditsStr[(int)Settings.langSelection];
            exit.Text = Settings.exitStr[(int)Settings.langSelection];
            labelLang.Text = Settings.langLabel[(int)Settings.langSelection];
            labelMinRow.Text = Settings.minRowLabel[(int)Settings.langSelection];
            labelMaxRow.Text = Settings.maxRowLabel[(int)Settings.langSelection];
            labelMinCol.Text = Settings.minColLabel[(int)Settings.langSelection];
            labelMaxCol.Text = Settings.maxColLabel[(int)Settings.langSelection];
            settingsSaveBtn.Text = Settings.saveStr[(int)Settings.langSelection];
            settingReturnBtn.Text = Settings.backMenuStr[(int)Settings.langSelection];
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
        }

        private int GetRandomOdd(int min, int max)
        {
            int num = rand.Next(min, max + 1);
            if (num % 2 == 0)
                ++num;
            return num;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // To resize fonts dinamically
            Control control = (Control)sender;

            float fontScaleFactor = (float)GetFormArea(control.Size) / (float)originalFormSize;
            ResizeFont(this.Controls, fontScaleFactor);
        }

        private float Clamp(float x, int a, int b)
        {
            if (x < a)
                return a;
            if (x > b)
                return b;
            return x;
        }

        private void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            float newsizeLab = Clamp(originalFormFont1 * scaleFactor, 3, 45);
            labelNumOp.Font = new Font(labelNumOp.Font.FontFamily.Name, newsizeLab);
            numMosse.Font = new Font(numMosse.Font.FontFamily.Name, newsizeLab);
            float newsizeBut = Clamp(originalFormFont2 * scaleFactor, 3, 15);
            maxNumMosse.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);

            backButton.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            resetButton.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            newGameButton.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            quitButton.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            homeButton.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);

            exit.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            startEx.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            credits.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            settings.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);

            labelLang.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab);
            labelMinRow.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab);
            labelMaxRow.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab);
            labelMinCol.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab);
            labelMaxCol.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab);
            labelMaxMov.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab);
            settingsSaveBtn.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);
            settingReturnBtn.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeBut);

            minRowTxtBox.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab/2);
            maxRowTxtBox.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab/2);
            maxColTxtBox.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab/2);
            minColTxtBox.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab/2);
            maxMovTxtBtn.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab / 2);

            itaCheckBox.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab / 2);
            engCheckBox.Font = new Font(maxNumMosse.Font.FontFamily.Name, newsizeLab / 2);
        }

        // Method to generate the rectangular area to be filled
        private void CreateSquare(int rows, int columns)
        {
            // Creation of the matrix representation of the rectangle
            squareMatrix = new int[rows, columns];

            // The tablelayout part in which the rectangle is is 75% the height
            // and 65% the width of the panel in which it is located
            int screenWidth = Screen.FromControl(this).Bounds.Width; // These commands do not serve any purpose but without them the program does not work properly
            int screenHeight = Screen.FromControl(this).Bounds.Height;
            int tableHeight = (int)(sqAreaPanel.Height * 0.75);
            int tableWidth = (int)(sqAreaPanel.Width * 0.65);

            originalSquareSize = Math.Min((int)(tableHeight / rows), (int)(tableWidth / columns));

            // TableLayoutPanel with double buffer Initialization
            DBLayout panel = new DBLayout();
            //Form1.Controls.Add(panel);
            panel.Name = "RectangleArea";
            panel.RowCount = rows;
            panel.ColumnCount = columns;
            panel.Width = (originalSquareSize + 1) * columns + 1;
            panel.Height = (originalSquareSize + 1) * rows + 1;
            panel.MouseLeave += MouseLeftFromPanel;
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int i = columns; i > 0; i--)
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, originalSquareSize));
            for (int i = rows; i > 0; i--)
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, originalSquareSize));

            sqAreaPanel.Controls.Add(panel);
            sqAreaPanel.Controls.SetChildIndex(panel, 1);
            panel.Anchor = 0;
            int childrenIndex = 0;

            // Generating the Panels which will be used as squares inside the rectangular area
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                {
                    // Initializing the matrix of the rectangle area
                    squareMatrix[row, column] = 0;

                    // Generating the panels
                    Panel p = new Panel();
                    p.MouseEnter += MouseIsHover;
                    p.MouseLeave += MouseIsLeaving;
                    p.MouseClick += MouseClicked;

                    p.Name = "panel" + row + '-' + column;
                    p.BackColor = Settings.rectBackgroundColor;

                    p.Margin = new Padding(0, 0, 0, 0);
                    p.Dock = DockStyle.Fill;
                    panel.Controls.Add(p);
                    panel.Controls.SetChildIndex(p, childrenIndex);
                    childrenIndex++;
                }
        }

        private void MouseLeftFromPanel(object sender, EventArgs e)
        {
            mouseX = -1;
            mouseY = -1;
        }

        private void MouseClicked(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)sender;
            TableLayoutPanel parent = (TableLayoutPanel)p.Parent;

            if (figure != 0 && isMouseAllowedToClick)
            {
                // If a figure has been selected, try to add it to the rectangle
                ClickedFigure(p, parent, mouseY, mouseX);
            }
            else if (figure == 0 && button1x1.Enabled)
            {
                // If not figure has been selected, try to remove the clicked figure from the rectangle
                RemoveFigureWithClick(parent);
            }
        }

        private void RemoveFigureWithClick(TableLayoutPanel parent)
        {
            if (squareMatrix[mouseY, mouseX] != 0)
            {
                int valueOfMatrix = squareMatrix[mouseY, mouseX];
                for (int i = 0; i < columns; i++)
                    for (int j = 0; j < rows; j++)
                        if (squareMatrix[j, i] == valueOfMatrix)
                        {
                            squareMatrix[j, i] = 0;
                            Panel panel = (Panel)parent.Controls.Find("panel" + j.ToString() + '-' + i.ToString(), true)[0];
                            panel.BackColor = Settings.rectBackgroundColor;
                        }
                UpdateMoves();
            }
        }

        private void RemoveLastFigure(TableLayoutPanel parent)
        {
            bool hasBeenRemoved = false;
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                    if (squareMatrix[j, i] == move)
                    {
                        squareMatrix[j, i] = 0;
                        Panel panel = (Panel)parent.Controls.Find("panel" + j.ToString() + '-' + i.ToString(), true)[0];
                        panel.BackColor = Settings.rectBackgroundColor;
                        hasBeenRemoved = true;
                    }
            if (hasBeenRemoved)
            {
                UpdateMoves();
            }
        }

        // This methods is activated after a click on the rectangular area is made
        // It checks whether the selected part of the rectangle already contains
        // a figure, and if it does no figure is added. If instead the part is empty,
        // the figure is added to the rectangle
        private void ClickedFigure(Panel p, TableLayoutPanel parent, int row, int column)
        {
            int[] figureRows = { };
            int[] figureColumns = { };
            switch (figure)
            {
                case 1:
                    figureRows = new int[] { row };
                    figureColumns = new int[] { column };
                    break;
                case 2:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1 };
                    }
                    else
                    {
                        figureRows = new int[] { row, row + 1 };
                        figureColumns = new int[] { column };
                    }
                    break;
                case 3:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1, column + 2 };
                    }
                    else
                    {
                        figureRows = new int[] { row, row + 1, row + 2 };
                        figureColumns = new int[] { column };
                    }
                    break;
                case 4:
                    figureRows = new int[] { row, row + 1 };
                    figureColumns = new int[] { column, column + 1 };
                    break;
                case 5:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row, row + 1, row + 2 };
                        figureColumns = new int[] { column };
                    }
                    else
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1, column + 2 };
                    }
                    break;
                case 6:
                    break;
            }

            int[] figure5position = new int[] { };
            int ro5 = 0; int co5 = 0;
            bool figure5isOver = false;

            if (figure == 5)
            {
                if (rotation % 2 == 0)
                {
                    figure5position = new int[] { 2, 1 };
                    if (mirrorx)
                        figure5position[0] = figure5position[0] == 0 ? 2 : 0;
                    if (mirrory)
                        figure5position[1] = -figure5position[1];
                }
                else
                {
                    figure5position = new int[] { -1, 2 };
                    if (mirrorx)
                        figure5position[0] = -figure5position[0];
                    if (mirrory)
                        figure5position[1] = figure5position[1] == 0 ? 2 : 0;
                }

                ro5 = row + figure5position[0];
                co5 = column + figure5position[1];
                // Check if the last piece is over some part already clicked
                figure5isOver = checkIfClicked(new int[] { ro5 }, new int[] { co5 });
            }

            if (!checkIfClicked(figureRows, figureColumns) && !figure5isOver)
            {
                foreach (int co in figureColumns)
                    foreach (int ro in figureRows)
                    {
                        squareMatrix[ro, co] = move + 1;
                        Panel panel = (Panel)parent.Controls.Find("panel" + ro.ToString() + '-' + co.ToString(), true)[0];
                        panel.BackColor = Settings.tilesColor;
                    }
                if (figure == 5)
                {
                    try
                    {
                        Panel panel = (Panel)parent.Controls.Find("panel" + ro5.ToString() + '-' + co5.ToString(), true)[0];
                        squareMatrix[ro5, co5] = move + 1;
                        panel.BackColor = Settings.tilesColor;
                    }
                    catch
                    {
                        //DeleteFigure(parent, row, column);
                    }
                }
            }
            else
            {
                //DeleteFigure(parent, row, column);
                return;
            }
            // Checking if the rectangle is full
            if (CheckIfWon() && !hasWon)
            {
                // Update the moves counter
                ++move;
                numMosse.Text = move.ToString();
                // Show the winning form
                winForm = new WinForm(true);
                winForm.Show();
                hasWon = true;
                figure = 0;
                // Disable all button with the exception of the Quit and New Game ones
                button1x1.Enabled = false;
                button2x1.Enabled = false;
                button3x1.Enabled = false;
                button2x2.Enabled = false;
                buttonL.Enabled = false;
                resetButton.Enabled = false;
                backButton.Enabled = false;
            }
            else
                UpdateMoves();
        }
        private bool checkIfClicked(int[] figureRows, int[] figureColumns)
        {
            foreach (int co in figureColumns)
                foreach (int ro in figureRows)
                    if (squareMatrix[ro, co] != 0)
                        return true;
            return false;
        }
        private void checkIfMaxMoves()
        {
            if (move >= Settings.maxMoves)
            {
                winForm = new WinForm(false);
                winForm.Show();
                hasWon = true;
                figure = 0;
                // Disable all button with the exception of the Quit and New Game ones
                button1x1.Enabled = false;
                button2x1.Enabled = false;
                button3x1.Enabled = false;
                button2x2.Enabled = false;
                buttonL.Enabled = false;
                resetButton.Enabled = false;
                backButton.Enabled = false;
            }
        }
        private void UpdateMoves()
        {
            ++move;
            numMosse.Text = move.ToString();
            checkIfMaxMoves();
        }
        private void MouseIsHover(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            TableLayoutPanel parent = (TableLayoutPanel)p.Parent;
            int index = parent.Controls.GetChildIndex(p);

            int row = (index / columns);
            int column = index - row * columns;
            mouseX = column;
            mouseY = row;
            if (figure != 0)
            {
                DrawFigure(parent, row, column);
            }
        }
        private void DrawFigure(TableLayoutPanel parent, int row, int column)
        {
            int[] figureRows = { };
            int[] figureColumns = { };
            bool figureIsOver = false;
            bool figureIsOut = false;
            switch (figure)
            {
                case 1:
                    figureRows = new int[] { row };
                    figureColumns = new int[] { column };
                    break;
                case 2:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1 };
                    }
                    else
                    {
                        figureRows = new int[] { row, row + 1 };
                        figureColumns = new int[] { column };
                    }
                    break;
                case 3:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1, column + 2 };
                    }
                    else
                    {
                        figureRows = new int[] { row, row + 1, row + 2 };
                        figureColumns = new int[] { column };
                    }
                    break;
                case 4:
                    figureRows = new int[] { row, row + 1 };
                    figureColumns = new int[] { column, column + 1 };
                    break;
                case 5:
                    // Draw only the "I" shaped part
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row, row + 1, row + 2 };
                        figureColumns = new int[] { column };
                    }
                    else
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1, column + 2 };
                    }
                    break;
                case 6:
                    break;
                default:
                    break;
            }
            // Determine where the other part of the "L" should go
            int[] position = new int[] { };
            int ro5 = 0; int co5 = 0;
            if (figure == 5)
            {
                if (rotation % 2 == 0)
                {
                    position = new int[] { 2, 1 };
                    if (mirrorx)
                        position[0] = position[0] == 0 ? 2 : 0;
                    if (mirrory)
                        position[1] = -position[1];
                }
                else
                {
                    position = new int[] { -1, 2 };
                    if (mirrorx)
                        position[0] = -position[0];
                    if (mirrory)
                        position[1] = position[1] == 0 ? 2 : 0;
                }
                ro5 = row + position[0];
                co5 = column + position[1];
                try
                {
                    figureIsOver = checkIfClicked(new int[] { ro5 }, new int[] { co5 });
                }
                catch { figureIsOut = true; }
            }
            foreach (int co in figureColumns)
                foreach (int ro in figureRows)
                {
                    try
                    {
                        if (checkIfClicked(figureRows, figureColumns) || figureIsOver)
                        {
                            Panel panel = (Panel)parent.Controls.Find("panel" + ro.ToString() + '-' + co.ToString(), true)[0];
                            panel.BackColor = Settings.wrongTilesColor;
                            figureIsOver = true;
                        }
                        else
                        {
                            Panel panel = (Panel)parent.Controls.Find("panel" + ro.ToString() + '-' + co.ToString(), true)[0];
                            if (squareMatrix[ro, co] == 0)
                                panel.BackColor = Settings.moveTilesColor;
                        }
                    }
                    catch // In case the figure goes out of the square
                    {
                        DeleteFigure(parent, row, column);
                        isMouseAllowedToClick = false;
                        figureIsOut = true;
                        foreach (int redCo in figureColumns)
                            foreach (int redRo in figureRows)
                            {
                                if (redRo < rows && redCo < columns)
                                {
                                    Panel panel = (Panel)parent.Controls.Find("panel" + redRo.ToString() + '-' + redCo.ToString(), true)[0];
                                    panel.BackColor = Settings.wrongTilesColor;
                                }
                            }
                        return;
                    }
                }
            if (figure == 5)
            {
                try
                {
                    if (figureIsOver)
                    {
                        Panel panel = (Panel)parent.Controls.Find("panel" + ro5.ToString() + '-' + co5.ToString(), true)[0];
                        panel.BackColor = Settings.wrongTilesColor;
                    }
                    else
                    {
                        Panel panel = (Panel)parent.Controls.Find("panel" + ro5.ToString() + '-' + co5.ToString(), true)[0];
                        panel.BackColor = Settings.moveTilesColor;
                    }
                }
                catch
                {
                    DeleteFigure(parent, row, column);
                    isMouseAllowedToClick = false;
                    foreach (int redCo in figureColumns)
                        foreach (int redRo in figureRows)
                        {
                            if (redRo < rows && redCo < columns)
                            {
                                Panel panel = (Panel)parent.Controls.Find("panel" + redRo.ToString() + '-' + redCo.ToString(), true)[0];
                                panel.BackColor = Settings.wrongTilesColor;
                            }
                        }
                    return;
                }
            }

            isMouseAllowedToClick = true;
        }
        private void MouseIsLeaving(object sender, EventArgs e)
        {
            if (figure != 0)
            {
                Panel p = (Panel)sender;
                TableLayoutPanel parent = (TableLayoutPanel)p.Parent;
                int index = parent.Controls.GetChildIndex(p);

                int row = (index / columns);
                int column = index - row * columns;

                DeleteFigure(parent, row, column);
                //if (squareMatrix[row, column] == 0)
                //    p.BackColor = Color.White;
            }
        }
        private void DeleteFigure(TableLayoutPanel parent, int row, int column)
        {
            int[] figureRows = { };
            int[] figureColumns = { };

            switch (figure)
            {
                case 1:
                    figureRows = new int[] { row };
                    figureColumns = new int[] { column };
                    break;
                case 2:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1 };
                    }
                    else
                    {
                        figureRows = new int[] { row, row + 1 };
                        figureColumns = new int[] { column };
                    }
                    break;
                case 3:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1, column + 2 };
                    }
                    else
                    {
                        figureRows = new int[] { row, row + 1, row + 2 };
                        figureColumns = new int[] { column };
                    }
                    break;
                case 4:
                    figureRows = new int[] { row, row + 1 };
                    figureColumns = new int[] { column, column + 1 };
                    break;
                case 5:
                    if (rotation % 2 == 0)
                    {
                        figureRows = new int[] { row, row + 1, row + 2 };
                        figureColumns = new int[] { column };
                    }
                    else
                    {
                        figureRows = new int[] { row };
                        figureColumns = new int[] { column, column + 1, column + 2 };
                    }
                    break;
                case 6:
                    break;
                default:
                    break;
            }

            foreach (int co in figureColumns)
                foreach (int ro in figureRows)
                {
                    try
                    {
                        Panel panel = (Panel)parent.Controls.Find("panel" + ro.ToString() + '-' + co.ToString(), true)[0];
                        if (squareMatrix[ro, co] == 0)
                            panel.BackColor = Settings.rectBackgroundColor;
                        else
                            panel.BackColor = Settings.tilesColor;
                    }
                    catch { }
                }
            if (figure == 5)
            {
                int[] position = new int[] { };
                int ro, co;
                if (rotation % 2 == 0)
                {
                    position = new int[] { 2, 1 };
                    if (mirrorx)
                        position[0] = position[0] == 0 ? 2 : 0;
                    if (mirrory)
                        position[1] = -position[1];
                }
                else
                {
                    position = new int[] { -1, 2 };
                    if (mirrorx)
                        position[0] = -position[0];
                    if (mirrory)
                        position[1] = position[1] == 0 ? 2 : 0;
                }
                ro = row + position[0];
                co = column + position[1];
                try
                {
                    Panel panel = (Panel)parent.Controls.Find("panel" + ro.ToString() + '-' + co.ToString(), true)[0];
                    if (squareMatrix[ro, co] == 0)
                        panel.BackColor = Settings.rectBackgroundColor;
                    else
                        panel.BackColor = Settings.tilesColor;
                }
                catch { }
            }
        }
        private bool CheckIfWon()
        {
            foreach (int element in squareMatrix)
                if (element == 0)
                    return false;
            return true;
        }
        private void button1x1_Click(object sender, EventArgs e)
        {
            if (button1x1.Enabled == true)
                figure = 1;
        }
        private void button2x1_Click(object sender, EventArgs e)
        {
            rotation = 0;
            if (button2x1.Enabled == true)
                figure = 2;
        }
        private void button3x1_Click(object sender, EventArgs e)
        {
            rotation = 0;
            if (button3x1.Enabled == true)
                figure = 3;
        }
        private void button2x2_Click(object sender, EventArgs e)
        {
            if (button2x2.Enabled == true)
                figure = 4;
        }
        private void buttonL_Click(object sender, EventArgs e)
        {
            rotation = 0;
            mirrorx = false;
            mirrory = false;
            if (buttonL.Enabled == true)
                figure = 5;
        }
        private void backButton_Click_1(object sender, EventArgs e)
        {
            if (backButton.Enabled == true && move != 0)
                RemoveLastFigure(sqAreaPanel);
        }
        private void resetButton_Click_1(object sender, EventArgs e)
        {
            if (resetButton.Enabled == true)
                ResetTheArea(sqAreaPanel);
        }
        private void ResetTheArea(TableLayoutPanel parent)
        {
            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                {
                    squareMatrix[j, i] = 0;
                    Panel panel = (Panel)parent.Controls.Find("panel" + j.ToString() + '-' + i.ToString(), true)[0];
                    panel.BackColor = Settings.rectBackgroundColor;
                }
            move = 0;
            numMosse.Text = move.ToString();
            rotation = 0;
            mirrorx = mirrory = false;
            figure = 0;
        }
        private void newGameButton_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            // Resetting the game variables
            figure = 0; // Figure = 0 means no figure is selected
            rotation = 0;
            mirrorx = false;
            mirrory = false;
            move = 0;
            numMosse.Text = move.ToString();
            try
            {
                TableLayoutPanel panel = (TableLayoutPanel)sqAreaPanel.Controls.Find("RectangleArea", true)[0];
                sqAreaPanel.Controls.Remove(panel);
            }
            catch { }
            rows = GetRandomOdd(Settings.minRows, Settings.maxRows);
            columns = GetRandomOdd(Settings.minCols, Settings.maxCols);

            hasWon = false;
            // This is done to prevent crashes
            if (Application.OpenForms.OfType<WinForm>().Count() == 1)
                Application.OpenForms.OfType<WinForm>().First().Close();


            SuspendLayout();
            CreateSquare(rows, columns);
            ResumeLayout();

            // Re-enable the buttons
            button1x1.Enabled = true;
            button2x1.Enabled = true;
            button3x1.Enabled = true;
            button2x2.Enabled = true;
            buttonL.Enabled = true;
            resetButton.Enabled = true;
            backButton.Enabled = true;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            initialPage.BringToFront();
        }
        // Handling keyboard input
        private void PrimaryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            IEnumerable<TableLayoutPanel> children = sqAreaPanel.Controls.OfType<TableLayoutPanel>();
            TableLayoutPanel rectangle = children.ElementAt(0);
            if (mouseX != -1) // If the mouse is inside the panel
                switch (e.KeyChar)
                {
                    case 'r': // If the user wants to rotate the figure
                        DeleteFigure(rectangle, mouseY, mouseX);
                        ++rotation;
                        DrawFigure(rectangle, mouseY, mouseX);
                        break;
                    case 'x': // If the user wants to mirror the figure along the x axis
                        DeleteFigure(rectangle, mouseY, mouseX);
                        mirrorx = !mirrorx;
                        DrawFigure(rectangle, mouseY, mouseX);
                        break;
                    case 'y': // If the user wants to mirror the figure along the y axis
                        DeleteFigure(rectangle, mouseY, mouseX);
                        mirrory = !mirrory;
                        DrawFigure(rectangle, mouseY, mouseX);
                        break;
                    case 'z':  // If the user wants to delete the figures inside the rectangle
                        DeleteFigure(rectangle, mouseY, mouseX);
                        figure = 0;
                        DrawFigure(rectangle, mouseY, mouseX);
                        break;
                    default:
                        break;
                }
        }

        private void MoveLabelPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableMinRow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quitButton_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
