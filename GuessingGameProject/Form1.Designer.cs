
namespace GuessingGameProject
{
    partial class GuessingGameForm
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
            this.lblMakeGuess = new System.Windows.Forms.Label();
            this.radiobtnA = new System.Windows.Forms.RadioButton();
            this.radiobtnB = new System.Windows.Forms.RadioButton();
            this.radiobtnC = new System.Windows.Forms.RadioButton();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblScoreIs = new System.Windows.Forms.Label();
            this.lblPreviousScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMakeGuess
            // 
            this.lblMakeGuess.AutoSize = true;
            this.lblMakeGuess.Location = new System.Drawing.Point(133, 29);
            this.lblMakeGuess.Name = "lblMakeGuess";
            this.lblMakeGuess.Size = new System.Drawing.Size(128, 13);
            this.lblMakeGuess.TabIndex = 0;
            this.lblMakeGuess.Text = "Make a guess - A, B, or C";
            // 
            // radiobtnA
            // 
            this.radiobtnA.AutoSize = true;
            this.radiobtnA.Location = new System.Drawing.Point(136, 61);
            this.radiobtnA.Name = "radiobtnA";
            this.radiobtnA.Size = new System.Drawing.Size(32, 17);
            this.radiobtnA.TabIndex = 1;
            this.radiobtnA.TabStop = true;
            this.radiobtnA.Text = "A";
            this.radiobtnA.UseVisualStyleBackColor = true;
            // 
            // radiobtnB
            // 
            this.radiobtnB.AutoSize = true;
            this.radiobtnB.Location = new System.Drawing.Point(136, 106);
            this.radiobtnB.Name = "radiobtnB";
            this.radiobtnB.Size = new System.Drawing.Size(32, 17);
            this.radiobtnB.TabIndex = 2;
            this.radiobtnB.TabStop = true;
            this.radiobtnB.Text = "B";
            this.radiobtnB.UseVisualStyleBackColor = true;
            // 
            // radiobtnC
            // 
            this.radiobtnC.AutoSize = true;
            this.radiobtnC.Location = new System.Drawing.Point(136, 150);
            this.radiobtnC.Name = "radiobtnC";
            this.radiobtnC.Size = new System.Drawing.Size(32, 17);
            this.radiobtnC.TabIndex = 3;
            this.radiobtnC.TabStop = true;
            this.radiobtnC.Text = "C";
            this.radiobtnC.UseVisualStyleBackColor = true;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(108, 209);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(182, 42);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Submit Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblScoreIs
            // 
            this.lblScoreIs.AutoSize = true;
            this.lblScoreIs.Location = new System.Drawing.Point(120, 281);
            this.lblScoreIs.Name = "lblScoreIs";
            this.lblScoreIs.Size = new System.Drawing.Size(48, 13);
            this.lblScoreIs.TabIndex = 5;
            this.lblScoreIs.Text = "Score is ";
            // 
            // lblPreviousScore
            // 
            this.lblPreviousScore.AutoSize = true;
            this.lblPreviousScore.Location = new System.Drawing.Point(120, 325);
            this.lblPreviousScore.Name = "lblPreviousScore";
            this.lblPreviousScore.Size = new System.Drawing.Size(114, 13);
            this.lblPreviousScore.TabIndex = 6;
            this.lblPreviousScore.Text = "Previous High Score is";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(336, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(88, 30);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // GuessingGameForm
            // 
            this.ClientSize = new System.Drawing.Size(436, 377);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblPreviousScore);
            this.Controls.Add(this.lblScoreIs);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.radiobtnC);
            this.Controls.Add(this.radiobtnB);
            this.Controls.Add(this.radiobtnA);
            this.Controls.Add(this.lblMakeGuess);
            this.Name = "GuessingGameForm";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.GuessingGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeAGuess;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblMakeGuess;
        private System.Windows.Forms.RadioButton radiobtnA;
        private System.Windows.Forms.RadioButton radiobtnB;
        private System.Windows.Forms.RadioButton radiobtnC;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblScoreIs;
        private System.Windows.Forms.Label lblPreviousScore;
        private System.Windows.Forms.Button btnNewGame;
    }
}

