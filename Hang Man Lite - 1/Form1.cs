using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_Man_Lite___1
{
    public partial class frmHangman : Form
    {
        string word;
        string displayWord;
        int guessCounter = 0;
        List<string> letters = new List<string>();

        public frmHangman()
        {
            InitializeComponent();
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            word = "COMPUTER";
            displayWord = "_ _ _ _ _ _ _ _";
            lblWord.Text = displayWord;
            lstGuessedWords.DataSource = letters;
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            txtGuess.Text = txtGuess.Text.ToUpper();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string toFind = txtGuess.Text;
            int index = word.IndexOf(txtGuess.Text);
            if (index == -1)
            {
                letters.Add(word);
                lstGuessedWords.DataSource = null;
                lstGuessedWords.DataSource = letters;
            }
            lblLetters.Text = $"Found '{toFind}' in '{word}' at position {index}";
        }
    }
}
