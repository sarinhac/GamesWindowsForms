using System.Windows.Forms;

using GameWindowsForm.Entities;


namespace GameWindowsForm.Forms.TicTacToe
{
    public partial class VictoryScreen : Form
    {
        private Player _player1;
        private Player _player2;
        public VictoryScreen(bool isVictory, string player1, string player2, string victorious)
        {
            _player1 = new Player { Name = player1 };
            _player2 = new Player { Name = player2 };

            InitializeComponent();

            if (isVictory == true)
                lblVictory.Text = $"{victorious} Wins!";
            else
            {
                if (victorious == "none")
                    lblVictory.Text = "We tied!";
                else
                    lblVictory.Text = "";
            }

        }

        private void btnYes_Click(object sender, System.EventArgs e)
        {
            TicTacToeForm newGame = new TicTacToeForm(_player1.Name, _player2.Name);
            this.Hide();
            newGame.ShowDialog();
            this.Close();
        }

        private void btnNo_Click(object sender, System.EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
