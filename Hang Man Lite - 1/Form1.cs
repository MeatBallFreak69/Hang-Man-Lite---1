using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hang_Man_Lite___1
{
    public partial class frmHangman : Form
    {
        SoundPlayer sound;
        private Button btnOnePlayer = new Button();
        private Button btnTwoPlayer = new Button();
        private Label lblSelectPlayerCount = new Label();
        string word;
        string displayWord;
        int guessCounter = 0;
        List<string> letters = new List<string>();
        List<string> Words = new List<string>();
        bool twoPlayer;
        char guess;
        Random randomWord = new Random();

        public frmHangman()
        {
            InitializeComponent();
            Words.Add("computer");
            Words.Add("apple");
            Words.Add("coding");
            Words.Add("hangman");
            Words.Add("project");
            Words.Add("class");
            Words.Add("strings");
            Words.Add("random");
            Words.Add("keyboard");
            Words.Add("mouse");
            Words.Add("design");
            Words.Add("sharp");
            Words.Add("programming");
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
            
            if (word.Contains(guess))
            {
                foreach (char j in word)
                {
                    if (j.Equals(guess))
                    {
                        int searchIndex = word.IndexOf(j);
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
                    sound = new SoundPlayer(Properties.Resources.The_Price_is_Right_Losing_Horn___Gaming_Sound_Effect__HD_);
                    sound.Play();
                    MessageBox.Show("Please try again", "You lose!");
                    Application.Restart();
                    Application.ExitThread();
                }
            }
            
            txtGuess.Text = String.Empty;
           
            if (displayWord == word)
            {
                sound = new SoundPlayer(Properties.Resources.Victory_Screech);
                sound.Play();
                MessageBox.Show("You win!", "Congrats!");
                Application.Restart();
                Application.ExitThread();
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { '*', ' ', '\'' };
            string input = txtInputWord.Text.ToUpper();

            btnGuess.Visible = false;
            txtGuess.Visible = true;
            lblInstructions2.Visible = false;
            txtInputWord.Visible = false;
            btnInput.Visible = false;

            word = input.Trim(charsToTrim);    
            for (int i = 1; i <= word.Length; i++)
            {
                displayWord += "-";
            }
            lblWord.Text = displayWord;
        }

        public void btnOnePlayer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
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
            word = Words[playerOneIndex].ToUpper();

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
