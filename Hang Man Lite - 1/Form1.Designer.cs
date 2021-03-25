
namespace Hang_Man_Lite___1
{
    partial class frmHangman
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lstGuessedWords = new System.Windows.Forms.ListBox();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(13, 13);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(327, 29);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Welcome to Hang-Man Lite";
            this.lblGreeting.Visible = false;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(14, 43);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(315, 13);
            this.lblLetters.TabIndex = 1;
            this.lblLetters.Text = "Enter a letter to reveal the hidden word. 3 strikes and you are out!";
            this.lblLetters.Visible = false;
            // 
            // lstGuessedWords
            // 
            this.lstGuessedWords.FormattingEnabled = true;
            this.lstGuessedWords.Location = new System.Drawing.Point(278, 98);
            this.lstGuessedWords.Name = "lstGuessedWords";
            this.lstGuessedWords.Size = new System.Drawing.Size(120, 173);
            this.lstGuessedWords.TabIndex = 3;
            this.lstGuessedWords.Visible = false;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.AutoSize = true;
            this.lblUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(278, 76);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(96, 16);
            this.lblUsedLetters.TabIndex = 4;
            this.lblUsedLetters.Text = "Used Letters";
            this.lblUsedLetters.Visible = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(278, 279);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(36, 20);
            this.txtGuess.TabIndex = 5;
            this.txtGuess.Visible = false;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(320, 277);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Visible = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // imgHang
            // 
            this.imgHang.Image = global::Hang_Man_Lite___1.Properties.Resources.hangman_empty;
            this.imgHang.Location = new System.Drawing.Point(12, 76);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(260, 223);
            this.imgHang.TabIndex = 2;
            this.imgHang.TabStop = false;
            this.imgHang.Visible = false;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(-1, 302);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(208, 73);
            this.lblWord.TabIndex = 7;
            this.lblWord.Text = "--------";
            this.lblWord.Visible = false;
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(199, 339);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(100, 20);
            this.txtInputWord.TabIndex = 8;
            this.txtInputWord.Visible = false;
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions2.Location = new System.Drawing.Point(198, 318);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(176, 16);
            this.lblInstructions2.TabIndex = 9;
            this.lblInstructions2.Text = "Input word to guess here";
            this.lblInstructions2.Visible = false;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(305, 337);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "Input Word";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Visible = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 371);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblUsedLetters);
            this.Controls.Add(this.lstGuessedWords);
            this.Controls.Add(this.imgHang);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHangman";
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            this.MouseHover += new System.EventHandler(this.frmHangman_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.ListBox lstGuessedWords;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Button btnInput;
    }
}

