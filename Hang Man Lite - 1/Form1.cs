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
        bool onePlayer;
        bool twoPlayer;

        public frmHangman()
        {
            InitializeComponent();
            onePlayer = frmSelectPlayerCount.onePlayer;
            twoPlayer = frmSelectPlayerCount.twoPlayer;
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            /*frmSelectPlayerCount formPlayerCount = new frmSelectPlayerCount();
            formPlayerCount.Show();*/


            //Player select controls/
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

            if (index < 0 && toFind.Length > 0)
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
            else if (toFind == String.Empty)
            {
                MessageBox.Show("Please fill in the textbox with an appropriate guess!", "Error");
            }
             else if (toFind.Length >0)
            {
                for (int i = 1; i<= word.Length; i++)
                {
                    displayWord = displayWord.Remove(index, 1);
                    displayWord = displayWord.Insert(index, toFind);
                    lblWord.Text = displayWord;

                }
                    
                if (displayWord == word)
                {
                    MessageBox.Show("You win!", "Congrats!");
                    Application.Restart();
                    Application.ExitThread();
                }
                txtGuess.Text = String.Empty;
            }
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
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
            if (onePlayer == true)
            {
                lblInstructions2.Visible = false;
                txtInputWord.Visible = false;
                btnInput.Visible = false;
            }

        }
        void btnOnePlayer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            onePlayer = true;
            imgHang.Visible = true;
            lblGreeting.Visible = true;
            lblLetters.Visible = true;
            lblWord.Visible = true;
            lstGuessedWords.Visible = true;
            lblUsedLetters.Visible = true;
            btnGuess.Visible = true;
            txtGuess.Visible = true;

            btnOnePlayer.Visible = false;
            btnTwoPlayer.Visible = false;
            lblSelectPlayerCount.Visible = false;
        }

        void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            imgHang.Visible = true;
            lblGreeting.Visible = true;
            lblLetters.Visible = true;
            lblWord.Visible = true;
            lstGuessedWords.Visible = true;
            lblUsedLetters.Visible = true;
            btnGuess.Visible = true;
            txtGuess.Visible = true;
            txtInputWord.Visible = true;
            btnInput.Visible = true;
            lblInstructions2.Visible = true;

            btnOnePlayer.Visible = false;
            btnTwoPlayer.Visible = false;
            lblSelectPlayerCount.Visible = false;

            lblWord.SendToBack();
        }
    }
}
