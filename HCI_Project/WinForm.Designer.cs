
namespace HCI_Project
{
    partial class WinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWon = new System.Windows.Forms.Label();
            this.labelSuggestion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWon
            // 
            this.labelWon.AutoSize = true;
            this.labelWon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWon.Location = new System.Drawing.Point(3, 0);
            this.labelWon.Name = "labelWon";
            this.labelWon.Size = new System.Drawing.Size(276, 142);
            this.labelWon.TabIndex = 0;
            this.labelWon.Text = "You Won!";
            this.labelWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // labelSuggestion
            // 
            this.labelSuggestion.AutoSize = true;
            this.labelSuggestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSuggestion.Location = new System.Drawing.Point(3, 142);
            this.labelSuggestion.Name = "labelSuggestion";
            this.labelSuggestion.Size = new System.Drawing.Size(276, 40);
            this.labelSuggestion.TabIndex = 1;
            this.labelSuggestion.Text = "Press the New Game button to start a new game!";
            this.labelSuggestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelWon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSuggestion, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 203);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WinForm";
            this.Text = "WinForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWon;
        private System.Windows.Forms.Label labelSuggestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}