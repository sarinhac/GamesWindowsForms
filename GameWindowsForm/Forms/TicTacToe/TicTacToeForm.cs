using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using GameWindowsForm.Entities;

namespace GameWindowsForm.Forms.TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        private Player _player1;
        private Player _player2;

        List<Button> btns;

        Button[][] matrizGame;

        public TicTacToeForm(string player1, string player2)
        {
            _player1 = new Player { Name = player1 };
            _player2 = new Player { Name = player2 };

            InitializeComponent();

            btns = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (var btn in btns)
            {
                btn.BackgroundImage = null;
                btn.Enabled = true;

            }

            lblTurn.Text = $"{_player1.Name} Turn";

        }

        #region EVENTS
        private void btn1_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }
            RemoveImage(btn4);

            PutImage(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn7);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count != 0)
            {
                foreach (Button button in buttonsMark)
                {
                    RemoveImage(button);
                }
            }

            PutImage(btn9);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Button> buttonsMark = FindButtons();

            if (buttonsMark.Count == 0)
                lblMsg.Text = "You need choose a squard";
            else
            {
                lblMsg.Text = String.Empty;

                foreach (Button button in buttonsMark)
                {
                    button.Enabled = false;
                }


                if (ConfirmVictory() == false)
                {
                    buttonsMark = btns.Where(b => b.Enabled == false).ToList();
                    if (buttonsMark.Count == 9)
                    {
                        VictoryScreen victory = new VictoryScreen(false, _player1.Name, _player2.Name, "none");
                        victory.Show();
                        this.Close();
                    }
                    else if (lblTurn.Text.Contains(_player2.Name))
                        lblTurn.Text = $"{_player1.Name} Turn";
                    else if (lblTurn.Text.Contains(_player1.Name))
                        lblTurn.Text = $"{_player2.Name} Turn";
                }
                else
                {
                    string vitorioso = lblTurn.Text.Contains(_player2.Name) ? _player2.Name : _player1.Name;
                    VictoryScreen victory = new VictoryScreen(true, _player1.Name, _player2.Name, vitorioso);
                    victory.Show();
                    this.Close();
                }

            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            VictoryScreen victory = new VictoryScreen(false, _player1.Name, _player2.Name, "restart");
            victory.Show();
            this.Close();
        }
        #endregion

        #region PRIVETE METHODS
        private void PutImage(Button btn)
        {
            if (lblTurn.Text.Contains(_player1.Name))
                btn.BackgroundImage = Properties.Resources.xImg;
            else if (lblTurn.Text.Contains(_player2.Name))
                btn.BackgroundImage = Properties.Resources.oImg;
        }
        private void RemoveImage(Button btn)
        {
            btn.BackgroundImage = null;
        }

        private List<Button> FindButtons()
        {
            btns = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            List<Button> buttons = btns.Where(btn => btn.BackgroundImage != null && btn.Enabled == true).ToList();

            return buttons;
        }

        private bool ConfirmVictory()
        {
            matrizGame = new Button[][]
            {
                new Button[] { btn1, btn2, btn3},
                new Button[] { btn4, btn5, btn6},
                new Button[] { btn7, btn8, btn9},

                new Button[] { btn1, btn4, btn7},
                new Button[] { btn2, btn5, btn8},
                new Button[] { btn3, btn6, btn9},

                new Button[] { btn1, btn5, btn9},
                new Button[] { btn3, btn5, btn7}
            };

            Button[][] sequence = matrizGame.Where(arr => arr.All(btns => btns.BackgroundImage != null)).ToArray();

            if (sequence.Length == 0)
                return false;
            else
            {
                return sequence.Any(arr => arr.All(btn => btn.BackgroundImage.Width == 512) || arr.All(btn => btn.BackgroundImage.Width == 178));
            }

        }
        #endregion


    }
}
