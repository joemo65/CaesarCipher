namespace CaesarCipher
{
    partial class MainWindow
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
            this.AlphabetLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AlphabetTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // AlphabetLabel
            // 
            this.AlphabetLabel.AutoSize = true;
            this.AlphabetLabel.Location = new System.Drawing.Point(371, 55);
            this.AlphabetLabel.Name = "AlphabetLabel";
            this.AlphabetLabel.Size = new System.Drawing.Size(49, 13);
            this.AlphabetLabel.TabIndex = 0;
            this.AlphabetLabel.Text = "Alphabet";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(12, 12);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(58, 13);
            this.LanguageLabel.TabIndex = 1;
            this.LanguageLabel.Text = "Language:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "English";
            // 
            // AlphabetTable
            // 
            this.AlphabetTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AlphabetTable.ColumnCount = 1;
            this.AlphabetTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlphabetTable.Location = new System.Drawing.Point(12, 71);
            this.AlphabetTable.Name = "AlphabetTable";
            this.AlphabetTable.RowCount = 2;
            this.AlphabetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlphabetTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AlphabetTable.Size = new System.Drawing.Size(760, 50);
            this.AlphabetTable.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AlphabetTable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.AlphabetLabel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlphabetLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel AlphabetTable;
    }
}

