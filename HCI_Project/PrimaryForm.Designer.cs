namespace HCI_Project
{
    partial class PrimaryForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.initialPage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startEx = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.startExPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.newGameButton = new System.Windows.Forms.Button();
            this.labelNumOp = new System.Windows.Forms.Label();
            this.numMosse = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.UpperLabelMovePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MoveLabelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.maxNumMosse = new System.Windows.Forms.Label();
            this.sqAreaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button3x1 = new System.Windows.Forms.Button();
            this.button2x1 = new System.Windows.Forms.Button();
            this.button1x1 = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.button2x2 = new System.Windows.Forms.Button();
            this.FigurePanel = new System.Windows.Forms.TableLayoutPanel();
            this.GamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.initialPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.startExPage.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.UpperLabelMovePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MoveLabelPanel.SuspendLayout();
            this.sqAreaPanel.SuspendLayout();
            this.FigurePanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialPage
            // 
            this.initialPage.Controls.Add(this.tableLayoutPanel1);
            this.initialPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialPage.Location = new System.Drawing.Point(0, 0);
            this.initialPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initialPage.Name = "initialPage";
            this.initialPage.Size = new System.Drawing.Size(942, 493);
            this.initialPage.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.startEx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.settings, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.credits, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.exit, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // startEx
            // 
            this.startEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startEx.AutoSize = true;
            this.startEx.Location = new System.Drawing.Point(380, 127);
            this.startEx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startEx.Name = "startEx";
            this.startEx.Size = new System.Drawing.Size(180, 72);
            this.startEx.TabIndex = 0;
            this.startEx.Text = "Inizia Esercizio";
            this.startEx.UseVisualStyleBackColor = true;
            this.startEx.Click += new System.EventHandler(this.startEx_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.AutoSize = true;
            this.settings.Location = new System.Drawing.Point(380, 207);
            this.settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(180, 72);
            this.settings.TabIndex = 1;
            this.settings.Text = "Impostazioni";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // credits
            // 
            this.credits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.credits.AutoSize = true;
            this.credits.Location = new System.Drawing.Point(380, 287);
            this.credits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(180, 72);
            this.credits.TabIndex = 2;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(380, 367);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 72);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // startExPage
            // 
            this.startExPage.Controls.Add(this.label1);
            this.startExPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startExPage.Location = new System.Drawing.Point(0, 0);
            this.startExPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startExPage.Name = "startExPage";
            this.startExPage.Size = new System.Drawing.Size(942, 493);
            this.startExPage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(353, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Exercise";
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 44);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(153, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(107, 44);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeButton.Location = new System.Drawing.Point(453, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(109, 44);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(116, 12);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.CausesValidation = false;
            this.ButtonPanel.ColumnCount = 7;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.661333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.661333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.661333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.ButtonPanel.Controls.Add(this.backButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.resetButton, 2, 0);
            this.ButtonPanel.Controls.Add(this.newGameButton, 4, 0);
            this.ButtonPanel.Controls.Add(this.homeButton, 6, 0);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(125, 303);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 1;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.Size = new System.Drawing.Size(565, 50);
            this.ButtonPanel.TabIndex = 1;
            // 
            // newGameButton
            // 
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameButton.Location = new System.Drawing.Point(303, 3);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(107, 44);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click_1);
            // 
            // labelNumOp
            // 
            this.labelNumOp.AutoSize = true;
            this.labelNumOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOp.Location = new System.Drawing.Point(3, 0);
            this.labelNumOp.Name = "labelNumOp";
            this.labelNumOp.Size = new System.Drawing.Size(520, 68);
            this.labelNumOp.TabIndex = 0;
            this.labelNumOp.Text = "Number of moves:";
            this.labelNumOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMosse
            // 
            this.numMosse.AutoSize = true;
            this.numMosse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMosse.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMosse.Location = new System.Drawing.Point(529, 0);
            this.numMosse.Name = "numMosse";
            this.numMosse.Size = new System.Drawing.Size(196, 68);
            this.numMosse.TabIndex = 1;
            this.numMosse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quitButton
            // 
            this.quitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quitButton.Location = new System.Drawing.Point(731, 3);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(76, 62);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click_2);
            // 
            // UpperLabelMovePanel
            // 
            this.UpperLabelMovePanel.BackColor = System.Drawing.SystemColors.Control;
            this.UpperLabelMovePanel.ColumnCount = 3;
            this.UpperLabelMovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.UpperLabelMovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UpperLabelMovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UpperLabelMovePanel.Controls.Add(this.labelNumOp, 0, 0);
            this.UpperLabelMovePanel.Controls.Add(this.numMosse, 1, 0);
            this.UpperLabelMovePanel.Controls.Add(this.quitButton, 2, 0);
            this.UpperLabelMovePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperLabelMovePanel.Location = new System.Drawing.Point(3, 3);
            this.UpperLabelMovePanel.Name = "UpperLabelMovePanel";
            this.UpperLabelMovePanel.RowCount = 1;
            this.UpperLabelMovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UpperLabelMovePanel.Size = new System.Drawing.Size(810, 68);
            this.UpperLabelMovePanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.MoveLabelPanel, 0, 0);
            this.MainPanel.Controls.Add(this.sqAreaPanel, 0, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(117, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 2;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.34F));
            this.MainPanel.Size = new System.Drawing.Size(822, 487);
            this.MainPanel.TabIndex = 1;
            // 
            // MoveLabelPanel
            // 
            this.MoveLabelPanel.AutoSize = true;
            this.MoveLabelPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MoveLabelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoveLabelPanel.ColumnCount = 1;
            this.MoveLabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MoveLabelPanel.Controls.Add(this.UpperLabelMovePanel, 0, 0);
            this.MoveLabelPanel.Controls.Add(this.maxNumMosse, 0, 1);
            this.MoveLabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveLabelPanel.Location = new System.Drawing.Point(3, 3);
            this.MoveLabelPanel.Name = "MoveLabelPanel";
            this.MoveLabelPanel.RowCount = 2;
            this.MoveLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MoveLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MoveLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MoveLabelPanel.Size = new System.Drawing.Size(816, 99);
            this.MoveLabelPanel.TabIndex = 0;
            this.MoveLabelPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MoveLabelPanel_Paint);
            // 
            // maxNumMosse
            // 
            this.maxNumMosse.AutoSize = true;
            this.maxNumMosse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxNumMosse.Location = new System.Drawing.Point(3, 74);
            this.maxNumMosse.Name = "maxNumMosse";
            this.maxNumMosse.Size = new System.Drawing.Size(810, 25);
            this.maxNumMosse.TabIndex = 1;
            this.maxNumMosse.Text = "Maximum number: 0";
            this.maxNumMosse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sqAreaPanel
            // 
            this.sqAreaPanel.ColumnCount = 3;
            this.sqAreaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sqAreaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.sqAreaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sqAreaPanel.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.sqAreaPanel.Controls.Add(this.ButtonPanel, 1, 1);
            this.sqAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqAreaPanel.Location = new System.Drawing.Point(3, 108);
            this.sqAreaPanel.Name = "sqAreaPanel";
            this.sqAreaPanel.RowCount = 3;
            this.sqAreaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.sqAreaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.sqAreaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.sqAreaPanel.Size = new System.Drawing.Size(816, 376);
            this.sqAreaPanel.TabIndex = 1;
            // 
            // button3x1
            // 
            this.button3x1.AutoSize = true;
            this.button3x1.BackColor = System.Drawing.SystemColors.Window;
            this.button3x1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3x1.BackgroundImage")));
            this.button3x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3x1.Location = new System.Drawing.Point(6, 198);
            this.button3x1.Name = "button3x1";
            this.button3x1.Size = new System.Drawing.Size(96, 87);
            this.button3x1.TabIndex = 2;
            this.button3x1.UseVisualStyleBackColor = false;
            this.button3x1.Click += new System.EventHandler(this.button3x1_Click);
            // 
            // button2x1
            // 
            this.button2x1.AutoSize = true;
            this.button2x1.BackColor = System.Drawing.SystemColors.Window;
            this.button2x1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2x1.BackgroundImage")));
            this.button2x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2x1.Location = new System.Drawing.Point(6, 102);
            this.button2x1.Name = "button2x1";
            this.button2x1.Size = new System.Drawing.Size(96, 87);
            this.button2x1.TabIndex = 1;
            this.button2x1.UseVisualStyleBackColor = false;
            this.button2x1.Click += new System.EventHandler(this.button2x1_Click);
            // 
            // button1x1
            // 
            this.button1x1.AutoSize = true;
            this.button1x1.BackColor = System.Drawing.SystemColors.Window;
            this.button1x1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1x1.BackgroundImage")));
            this.button1x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1x1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1x1.Location = new System.Drawing.Point(6, 6);
            this.button1x1.Name = "button1x1";
            this.button1x1.Size = new System.Drawing.Size(96, 87);
            this.button1x1.TabIndex = 0;
            this.button1x1.UseVisualStyleBackColor = false;
            this.button1x1.Click += new System.EventHandler(this.button1x1_Click);
            // 
            // buttonL
            // 
            this.buttonL.AutoSize = true;
            this.buttonL.BackColor = System.Drawing.SystemColors.Window;
            this.buttonL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonL.BackgroundImage")));
            this.buttonL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonL.Location = new System.Drawing.Point(6, 390);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(96, 91);
            this.buttonL.TabIndex = 4;
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // button2x2
            // 
            this.button2x2.AutoSize = true;
            this.button2x2.BackColor = System.Drawing.SystemColors.Window;
            this.button2x2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2x2.BackgroundImage")));
            this.button2x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2x2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2x2.Location = new System.Drawing.Point(6, 294);
            this.button2x2.Name = "button2x2";
            this.button2x2.Size = new System.Drawing.Size(96, 87);
            this.button2x2.TabIndex = 3;
            this.button2x2.UseVisualStyleBackColor = false;
            this.button2x2.Click += new System.EventHandler(this.button2x2_Click);
            // 
            // FigurePanel
            // 
            this.FigurePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.FigurePanel.ColumnCount = 1;
            this.FigurePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FigurePanel.Controls.Add(this.buttonL, 0, 4);
            this.FigurePanel.Controls.Add(this.button2x2, 0, 3);
            this.FigurePanel.Controls.Add(this.button3x1, 0, 2);
            this.FigurePanel.Controls.Add(this.button2x1, 0, 1);
            this.FigurePanel.Controls.Add(this.button1x1, 0, 0);
            this.FigurePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FigurePanel.Location = new System.Drawing.Point(3, 3);
            this.FigurePanel.Name = "FigurePanel";
            this.FigurePanel.RowCount = 5;
            this.FigurePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FigurePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FigurePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FigurePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FigurePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FigurePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FigurePanel.Size = new System.Drawing.Size(108, 487);
            this.FigurePanel.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.ColumnCount = 2;
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.GamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.87878F));
            this.GamePanel.Controls.Add(this.FigurePanel, 0, 0);
            this.GamePanel.Controls.Add(this.MainPanel, 1, 0);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.RowCount = 1;
            this.GamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GamePanel.Size = new System.Drawing.Size(942, 493);
            this.GamePanel.TabIndex = 2;
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.initialPage);
            this.Controls.Add(this.startExPage);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrimaryForm";
            this.Text = "Nome App";
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrimaryForm_KeyPress);
            this.initialPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.startExPage.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.UpperLabelMovePanel.ResumeLayout(false);
            this.UpperLabelMovePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MoveLabelPanel.ResumeLayout(false);
            this.MoveLabelPanel.PerformLayout();
            this.sqAreaPanel.ResumeLayout(false);
            this.FigurePanel.ResumeLayout(false);
            this.FigurePanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel initialPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button startEx;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel startExPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label labelNumOp;
        private System.Windows.Forms.Label numMosse;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TableLayoutPanel UpperLabelMovePanel;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel MoveLabelPanel;
        private System.Windows.Forms.Label maxNumMosse;
        private System.Windows.Forms.TableLayoutPanel sqAreaPanel;
        private System.Windows.Forms.Button button3x1;
        private System.Windows.Forms.Button button2x1;
        private System.Windows.Forms.Button button1x1;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button button2x2;
        private System.Windows.Forms.TableLayoutPanel FigurePanel;
        private System.Windows.Forms.TableLayoutPanel GamePanel;
    }
}

