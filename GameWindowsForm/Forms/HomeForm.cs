using System;
using System.Windows.Forms;

using GameWindowsForm.Entities;
using GameWindowsForm.Forms.TicTacToe;

namespace GameWindowsForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player play1 = new Player();
            Player play2 = new Player();

            if (!string.IsNullOrEmpty(player1TxtBox.Text))
                play1.Name = player1TxtBox.Text;
            else
                play1.Name = "Player 1";

            if(!string.IsNullOrEmpty(player2TxtBox.Text))
                play2.Name = player2TxtBox.Text;
            else
                play2.Name = "Player 2";


            TicTacToeForm game = new TicTacToeForm(play1.Name, play2.Name);

            game.Show();
            this.Hide();

        }
    }
}
