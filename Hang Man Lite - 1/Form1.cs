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
        private Button btnOnePlayer = new Button();
        private Button btnTwoPlayer = new Button();
        private Label lblSelectPlayerCount = new Label();
        string word;
        string displayWord;
        int guessCounter = 0;
        List<string> letters = new List<string>();
        List<string> Words = new List<string>();
        bool onePlayer;
        bool twoPlayer;
        char guess;
        Random randomWord = new Random();

        public frmHangman()
        {
            InitializeComponent();
            /*Words.Add("computer");
            Words.Add("aldworth");
            Words.Add("apple");
            Words.Add("steven");
            Words.Add("clark");
            Words.Add("miller");
            Words.Add("coding");
            Words.Add("hangman");
            Words.Add("project");
            Words.Add("class");
            Words.Add("strings");*/
            Words.Add("random");
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            //Player amount select controls/
            btnOnePlayer.BackColor = SystemColors.Control;
            btnOnePlayer.Name = "btnOnePlayer";
            btnOnePlayer.Text = "One Player";
            btnOnePlayer.Location = new System.Drawing.Point(102, 156);
            btnOnePlayer.Size = new System.Drawing.Size(100, 50);

            btnTwoPlayer.BackColor = SystemColors.Control;
            btnTwoPlayer.Name = "btnTwoPlayer";
            btnTwoPlayer.Text = "Two Player";
            btnTwoPlayer.Location = new System.Drawing.Point(202, 156);
            btnTwoPlayer.Size = new System.Drawing.Size(100, 50);

            this.lblSelectPlayerCount.Text = "Please select your player count";
            this.lblSelectPlayerCount.Location = new System.Drawing.Point(125, 130);
            this.lblSelectPlayerCount.Size = new System.Drawing.Size(250, 15);

            if (twoPlayer)
            {
                word = "";
                for (int i = 1; i <= word.Length; i++)
                {
                    displayWord += "-";
                }
                lblWord.Text = displayWord;
                lstGuessedWords.DataSource = letters;
            }
            Controls.Add(btnOnePlayer);
            Controls.Add(btnTwoPlayer);
            Controls.Add(lblSelectPlayerCount);

            btnOnePlayer.Click += new EventHandler(this.btnOnePlayer_Click);
            btnTwoPlayer.Click += new EventHandler(this.btnTwoPlayer_Click);

            
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            if (txtGuess.Text != "")
            {
                btnGuess.Visible = true;
            }
            else
            {
                btnGuess.Visible = false;
            }
            txtGuess.Text = txtGuess.Text.ToUpper();
            if (letters.Contains(txtGuess.Text))
            {
                MessageBox.Show($"You have already entered {txtGuess.Text}, please enter a new number", "Error");
                txtGuess.Text = String.Empty;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string toFind = txtGuess.Text;
            int index = word.IndexOf(toFind);
               
            guess = Convert.ToChar(toFind);
            if (word.Contains(toFind))// If the chosen word has the letter guess
            {

                foreach (char j in word)// Iterate through every character
                {
                    if (j.Equals(guess))// If the character = the letter guess
                    {
                        int searchIndex = word.IndexOf(j);// Get the index of j
                        while (searchIndex > -1)
                        {
                            displayWord = displayWord.Remove(searchIndex, 1).Insert(searchIndex, j.ToString());
                            searchIndex = word.IndexOf(j, searchIndex + 1);
                            lblWord.Text = displayWord;
                        }
                        }
                    }
                }
            else
            {
                guessCounter += 1;
                letters.Add(toFind);
                txtGuess.Text = String.Empty;
                lstGuessedWords.DataSource = null;
                lstGuessedWords.DataSource = letters;
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
            }
            
            txtGuess.Text = String.Empty;
           
            if (displayWord == word)
            {
                MessageBox.Show("You win!", "Congrats!");
                Application.Restart();
                Application.ExitThread();
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            btnGuess.Visible = false;
            txtGuess.Visible = true;
            lblInstructions2.Visible = false;
            txtInputWord.Visible = false;
            btnInput.Visible = false;

            word = txtInputWord.Text.ToUpper();
            for (int i = 1; i <= word.Length; i++)
            {
                displayWord += "-";
            }
            lblWord.Text = displayWord;
        }

        private void frmHangman_MouseHover(object sender, EventArgs e)
        {
            

        }
        public void btnOnePlayer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            onePlayer = true;
            imgHang.Visible = true;
            lblGreeting.Visible = true;
            lblLetters.Visible = true;
            lblWord.Visible = true;
            lstGuessedWords.Visible = true;
            lblUsedLetters.Visible = true;
            btnGuess.Visible = false;
            txtGuess.Visible = true;

            btnOnePlayer.Visible = false;
            btnTwoPlayer.Visible = false;
            lblSelectPlayerCount.Visible = false;

            int playerOneIndex = randomWord.Next(Words.Count);
            word = Words[playerOneIndex];

            for (int i = 1; i <= word.Length; i++)
            {
                displayWord += "-";
                lblWord.Text = displayWord;
                lstGuessedWords.DataSource = letters;
            }
            
        }

        public void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            twoPlayer = true;
            Button btn = sender as Button;
            imgHang.Visible = true;
            lblGreeting.Visible = true;
            lblLetters.Visible = true;
            lblWord.Visible = true;
            lstGuessedWords.Visible = true;
            lblUsedLetters.Visible = true;
            btnGuess.Visible = false;
            txtGuess.Visible = false;
            txtInputWord.Visible = true;
            btnInput.Visible = false;
            lblInstructions2.Visible = true;

            btnOnePlayer.Visible = false;
            btnTwoPlayer.Visible = false;
            lblSelectPlayerCount.Visible = false;

            lblWord.SendToBack();
        }

        private void txtInputWord_TextChanged(object sender, EventArgs e)
        {
            if (txtInputWord.Text != "")
            {
                btnInput.Visible = true;
            }
            else
            {
                btnInput.Visible = false;
            }
        }
    }
}
