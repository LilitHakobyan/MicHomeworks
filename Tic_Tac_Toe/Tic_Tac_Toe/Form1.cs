using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private bool turn = true;// true => x, false=> o
        private int count_Click;
        private bool compPlayer;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tic-tac-toe (also known as noughts and crosses or Xs and Os) is a paper-and-pencil game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.",
                "About Game");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";
            turn = !turn;
            count_Click++;
            btn.Enabled = false;
            CheckWin();
            if (!turn && compPlayer)
            {
                if (count_Click < 9)
                    CompMakeMove();
            }
        }

        private void CompMakeMove()
        {
            Button moveButton;
            moveButton = LookForWinOrBlock("O");
            if (moveButton == null)
            {
                moveButton = LookForWinOrBlock("X");
                if (moveButton == null)
                {
                    moveButton = LookButtonCorner("O");
                    if (moveButton == null)
                        moveButton = LookForOpenSpace();
                }
            }
            moveButton.PerformClick();
        }
        private Button LookButtonCorner(string look)
        {
            if (btn22.Text == string.Empty)
                return btn22;
            if (btn11.Text == look)
            {
                if (btn33.Text == string.Empty)
                    return btn33;
                if (btn31.Text == string.Empty)
                    return btn31;
                if (btn13.Text == string.Empty)
                    return btn13;
            }

            if (btn13.Text == look)
            {
                if (btn31.Text == string.Empty)
                    return btn31;
                if (btn11.Text == string.Empty)
                    return btn11;
                if (btn33.Text == string.Empty)
                    return btn33;
            }

            if (btn33.Text == look)
            {
                if (btn11.Text == string.Empty)
                    return btn11;
                if (btn13.Text == string.Empty)
                    return btn13;
                if (btn31.Text == string.Empty)
                    return btn31;
            }

            if (btn31.Text == look)
            {
                if (btn13.Text == string.Empty)
                    return btn13;
                if (btn11.Text == string.Empty)
                    return btn11;
                if (btn33.Text == string.Empty)
                    return btn33;
            }

            //if (btn22.Text == string.Empty)
            //    return btn22;
            if (btn11.Text == string.Empty)
                return btn11;
            if (btn13.Text == string.Empty)
                return btn13;
            if (btn31.Text == string.Empty)
                return btn31;
            if (btn33.Text == string.Empty)
                return btn33;

            return null;
        }

        private Button LookForOpenSpace()
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    if (b.Text == string.Empty)
                        return b;
                }
            }
            return null;
        }
        private Button LookForWinOrBlock(string look)
        {
            // looking for horizontal 
            if ((btn11.Text == look) && (btn12.Text == look) && (btn13.Text == string.Empty))
                return btn13;
            if ((btn11.Text == look) && (btn13.Text == look) && (btn12.Text == string.Empty))
                return btn12;
            if ((btn12.Text == look) && (btn13.Text == look) && (btn11.Text == string.Empty))
                return btn11;

            if ((btn21.Text == look) && (btn22.Text == look) && (btn23.Text == string.Empty))
                return btn23;
            if ((btn21.Text == look) && (btn23.Text == look) && (btn22.Text == string.Empty))
                return btn22;
            if ((btn22.Text == look) && (btn23.Text == look) && (btn21.Text == string.Empty))
                return btn21;

            if ((btn31.Text == look) && (btn32.Text == look) && (btn33.Text == string.Empty))
                return btn33;
            if ((btn31.Text == look) && (btn33.Text == look) && (btn32.Text == string.Empty))
                return btn32;
            if ((btn32.Text == look) && (btn33.Text == look) && (btn31.Text == string.Empty))
                return btn31;
            //looking for vertical
            if ((btn11.Text == look) && (btn21.Text == look) && (btn31.Text == string.Empty))
                return btn31;
            if ((btn11.Text == look) && (btn31.Text == look) && (btn21.Text == string.Empty))
                return btn21;
            if ((btn21.Text == look) && (btn31.Text == look) && (btn11.Text == string.Empty))
                return btn11;

            if ((btn12.Text == look) && (btn22.Text == look) && (btn32.Text == string.Empty))
                return btn32;
            if ((btn12.Text == look) && (btn32.Text == look) && (btn22.Text == string.Empty))
                return btn22;
            if ((btn22.Text == look) && (btn32.Text == look) && (btn12.Text == string.Empty))
                return btn12;

            if ((btn13.Text == look) && (btn23.Text == look) && (btn33.Text == string.Empty))
                return btn33;
            if ((btn13.Text == look) && (btn33.Text == look) && (btn23.Text == string.Empty))
                return btn23;
            if ((btn23.Text == look) && (btn33.Text == look) && (btn13.Text == string.Empty))
                return btn13;
            //looking for diagonal
            if ((btn11.Text == look) && (btn22.Text == look) && (btn33.Text == string.Empty))
                return btn33;
            if ((btn11.Text == look) && (btn33.Text == look) && (btn22.Text == string.Empty))
                return btn22;
            if ((btn22.Text == look) && (btn33.Text == look) && (btn11.Text == string.Empty))
                return btn11;

            if ((btn13.Text == look) && (btn22.Text == look) && (btn31.Text == string.Empty))
                return btn31;
            if ((btn13.Text == look) && (btn31.Text == look) && (btn22.Text == string.Empty))
                return btn22;
            if ((btn22.Text == look) && (btn31.Text == look) && (btn13.Text == string.Empty))
                return btn13;

            return null;
        }
        private void CheckWin()
        {
            bool winnerIsExist = false;
            //horizontal
            if (btn11.Text == btn12.Text && btn12.Text == btn13.Text && !btn11.Enabled)
                winnerIsExist = true;
            else if (btn21.Text == btn22.Text && btn22.Text == btn23.Text && !btn21.Enabled)
                winnerIsExist = true;
            else if (btn31.Text == btn32.Text && btn32.Text == btn33.Text && !btn31.Enabled)
                winnerIsExist = true;

            //vertical
            else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && !btn11.Enabled)
                winnerIsExist = true;
            else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && !btn12.Enabled)
                winnerIsExist = true;
            else if (btn13.Text == btn23.Text && btn23.Text == btn33.Text && !btn13.Enabled)
                winnerIsExist = true;

            //vertical
            else if (btn11.Text == btn22.Text && btn22.Text == btn33.Text && !btn11.Enabled)
                winnerIsExist = true;
            else if (btn13.Text == btn22.Text && btn22.Text == btn31.Text && !btn13.Enabled)
                winnerIsExist = true;

            if (winnerIsExist)
            {
                DisableBtns();
                string winner = string.Empty;
                if (turn)
                {
                    winner = "O";
                    OPoint.Text = (Int32.Parse(OPoint.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    XPoint.Text = (Int32.Parse(XPoint.Text) + 1).ToString();

                }
                MessageBox.Show($"Winner is {winner}", "Yuhuuuu!!!!!");
            }
            else
            {
                if (count_Click == 9)
                {
                    DPoint.Text = (Int32.Parse(DPoint.Text) + 1).ToString();
                    MessageBox.Show("Draw ", "Draw");
                }
            }
        }

        private void DisableBtns()
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b = (Button)c;
                    b.Enabled = false;
                }

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            count_Click = 0;
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b = (Button)c;
                    b.Enabled = true;
                    b.Text = string.Empty;
                }

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DPoint.Text = "0";
            OPoint.Text = "0";
            XPoint.Text = "0";
            newGameToolStripMenuItem_Click(sender, e);
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compPlayer = true;
            Player2.Text = "Compyuter Win Count";
            resetToolStripMenuItem_Click(sender, e);
        }

        private void player2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compPlayer = false;
            Player2.Text = "Player2 Win Count";
            resetToolStripMenuItem_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"https://en.wikipedia.org/wiki/Tic-tac-toe", "HelpLink");
        }
    }
}
