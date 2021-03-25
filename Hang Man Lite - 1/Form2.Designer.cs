
namespace Hang_Man_Lite___1
{
    partial class frmSelectPlayerCount
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
            this.btnPlayerOne = new System.Windows.Forms.Button();
            this.btnPlayerTwo = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayerOne
            // 
            this.btnPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerOne.Location = new System.Drawing.Point(12, 61);
            this.btnPlayerOne.Name = "btnPlayerOne";
            this.btnPlayerOne.Size = new System.Drawing.Size(201, 132);
            this.btnPlayerOne.TabIndex = 0;
            this.btnPlayerOne.Text = "One Player";
            this.btnPlayerOne.UseVisualStyleBackColor = true;
            this.btnPlayerOne.Click += new System.EventHandler(this.btnPlayerOne_Click);
            // 
            // btnPlayerTwo
            // 
            this.btnPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerTwo.Location = new System.Drawing.Point(219, 61);
            this.btnPlayerTwo.Name = "btnPlayerTwo";
            this.btnPlayerTwo.Size = new System.Drawing.Size(201, 132);
            this.btnPlayerTwo.TabIndex = 1;
            this.btnPlayerTwo.Text = "Two Player";
            this.btnPlayerTwo.UseVisualStyleBackColor = true;
            this.btnPlayerTwo.Click += new System.EventHandler(this.btnPlayerTwo_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(414, 20);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Please select one option to select the player count";
            // 
            // frmSelectPlayerCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 240);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnPlayerTwo);
            this.Controls.Add(this.btnPlayerOne);
            this.Name = "frmSelectPlayerCount";
            this.Text = "Select Player Count";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayerOne;
        private System.Windows.Forms.Button btnPlayerTwo;
        private System.Windows.Forms.Label lblInstructions;
    }
}