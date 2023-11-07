using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONeilloGameV3
{
    public partial class Form1 : Form
    {
        private const int boardSize = 8;
        private const int cellSize = 50;
        private int[,] board = new int[boardSize, boardSize];
        private int currentPlayer = 1;
        private int blackCount = 0;
        private int whiteCount = 0;
        private Timer updateTimer;

        public Form1()
        {
            InitializeComponent();
            FormComponents();
            InitialiseBoard();
            SetBoard();
            updateTimer = new Timer();
            updateTimer.Interval = 1000 / 60; // 60 FPS refresh rate
            updateTimer.Tick += new EventHandler((s, e) => { UpdateBoard(); });
            updateTimer.Start();
        }

        private void FormComponents()
        {
            int width = (boardSize * cellSize) + 20;
            int height = boardSize * cellSize + cellSize * 4;

            this.Text = "ONeillo Game V3";
            this.BackColor = Color.Green;
            this.Size = new Size(width, height);

            infoPanel.Visible = false;
        }

        private void InitialiseBoard()
        {
            board[3, 3] = board[4, 4] = 1;
            board[3, 4] = board[4, 3] = 2;
        }

        private void SetBoard()
        {
            List<Button> buttons = new List<Button>();

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Button button = new Button();
                    button.Size = new Size(cellSize, cellSize);
                    button.Location = new Point(col * cellSize, row * cellSize + 30);
                    button.Click += new EventHandler(CellClicked);
                    button.Name = "btn_" + row + "_" + col;

                    if (board[row, col] == 1)
                    {
                        button.BackColor = Color.Black;
                    }
                    else if (board[row, col] == 2)
                    {
                        button.BackColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.Green;
                    }

                    buttons.Add(button);
                }
            }

            Controls.AddRange(buttons.ToArray());
        }

        private void CellClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = button.Location.Y / cellSize;
            int col = button.Location.X / cellSize;

            if (ValidMove(row, col))
            {
                MakeMove(row, col);

                //Update the board on the UI thread
                UpdateBoard();

                if (GameOver())
                {
                    GameOverMessage();
                }
                else
                {
                    SwitchPlayer();
                }
            }
        }

        private void MakeMove(int row, int col)
        {
            int[] directionRow = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] directionCol = { -1, 0, 1, 1, 1, 0, -1, -1 };

            board[row, col] = currentPlayer;

            for (int i = 0; i < 8; i++)
            {
                int r = row + directionRow[i];
                int c = col + directionCol[i];
                bool foundOpponent = false;

                if (r < 0 || r >= boardSize || c < 0 || c >= boardSize || board[r, c] != OtherPlayer())
                {
                    continue;
                }

                while (true)
                {
                    r += directionRow[i];
                    c += directionCol[i];

                    if (r < 0 || r >= boardSize || c < 0 || c >= boardSize)
                    {
                        break;
                    }

                    if (board[r, c] == 0)
                    {
                        break;
                    }

                    if (board[r, c] == currentPlayer)
                    {
                        while (r != row || c != col)
                        {
                            r -= directionRow[i];
                            c -= directionCol[i];
                            board[r, c] = currentPlayer;
                        }
                        break;
                    }
                }
            }
        }

        private bool ValidMove(int row, int col)
        {
            if (board[row, col] != 0)
            {
                return false;
            }

            int[] directionRow = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] directionCol = { -1, 0, 1, 1, 1, 0, -1, -1 };
            bool isValidMove = false;

            for (int i = 0; i < 8; i++)
            {
                int r = row + directionRow[i];
                int c = col + directionCol[i];
                bool foundOpponent = false;

                if (r < 0 || r >= boardSize || c < 0 || c >= boardSize || board[r, c] != OtherPlayer())
                {
                    continue;
                }

                while (true)
                {
                    r += directionRow[i];
                    c += directionCol[i];

                    if (r < 0 || r >= boardSize || c < 0 || c >= boardSize)
                    {
                        break;
                    }

                    if (board[r, c] == 0)
                    {
                        break;
                    }

                    if (board[r, c] == currentPlayer)
                    {
                        isValidMove = true;
                        break;
                    }
                }
            }

            return isValidMove;
        }

        private void UpdateBoard()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Button button = (Button)Controls.Find("btn_" + row + "_" + col, true).FirstOrDefault();

                    if (button != null)
                    {
                        if (board[row, col] == 1)
                        {
                            button.BackColor = Color.Black;
                            button.Enabled = false;
                        }
                        else if (board[row, col] == 2)
                        {
                            button.BackColor = Color.White;
                            button.Enabled = false;
                        }
                        else
                        {
                            button.BackColor = Color.Green;
                            button.Enabled = ValidMove(row, col);
                        }
                    }
                }
            }
        }

        private bool GameOver()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (ValidMove(row, col))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void GameOverMessage()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (board[row, col] == 1)
                    {
                        blackCount++;
                    }
                    else if (board[row, col] == 2)
                    {
                        whiteCount++;
                    }
                }
            }

            if (blackCount > whiteCount)
            {
                MessageBox.Show("Black Wins!");
            }
            else if (whiteCount > blackCount)
            {
                MessageBox.Show("White Wins!");
            }
            else
            {
                MessageBox.Show("Draw!");
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = OtherPlayer();
            statusLabel1.Text = "Current player: " + (currentPlayer == 1 ? "Black" : "White");
        }

        private int OtherPlayer()
        {
            return currentPlayer == 1 ? 2 : 1;
        }

        private void informationPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //infoPanel.Visible = informationPanelToolStripMenuItem.Checked;
        }

        private void newGameMenuItem_Click(object sender, EventArgs e)
        {
            ClearButtons();
            InitialiseBoard();
            SetBoard();
        }

        private void ClearButtons()
        {
            //Loop through all of the Controls
            foreach (Control control in Controls)
            {
                //Check if the Control is a Button with the right name format
                if (control is Button && control.Name.StartsWith("btn_"))
                {
                    //Remove the Control from the Form
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameTab_Click(object sender, EventArgs e)
        {
            ClearButtons();
            InitialiseBoard();
            SetBoard();
            blackCount = 0;
            whiteCount = 0;
        }
    }
}