using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GuessingGameProject
{
    public partial class GuessingGameForm : Form
    {

        private int score = 0;
        private int highScore;

        private int guessCount = 0;
        private bool gameOver = false;

        public GuessingGameForm()
        {
            InitializeComponent();
            LoadHighScore();
            DisplayHighScore();
        }

        private void LoadHighScore()
        {
            string filePath = "highscore.txt";
            if (File.Exists(filePath))
            {
                string highScoreStr = File.ReadAllText(filePath);
                if (int.TryParse(highScoreStr, out int parsedHighScore))
                {
                    highScore = parsedHighScore;
                }
                else
                {
                    highScore = 0;
                }
            }
            else
            {
                highScore = 0;
                File.WriteAllText(filePath, "0");
            }
        }

        private void DisplayHighScore()
        {
            lblPreviousScore.Text = "Previous High Score: " + highScore;
        }

        private void GuessingGameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                MessageBox.Show("Game over. Please start a new game.", "Game Over");
                return;
            }

            char[] choices = { 'A', 'B', 'C' };
            char computerChoice = choices[new Random().Next(0, 3)];
            char userGuess = ' ';

            if (radiobtnA.Checked)
            {
                userGuess = 'A';
            }
            else if (radiobtnB.Checked)
            {
                userGuess = 'B';
            }
            else if (radiobtnC.Checked)
            {
                userGuess = 'C';
            }

            if (userGuess == computerChoice)
            {
                score++;
            }

            guessCount++;
            lblScoreIs.Text = "Score: " + score;

            if (guessCount == 10)
            {
                gameOver = true;
                btnGuess.Enabled = false;
                UpdateHighScore();
                MessageBox.Show($"Game Over!\nYour Score: {score}\nHigh Score: {highScore}", "Game Over");
            }

        }

        private void UpdateHighScore()
        {
            string filePath = "highscore.txt";
            if (score > highScore)
            {
                highScore = score;
                File.WriteAllText(filePath, highScore.ToString());
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            guessCount = 0;
            score = 0;
            lblScoreIs.Text = "Score: 0";
            gameOver = false;
            btnGuess.Enabled = true;
        }
    }
}
