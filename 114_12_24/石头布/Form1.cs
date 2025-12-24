using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Random _rand = new Random();
        private int playerScore = 0;
        private int computerScore = 0;

        public Form1()
        {
            InitializeComponent();
            ResetUI();
        }

        private void ResetUI()
        {
            lblResult.Text = "";
            HideAllPictureBoxes();
        }

        private void HideAllPictureBoxes()
        {
            // Player picture boxes
            pictureBox2.Visible = false; // paper_player
            pictureBox3.Visible = false; // stone_player
            pictureBox4.Visible = false; // scissor_player

            // Computer picture boxes
            pictureBox1.Visible = false; // paper_computer1
            pictureBox5.Visible = false; // scissor_computer
            pictureBox6.Visible = false; // stone_computer
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            Play(Choice.Rock);
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            Play(Choice.Paper);
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            Play(Choice.Scissors);
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play(Choice player)
        {
            // Hide previous images
            HideAllPictureBoxes();

            // Show player's chosen picture
            switch (player)
            {
                case Choice.Rock:
                    pictureBox3.Visible = true; // stone_player
                    break;
                case Choice.Paper:
                    pictureBox2.Visible = true; // paper_player
                    break;
                case Choice.Scissors:
                    pictureBox4.Visible = true; // scissor_player
                    break;
            }

            // Random computer choice
            var comp = (Choice)_rand.Next(0, 3);
            switch (comp)
            {
                case Choice.Rock:
                    pictureBox6.Visible = true; // stone_computer
                    break;
                case Choice.Paper:
                    pictureBox1.Visible = true; // paper_computer1
                    break;
                case Choice.Scissors:
                    pictureBox5.Visible = true; // scissor_computer
                    break;
            }

            // Determine and show winner, update scores
            showWinner(comp, player);
        }

        // Compares choices, updates score counters and UI
        private void showWinner(Choice comp, Choice player)
        {
            var result = DetermineResult(comp, player);
            switch (result)
            {
                case Result.Draw:
                    lblResult.Text = "平手";
                    break;
                case Result.Player:
                    playerScore++;
                    lblResult.Text = "玩家贏";
                    break;
                case Result.Computer:
                    computerScore++;
                    lblResult.Text = "電腦贏";
                    break;
            }

            // Update score labels (ensure labels exist in Designer)
            if (lblPlayerScore != null)
                lblPlayerScore.Text = $"玩家: {playerScore}";
            if (lblComputerScore != null)
                lblComputerScore.Text = $"電腦: {computerScore}";
        }

        private Result DetermineResult(Choice comp, Choice player)
        {
            if (comp == player) return Result.Draw;
            if ((player == Choice.Rock && comp == Choice.Scissors) ||
                (player == Choice.Paper && comp == Choice.Rock) ||
                (player == Choice.Scissors && comp == Choice.Paper))
                return Result.Player;
            return Result.Computer;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // optional: allow clicking the player image to hide it
            HideAllPictureBoxes();
            lblResult.Text = "";
        }

        private enum Choice
        {
            Rock = 0,
            Paper = 1,
            Scissors = 2
        }

        private enum Result
        {
            Draw,
            Player,
            Computer
        }
    }
}
