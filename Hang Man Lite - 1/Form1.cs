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
            if (letters.Contains(txtGuess.Text))
            {
                letters.Remove(txtGuess.Text);
                MessageBox.Show($"You have already entered {txtGuess.Text}, please enter a new number", "Error");
                txtGuess.Text = String.Empty;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string toFind = txtGuess.Text;
            int index = word.IndexOf(txtGuess.Text);
            
            if (index == -1)
            {
                guessCounter += 1;
                letters.Add(toFind);
                lstGuessedWords.DataSource = null;
                lstGuessedWords.DataSource = letters;
            }
            else if (toFind == String.Empty)
            {
                MessageBox.Show("Please enter a valid letter", "Error");
            }

            if (guessCounter == 1)
            {
                imgHang.Image = Properties.Resources.hangman_1;
            }
            else if (guessCounter == 2)
            {
                imgHang.Image = Properties.Resources.hangman_2;
            }
            else if (guessCounter == 3)
            {
                imgHang.Image = Properties.Resources.hangman_dead;
                MessageBox.Show("Please try again", "You lose!");
                Application.Restart();
                Application.ExitThread();
            }
            
            if (index > -1)
            {
                displayWord.Replace(displayWord[index], Convert.ToChar(toFind));
            }
            lblLetters.Text = $"Found '{toFind}' in '{word}' at position {index}";
            txtGuess.Text = String.Empty;
        }
    }
}
