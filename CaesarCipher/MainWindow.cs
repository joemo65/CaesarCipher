using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class MainWindow : Form
    {
        //create a new alphabet, defaults to english
        private Alphabet alphabet = new Alphabet();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadAlphabet();
        }

        private void LoadAlphabet()
        {
            //to divide the table into equal lengths
            float columnDivide = 1;

            //clear the table of previous entries
            AlphabetTable.Controls.Clear();

            //the table rows should always be 2, one for the letter's place, one for the letter
            AlphabetTable.RowCount = 2;

            //set the table's column count to the alphabet's length
            AlphabetTable.ColumnCount = alphabet.AlphabetCount;

            //divide the table into equal lengths
            columnDivide = 100 - (100 / alphabet.AlphabetCount);

            //populate the table
            for (int i = 0; i < AlphabetTable.ColumnCount; i++)
            {
                //create a column style
                AlphabetTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnDivide));

                //add the current element's place in the top row
                AlphabetTable.Controls.Add(new Label() { Text = (i + 1).ToString() }, i, 0);

                //add the current element's place in the bottom row
                AlphabetTable.Controls.Add(new Label() { Text = alphabet.AlphabetLetters[i].ToString() }, i, 1);

            }
        }
    }
}
