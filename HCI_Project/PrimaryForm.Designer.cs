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
            this.initialPage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startEx = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.startExPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.initialPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.startExPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialPage
            // 
            this.initialPage.Controls.Add(this.tableLayoutPanel1);
            this.initialPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialPage.Location = new System.Drawing.Point(0, 0);
            this.initialPage.Name = "initialPage";
            this.initialPage.Size = new System.Drawing.Size(800, 450);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // startEx
            // 
            this.startEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startEx.AutoSize = true;
            this.startEx.Location = new System.Drawing.Point(323, 115);
            this.startEx.Name = "startEx";
            this.startEx.Size = new System.Drawing.Size(154, 67);
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
            this.settings.Location = new System.Drawing.Point(323, 188);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(154, 67);
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
            this.credits.Location = new System.Drawing.Point(323, 261);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(154, 67);
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
            this.exit.Location = new System.Drawing.Point(323, 334);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(154, 67);
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
            this.startExPage.Name = "startExPage";
            this.startExPage.Size = new System.Drawing.Size(800, 450);
            this.startExPage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(265, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Exercise";
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.initialPage);
            this.Controls.Add(this.startExPage);
            this.Name = "PrimaryForm";
            this.Text = "Nome App";
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            this.initialPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.startExPage.ResumeLayout(false);
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
    }
}

